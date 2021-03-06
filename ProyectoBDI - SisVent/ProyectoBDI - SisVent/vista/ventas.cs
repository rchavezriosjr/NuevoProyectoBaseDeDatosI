﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoBDI___SisVent.data;

namespace ProyectoBDI___SisVent.vista
{
    public partial class ventas : UserControl
    {
        Region rg = new Region();
        Region rg2 = new Region();

        public ventas()
        {
            InitializeComponent();
        }

        public void CircleBorder()
        {
            rg = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 150, 40, 10, 10));
            rg2 = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 35, 35, 35, 35));

            agregarButton.Region = rg;
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

        private void compras_Load(object sender, EventArgs e)
        {
            CircleBorder();
            cargar();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            new ventaForm().ShowDialog();
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.text == "")
                    cargar();
                else
                    vistaVentas.DataSource = new venta().Buscar(txtBuscar.text, metodoBusqueda.SelectedIndex);
            }
            catch (Exception ex)
            {
                new popup("Error al cargar productos", popup.AlertType.error);
            }
        }

        public void cargar()
        {
            try
            {
                vistaVentas.DataSource = new venta().Mostrar();
            }
            catch(Exception ex) { }
        }

        private void vistaVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new ventaForm(vistaVentas.Rows[e.RowIndex].Cells[0].Value.ToString()).ShowDialog();
        }
    }
}
