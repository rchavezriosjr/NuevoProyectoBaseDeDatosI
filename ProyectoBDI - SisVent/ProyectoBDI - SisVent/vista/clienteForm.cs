using ProyectoBDI___SisVent.data;
using ProyectoBDI___SisVent.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDI___SisVent
{
    public partial class clienteForm : Form
    {
        EditCliente c = new EditCliente();
        public clienteForm()
        {
            InitializeComponent();
            //this.TopLevel = false;
            //this.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Cliente Client = new Cliente();
            Client.C_Nombre = txtNombre.Text;
            Client.C_Domicilio = txtDireccion.Text;
            Client.C_Email = txtEmail.Text;
            Client.C_Telefono = txtTel.Text;
            try
            {
                c.InsertarCliente(Client);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Inserción fallida: "+ex.ToString());
            }
            this.Close();
        }
    }
}
