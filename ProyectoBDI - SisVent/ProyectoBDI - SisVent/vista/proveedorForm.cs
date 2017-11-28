using ProyectoBDI___SisVent.data;
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
    public partial class proveedorForm : Form
    {
        Proveedor p = new Proveedor();
        EditProveedores np = new EditProveedores();
        public proveedorForm()
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
            p.P_Nombre = txtNombre.Text;
            p.P_Domicilio = txtDireccion.Text;
            p.P_Email = txtEmail.Text;
            p.P_Telefono = txtTel.Text;
            try
            {
                np.InsertarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString());
            }
            this.Close();
        }
    }
}
