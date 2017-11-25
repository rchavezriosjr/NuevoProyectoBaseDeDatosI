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
    public partial class ventaForm : Form
    {

        public ventaForm()
        {
            InitializeComponent();
        }

        private void txtProveedor_Leave(object sender, EventArgs e)
        {
            Transition.run(panelDatosVenta, "Height", 160, new TransitionType_EaseInEaseOut(1000));
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                Transition.run(panelDatosVenta, "Height", 323, new TransitionType_EaseInEaseOut(1000));
                panelDatosVenta.BringToFront();
            }
            else
            {
                Transition.run(panelDatosVenta, "Height", 160, new TransitionType_EaseInEaseOut(1000));
                panelDatosVenta.SendToBack();
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                Transition.run(panelDatosDetalleVenta, "Height", 260, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleVenta.BringToFront();
            }
            else
            {
                Transition.run(panelDatosDetalleVenta, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleVenta.BringToFront();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
