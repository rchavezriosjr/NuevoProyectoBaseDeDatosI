using ProyectoBDI___SisVent.datos;
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
    public partial class dialogoConfirmarContraseña : Form
    {
        string param;
        public dialogoConfirmarContraseña(string valor)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 400, 155, 10, 10));
            this.panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 398, 153, 10, 10));

            param = valor;
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

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                bunifuThinButton21_Click(null, null);
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.isPassword = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            verifica();
            this.Close();
        }

        public void verifica()
        {
            try
            {
                DataTable Datos = new user().Verifica(param, this.bunifuMaterialTextbox1.Text);
                if (Datos.Rows.Count != 0)
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
