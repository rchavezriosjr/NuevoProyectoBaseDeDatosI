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

namespace ProyectoBDI___SisVent
{
    public partial class loginDiag : Form
    {
        login l = new login();
        public loginDiag(String msj, bool y, bool a, bool n)
        {
            InitializeComponent();
            mensaje.Enabled = false;
            mensaje.Text = msj;
            yes.Visible = y;
            aceptar.Visible = a;
            no.Visible = n;

            
        }

        private void loginDiag_Load(object sender, EventArgs e)
        {
            this.Height = this.Height + 30;

        }

        private void yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
