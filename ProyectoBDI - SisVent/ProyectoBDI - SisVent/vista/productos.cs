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
    public partial class productos : UserControl
    {
        Region rg = new Region();
        Region rg2 = new Region();
        proveedorForm proveedorForm = new proveedorForm();
        ListProducto lp = new ListProducto();

        public productos()
        {
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            CircleBorder();
            CargarProductos();
        }

        public void CircleBorder()
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse (0, 0, buscarButton.Width - 3, buscarButton.Height - 3);
            rg = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,150,40,10,10));
            rg2 = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 35, 35, 35, 35));

            avanzadoButton.Region = rg;
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
        private void CargarProductos()
        {
            DataSet ds = new DataSet();

            try
            {
                ds = lp.GetProductos();
                vistaProveedores.DataSource = ds.Tables[0];
            }
            catch(Exception ex) { }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            new avanzadoForm().ShowDialog();
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.text == "")
                    CargarProductos();
                //else
                    // aquí va el codigo del método de busqueda
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos. " + ex.ToString());
            }
        }
    }
}
