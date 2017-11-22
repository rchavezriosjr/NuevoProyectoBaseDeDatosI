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

namespace ProyectoBDI___SisVent.vista
{
    public partial class clientes : UserControl
    {
        Region rg = new Region();
        clienteForm clienteForm = new clienteForm();
        string tabActive = "";

        public clientes()
        {
            InitializeComponent();
            //this.Dock = DockStyle.Fill;
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            //CircleBorder();
            panelNC.Width = 0;
            panelLC.Height = 0;
            panelBuscar.Width = 0;

            addClienteForm();
        }

        public void CircleBorder()
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse (0, 0, buscarButton.Width - 3, buscarButton.Height - 3);
            rg = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,180,50,50,50));

            buscarButton.Region = rg;
            agregarButton.Region = rg;
            listarButton.Region = rg;
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

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (tabActive != "buscar")
            {
                tabActive = "buscar";
                panelNC.Width = 0;
                panelLC.Height = 0;
                Transition.run(panelBuscar, "Width", 612, new TransitionType_EaseInEaseOut(1200));
            }
            else
            {
                tabActive = "";
                Transition.run(panelBuscar, "Width", 0, new TransitionType_EaseInEaseOut(1200));
            }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (tabActive != "agregar")
            {
                tabActive = "agregar";
                panelLC.Height = 0;
                panelBuscar.Width = 0;
                Transition.run(panelNC, "Width", 612, new TransitionType_EaseInEaseOut(1200));
            }
            else
            {
                tabActive = "";
                Transition.run(panelNC, "Width", 0, new TransitionType_EaseInEaseOut(1200));
            }
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            if (tabActive != "listar")
            {
                tabActive = "listar";
                panelBuscar.Width = 0;
                panelNC.Width = 0;
                Transition.run(panelLC, "Height", 612, new TransitionType_EaseInEaseOut(1200));
            }
            else
            {
                tabActive = "";
                Transition.run(panelLC, "Height", 0, new TransitionType_EaseInEaseOut(1200));
            }
        }

        public void addClienteForm()
        {
            panelNC.Controls.Add(clienteForm);
            clienteForm.Top = (contenedor.Height - clienteForm.Height) / 2;
            clienteForm.Left = (contenedor.Width - clienteForm.Width) / 2;
        }
    }
}
