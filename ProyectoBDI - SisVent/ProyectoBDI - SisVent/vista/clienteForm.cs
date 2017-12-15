using ProyectoBDI___SisVent.data;
using ProyectoBDI___SisVent.vista;
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
    public partial class clienteForm : Form
    {
        string accionformulario;
        public clienteForm()
        {
            InitializeComponent();
            accionformulario = "crear";
            //this.TopLevel = false;
            //this.Show();
        }

        public clienteForm(int id)
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
            {
                ReadStatus(true);
                setDataView(int.Parse(txtID.Text));
            }
                
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear" || accionformulario == "editar")
            {
                Cliente Client = new Cliente();
                Client.C_Nombre = txtNombre.Text;
                Client.C_Domicilio = txtDireccion.Text;
                Client.C_Email = txtEmail.Text;
                Client.C_Telefono = txtTel.Text;

                if (accionformulario == "crear")
                {
                    try { Client.Insertar(); }
                    catch (Exception ex) { MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString()); }
                    this.Close();
                }
                else
                {
                    try {
                        Client.C_Id = int.Parse(txtID.Text);
                        Client.Editar();
                    }
                    catch (Exception ex) { MessageBox.Show("ERROR: Actualización fallida: " + ex.ToString()); }
                    ReadStatus(true);
                    setDataView(int.Parse(txtID.Text));
                }

            }
            else
                this.Close();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clienteForm_Load(object sender, EventArgs e)
        {
            if(accionformulario == "crear"){
                editarButton.Visible = false;
                labelID.Visible = false;
                txtID.Visible = false;
                guardar.ButtonText = "Guardar";
            }else if(accionformulario == "ver")
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
            using(SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select * from Cliente where ID = '" + id+"'",
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
