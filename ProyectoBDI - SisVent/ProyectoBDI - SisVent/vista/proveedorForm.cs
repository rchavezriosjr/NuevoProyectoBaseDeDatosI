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
    }
}
