﻿using System;
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
    public partial class home : Form
    {
        Bunifu.Framework.UI.Drag drag = new Bunifu.Framework.UI.Drag();
        string tabActiva = "";

        inicio inicio = new inicio();
        clientes clientes = new clientes();
        proveedores proveedores = new proveedores();
        productos productos = new productos();
        compras compras = new compras();
        ventas ventas = new ventas();
        adminCuentas adminCuentas = new adminCuentas();

        public home()
        {
            InitializeComponent();
            navbar.Width = 0;
        }

        // evt carga del form
        private void home_Load(object sender, EventArgs e)
        {
            CircleUserPicture();
            tabActiva = "inicio";
            this.contenedor.Controls.Add(inicio);
            this.contenedor.Controls.Add(clientes);
            this.contenedor.Controls.Add(proveedores);
            this.contenedor.Controls.Add(productos);
            this.contenedor.Controls.Add(compras);
            this.contenedor.Controls.Add(ventas);
            this.contenedor.Controls.Add(adminCuentas);

            inicio.BringToFront();
            timerTab.Start();
        }

        private void navbar_Paint(object sender, PaintEventArgs e)
        {

        }


        // evento boton menu
        private void menu_Click(object sender, EventArgs e)
        {
            if(navbar.Width == 0)
            {
                Transition.run(navbar, "Width", 240, new TransitionType_EaseInEaseOut(1000));
                menu.Image = ProyectoBDI___SisVent.Properties.Resources.Circled_Chevron_Left_40px;
            }
            else
            {
                Transition.run(navbar, "Width", 0, new TransitionType_EaseInEaseOut(1000));
                menu.Image = ProyectoBDI___SisVent.Properties.Resources.Menu_40px;
            }
                
        }


        // evt close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            new loginDiag("¿Desea salir?", true, false, true).ShowDialog();
        }


        // evt min button
        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // eventos para el arrastre del form
        private void toppanel_MouseDown(object sender, MouseEventArgs e){
            drag.Grab(this);
        }

        private void toppanel_MouseUp(object sender, MouseEventArgs e){
            drag.Release();
        }

        private void toppanel_MouseMove(object sender, MouseEventArgs e){
            drag.MoveObject();
        }

        /* * * * Métodos * * * */
        public void CircleUserPicture()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, userPicture.Width - 3, userPicture.Height - 3);
            Region rg = new Region(gp);
            userPicture.Region = rg;
        }

        private void timerTab_Tick(object sender, EventArgs e)
        {
            switch (tabActiva)
            {
                case "inicio":
                    inicioTab.BackColor = Color.SeaGreen;
                    break;

                case "clientes":
                    clientesTab.BackColor = Color.SpringGreen;
                    break;

                case "ventas":
                    VentasTab.BackColor = Color.FromArgb(78, 205, 196);
                    break;

                case "compras":
                    comprasTab.BackColor = Color.FromArgb(60, 141, 188);
                    break;

                case "productos":
                    productosTab.BackColor = Color.FromArgb(144, 100, 239);
                    break;

                case "proveedor":
                    proveedorTab.BackColor = Color.FromArgb(249, 96, 179);
                    break;

                case "cuentas":
                    adminCuentasTab.BackColor = Color.FromArgb(229, 57, 69);
                    break;
            }
        }

        private void clearColorTabs()
        {
            inicioTab.BackColor = Color.FromArgb(47, 50, 58);
            clientesTab.BackColor = Color.FromArgb(47, 50, 58);
            VentasTab.BackColor = Color.FromArgb(47, 50, 58);
            comprasTab.BackColor = Color.FromArgb(47, 50, 58);
            productosTab.BackColor = Color.FromArgb(47, 50, 58);
            proveedorTab.BackColor = Color.FromArgb(47, 50, 58);
            adminCuentasTab.BackColor = Color.FromArgb(47, 50, 58);

        }

        private void inicioTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "inicio")
            {
                clearColorTabs();
                tabActiva = "inicio";
                inicio.BringToFront();
            }
        }

        private void clientesTab_Click(object sender, EventArgs e)
        {
            if(tabActiva != "clientes")
            {
                clearColorTabs();
                tabActiva = "clientes";
                clientes.BringToFront();
            }
        }

        private void VentasTab_Click(object sender, EventArgs e)
        {
            if(tabActiva != "ventas")
            {
                clearColorTabs();
                tabActiva = "ventas";
                ventas.BringToFront();
            }
        }

        private void comprasTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "compras")
            {
                clearColorTabs();
                tabActiva = "compras";
                compras.BringToFront();
            }
        }

        private void productosTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "productos")
            {
                clearColorTabs();
                tabActiva = "productos";
                productos.BringToFront();
            }
        }

        private void proveedorTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "proveedor")
            {
                clearColorTabs();
                tabActiva = "proveedor";
                proveedores.BringToFront();
            }
        }

        private void adminCuentasTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "cuentas")
            {
                clearColorTabs();
                tabActiva = "cuentas";
                adminCuentas.BringToFront();
            }
        }

        private void userPicture_Click(object sender, EventArgs e)
        {
            new Register(true).ShowDialog();
        }
    }
}
