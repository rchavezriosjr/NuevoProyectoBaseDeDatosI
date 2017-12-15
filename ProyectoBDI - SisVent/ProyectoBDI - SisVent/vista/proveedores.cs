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
            rg2 = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 40, 40, 40, 40));

            agregarButton.Region = rg;

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

        public void Cargar()
        {
            try
            {
                vistaProveedores.DataSource = new Proveedor().Mostrar();
            }
            catch (Exception ex) { }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            new proveedorForm().ShowDialog();
        }

        private void vistaProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new proveedorForm(int.Parse(vistaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString())).ShowDialog();
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            if (txtBuscar.text=="")
                Cargar();
            else
                vistaProveedores.DataSource = new Proveedor().Buscar(txtBuscar.text, metodoBusqueda.SelectedIndex);
        }
    }
}
