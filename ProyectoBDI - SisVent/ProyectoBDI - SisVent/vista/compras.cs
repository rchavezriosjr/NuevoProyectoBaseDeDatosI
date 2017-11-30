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
    public partial class compras : UserControl
    {
        Region rg = new Region();
        Region rg2 = new Region();
        ListCompra lcmp= new ListCompra();

        public compras()
        {
            InitializeComponent();
            try
            {
                CargarCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compras. " + ex.ToString());
            }
        }

        public void CircleBorder()
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse (0, 0, buscarButton.Width - 3, buscarButton.Height - 3);
            rg = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 150, 40, 10, 10));
            rg2 = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 35, 35, 35, 35));

            agregarButton.Region = rg;

            seeButton.Region = rg2;
            editButton.Region = rg2;
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
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            new compraForm().ShowDialog();
        }

        public void CargarCompras()
        {
            DataSet ds = new DataSet();
            ds = lcmp.GetCompras();
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}