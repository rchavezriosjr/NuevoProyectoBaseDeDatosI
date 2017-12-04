using ProyectoBDI___SisVent.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDI___SisVent.vista
{
    public partial class categoriaForm : Form
    {
        string accionformulario;
        public categoriaForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public categoriaForm(int id)
        {
            InitializeComponent();
            accionformulario = "ver";
            setDataView(id);
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear")
                this.Close();
            else
                ReadStatus(true);
        }

        private void categoriaForm_Load(object sender, EventArgs e)
        {
            if (accionformulario == "crear")
            {
                editarButton.Visible = false;
                txtId.Visible = false;
                labelID.Visible = false;
                aceptar.ButtonText = "Guardar";
            }
            else if (accionformulario == "ver")
            {
                ReadStatus(true);
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear" || accionformulario == "editar")
            {
                Categoria c = new Categoria();
                c.Nombre = txtNombre.Text;
                c.Descripcion = txtDescripcion.Text;
                if (estadoValor.Checked)
                    c.Estado = 1;
                else
                    c.Estado = 0;
            
                if (accionformulario == "crear")
                {
                    try {
                        new DataCategory().AddCategory(c);
                    }
                    catch (Exception ex) { MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString()); }
                    this.Close();
                }
                else
                {
                    try {
                        c.ID = int.Parse(txtId.Text);
                        new DataCategory().UpdateCategory(c);
                    }
                    catch (Exception ex) { MessageBox.Show("ERROR: Actualización fallida: " + ex.ToString()); }
                    ReadStatus(true);
                }

            }
            else
                this.Close();
        }

        private void ReadStatus(bool status)
        {
            if (status)
            {
                accionformulario = "ver";
                editarButton.Visible = true;
                cancelar.Visible = false;
                aceptar.ButtonText = "Cerrar";

                txtNombre.Enabled = false;
                txtDescripcion.Enabled = false;
                estadoValor.Enabled = false;
            }
            else
            {
                accionformulario = "editar";
                txtNombre.Enabled = true;
                txtDescripcion.Enabled = true;
                estadoValor.Enabled = true;

                editarButton.Visible = false;
                cancelar.Visible = true;
                aceptar.ButtonText = "Guardar";
            }
        }


        private void setDataView(int id)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Categoria");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select * from Categoria where ID = " + id,
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtId.Text = row["ID"].ToString();
                    txtNombre.Text = row["Nombre"].ToString();
                    txtDescripcion.Text = row["Descripcion"].ToString();
                    if (int.Parse(row["Estado"].ToString()) == 0)
                        estadoValor.Checked = false;
                    else
                        estadoValor.Checked = true;
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }

        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            ReadStatus(false);
        }
    }
}
