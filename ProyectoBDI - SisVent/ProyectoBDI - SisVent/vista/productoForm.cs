using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDI___SisVent.vista
{
    public partial class productoForm : Form
    {
        public productoForm()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
