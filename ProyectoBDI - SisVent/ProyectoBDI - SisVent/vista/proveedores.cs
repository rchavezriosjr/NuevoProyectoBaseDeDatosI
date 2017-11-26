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
    public partial class proveedores : UserControl
    {
        Region rg = new Region();
        Region rg2 = new Region();
        proveedorForm proveedorForm = new proveedorForm();
        ListProveedor lp = new ListProveedor();

        public proveedores()
        {
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            CircleBorder();
        }

        public void CircleBorder()
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse (0, 0, buscarButton.Width - 3, buscarButton.Height - 3);
            rg = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,170,40,10,10));
            rg2 = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 35, 35, 35, 35));

            agregarButton.Region = rg;
            listarButton.Region = rg;

            seeButton.Region = rg2;
            editButton.Region = rg2;
            erraseButton.Region = rg2;
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

        public void CargarProveedores()
        {
            DataSet ds = new DataSet();
            ds = lp.GetProveedores();
            vistaProveedores.DataSource = ds.Tables[0];
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            proveedorForm.ShowDialog();
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            try
            {
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores. " + ex.ToString());
            }
        }

    }
}
