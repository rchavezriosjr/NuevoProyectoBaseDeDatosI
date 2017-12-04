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

namespace ProyectoBDI___SisVent
{
    public partial class proveedorForm : Form
    {
        Proveedor p = new Proveedor();
        EditProveedores np = new EditProveedores();
        string accionformulario;
        public proveedorForm()
        {
            InitializeComponent();
            accionformulario = "crear";
            //this.TopLevel = false;
            //this.Show();
        }

        public proveedorForm(int id)
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

        private void guardar_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear" || accionformulario == "editar")
            {
                p.P_Nombre = txtNombre.Text;
                p.P_Domicilio = txtDireccion.Text;
                p.P_Email = txtEmail.Text;
                p.P_Telefono = txtTel.Text;

                if (accionformulario == "crear")
                {
                    try { np.InsertarProveedor(p); }
                    catch (Exception ex) { MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString()); }
                    this.Close();
                }
                else
                {
                    try {
                        p.P_Id = int.Parse(txtID.Text);
                        np.ActualizaProveedor(p); }
                    catch (Exception ex) { MessageBox.Show("ERROR: Actualización fallida: " + ex.ToString()); }
                    ReadStatus(true);
                }

            }
            else
                this.Close();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void proveedorForm_Load(object sender, EventArgs e)
        {
            if (accionformulario == "crear")
            {
                editarButton.Visible = false;
                txtID.Visible = false;
                labelID.Visible = false;
                guardar.ButtonText = "Guardar";
            }
            else if (accionformulario == "ver")
            {
                ReadStatus(true);
            }
        }

        private void ReadStatus(bool status)
        {
            if (status)
            {
                accionformulario = "ver";
                editarButton.Visible = true;
                cancelar.Visible = false;
                guardar.ButtonText = "Cerrar";

                txtNombre.Enabled = false;
                txtEmail.Enabled = false;
                txtTel.Enabled = false;
                txtDireccion.Enabled = false;
            }
            else
            {
                accionformulario = "editar";
                txtNombre.Enabled = true;
                txtEmail.Enabled = true;
                txtTel.Enabled = true;
                txtDireccion.Enabled = true;

                editarButton.Visible = false;
                cancelar.Visible = true;
                guardar.ButtonText = "Guardar";
            }
        }

        private void setDataView(int id)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Cliente");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select * from Proveedor where ID = " + id,
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtID.Text = row["ID"].ToString();
                    txtNombre.Text = row["Nombre"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtTel.Text = row["Telefono"].ToString();
                    txtDireccion.Text = row["Domicilio"].ToString();
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
