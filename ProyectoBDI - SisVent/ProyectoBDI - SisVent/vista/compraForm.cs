using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace ProyectoBDI___SisVent.vista
{
    public partial class compraForm : Form
    {

        public compraForm()
        {
            InitializeComponent();
        }

        private void txtProveedor_Leave(object sender, EventArgs e)
        {
            Transition.run(panelDatosCompra, "Height", 160, new TransitionType_EaseInEaseOut(1000));
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtProveedor.Text != "")
            {
                Transition.run(panelDatosCompra, "Height", 323, new TransitionType_EaseInEaseOut(1000));
                panelDatosCompra.BringToFront();
            }
            else
            {
                Transition.run(panelDatosCompra, "Height", 160, new TransitionType_EaseInEaseOut(1000));
                panelDatosCompra.SendToBack();
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                Transition.run(panelDatosDetalleCompra, "Height", 260, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleCompra.BringToFront();
            }
            else
            {
                Transition.run(panelDatosDetalleCompra, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleCompra.BringToFront();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearProducto_Click(object sender, EventArgs e)
        {
            new productoForm().ShowDialog();
        }

        private void compraForm_Load(object sender, EventArgs e)
        {
            txtCodigoCompra.Text = generaCodFactura();
        }

        private string generaCodFactura()
        {
            string codigo;
            DateTime fa = DateTime.Today;

            codigo = "C" + fa.Day + fa.Month + fa.Year.ToString().Substring(2, 2);
            codigo += "-" +fa.ToShortTimeString().Replace(":", "-");

            return codigo;
        }
    }
}
