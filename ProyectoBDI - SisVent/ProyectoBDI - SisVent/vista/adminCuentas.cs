using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Transitions;
using ProyectoBDI___SisVent.data;

namespace ProyectoBDI___SisVent.vista
{
    public partial class adminCuentas : UserControl
    {
        Region rg = new Region();
        Region rg2 = new Region();
        
        public adminCuentas()
        {
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            CircleBorder();
            contentPanelGeneral.Width = 632;
        }

        public void CircleBorder()
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse (0, 0, buscarButton.Width - 3, buscarButton.Height - 3);
            rg = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,150,40,10,10));
            rg2 = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 40, 40, 40, 40));

            agregarButton.Region = rg;
            erraseButton.Region = rg2;
            panelCompras.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 200, 50, 20, 20));
            panelVentas.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 200, 50, 20, 20));
            panelGeneral.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 200, 50, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void comprasClick_Click(object sender, EventArgs e)
        {
            hidden();
            Transition.run(contentPanelCompras, "Width", 632, new TransitionType_EaseInEaseOut(1000));
        }

        private void ventasClick_Click(object sender, EventArgs e)
        {
            hidden();
            Transition.run(panelContentVentas, "Height", 450, new TransitionType_EaseInEaseOut(1000));
        }

        private void generalClick_Click(object sender, EventArgs e)
        {
            hidden();
            Transition.run(contentPanelGeneral, "Width", 632, new TransitionType_EaseInEaseOut(1000));
        }

        public void hidden()
        {
            contentPanelCompras.Width = 0;

            panelContentVentas.Height = 0;

            contentPanelGeneral.Width = 0;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }
    }
}
