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
using Transitions;
using ProyectoBDI___SisVent.data;

namespace ProyectoBDI___SisVent.vista
{
    public partial class clientes : UserControl
    {
        Region rg = new Region();
        Region rg2 = new Region();
        clienteForm clienteForm = new clienteForm();
        ListCliente lc = new ListCliente();

        public clientes()
        {
            try
            {
                vistaClientes.DataSource = new Busqueda().MostrarClientes();
            }
            catch (Exception)
            {

                //throw;
            }
            
            InitializeComponent();
        }

        public void CargarClientes()
        {
            vistaClientes.DataSource = new Busqueda().MostrarClientes();
        }
        private void clientes_Load(object sender, EventArgs e)
        {
            CircleBorder();
            CargarClientes();
        }

        public void CircleBorder()
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse (0, 0, buscarButton.Width - 3, buscarButton.Height - 3);
            rg = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,150,40,10,10));
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


        private void agregarButton_Click(object sender, EventArgs e)
        {
            clienteForm.ShowDialog();
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            try
            {
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes " + ex.ToString());
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new clienteForm(int.Parse(vistaClientes.Rows[e.RowIndex].Cells[0].Value.ToString())).ShowDialog();
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            if (txtBuscar.text == "")
                vistaClientes.DataSource = new Busqueda().MostrarClientes();
            else
                vistaClientes.DataSource = new Busqueda().BusquedaCliente(txtBuscar.text, metodoBusqueda.SelectedIndex);
        }
    }
}
