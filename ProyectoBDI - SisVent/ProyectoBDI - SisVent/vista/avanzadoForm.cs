using ProyectoBDI___SisVent.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDI___SisVent.vista
{
    public partial class avanzadoForm : Form
    {
        Region rg = new Region();
        Region rg2 = new Region();
        public avanzadoForm()
        {
            InitializeComponent();
            CircleBorder();
        }

        public void CircleBorder()
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse (0, 0, buscarButton.Width - 3, buscarButton.Height - 3);
            rg = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 170, 35, 10, 10));
            //rg2 = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 30, 30, 30, 30));

            agregarCategoria.Region = rg;

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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarCategoria_Click_1(object sender, EventArgs e)
        {
            new categoriaForm().ShowDialog();
        }

        private void vistaCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new categoriaForm(int.Parse(vistaCategorias.Rows[e.RowIndex].Cells[0].Value.ToString())).ShowDialog();
        }

        private void vistaProductosInhabilitados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new productoForm(int.Parse(vistaProductosInhabilitados.Rows[e.RowIndex].Cells[0].Value.ToString())).ShowDialog();
        }

        private void txtBuscarCategoria_OnTextChange(object sender, EventArgs e)
        {
            if (mostrarInhabilitados.Checked)
            {
                if (txtBuscarCategoria.text == "")
                    vistaCategorias.DataSource = new Busqueda().MostrarCategoria(0);
                else
                    vistaCategorias.DataSource = new Busqueda().BusquedaCategoria(txtBuscarCategoria.text, 0);
            }
            else
            {
                if (txtBuscarCategoria.text == "")
                    vistaCategorias.DataSource = new Busqueda().MostrarCategoria(1);
                else
                    vistaCategorias.DataSource = new Busqueda().BusquedaCategoria(txtBuscarCategoria.text, 1);
            }
        }

        private void txtBuscarProductoInhabilitado_OnTextChange(object sender, EventArgs e)
        {
            if (txtBuscarProductoInhabilitado.text == "")
                vistaProductosInhabilitados.DataSource = new Busqueda().MostrarProductosDeshabilitados();
            else
                vistaProductosInhabilitados.DataSource = new Busqueda().BusquedaProductosDeshabilitados(txtBuscarProductoInhabilitado.text, 0);
        }
    }
}
