using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDI___SisVent.datos;
using ProyectoBDI___SisVent.Utilidades;
using ProyectoBDI___SisVent.vista;
using Transitions;

namespace ProyectoBDI___SisVent
{
    public partial class login : Form
    {
        bool passvisible = false;
        List<string> txt = new List<string>();
        home home = new home();
        public login()
        {
            InitializeComponent();
            password.isPassword = true;
        }

        bool f = true;
        public int index;
        public string UsernameID;
        public string NameUser;
        public string LastNameUser;

        private void login_Load(object sender, EventArgs e)
        {
            txt.Add("Iniciando");
            txt.Add("Iniciando .");
            txt.Add("Iniciando . .");
            txt.Add("Iniciando . . .");

            loading.Height = 0;
            roundborders();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (new loginDiag("¿ Desea salir ?", true, false, true).ShowDialog() == DialogResult.OK)
                Environment.Exit(0);
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                password.Focus();
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ingresar_Click(null, null);

            }
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if (verifica())
            {
                showPreloader();
                new popup("Bienvenido...", popup.AlertType.check);
            }
            else
            {
                new popup("Usuario o contraseña incorrectos", popup.AlertType.error);
            }
        }

        private bool verifica()
        {
            bool ver = false;
            try
            {   
                DataTable Datos = new user().Verifica(this.username.Text,this.password.Text);
                
                if (Datos.Rows.Count != 0){ver= true;}
                else {ver= false;}
            
                return ver;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                return ver;
            }
        }

        private void password_OnValueChanged(object sender, EventArgs e)
        {
            if (!passvisible)
                password.isPassword = true;
        }

        int i = 0;
        private void texto_Tick(object sender, EventArgs e)
        {
            label.Text = txt[i];

            if (i < txt.Count - 1)
                i++;
            else
                i = 0;
        }

        private void duracion_Tick(object sender, EventArgs e)
        {
            home.setInfo(username.Text);
            home.Show();

            duracion.Stop();
            this.Hide();
        }

        private void showPreloader()
        {
            Transition.run(this, "Left", (this.Left + 185), new TransitionType_EaseInEaseOut(1000));
            Transition.run(this, "Width", 370, new TransitionType_EaseInEaseOut(1200));
            Transition.run(loading, "Height", 503, new TransitionType_EaseInEaseOut(1500));
            texto.Start();
            duracion.Start();
        }

        private void roundborders()
        {
            contentUser.Region = new region().RoundBorder(280, 35, 30);
            contentPassword.Region = new region().RoundBorder(280, 35, 30);
            picture.Region = new region().Circle(picture.Width, picture.Height);
        }

        private void viewpass_MouseDown(object sender, MouseEventArgs e)
        {
            password.isPassword = false;
            passvisible = true;
        }

        private void viewpass_MouseUp(object sender, MouseEventArgs e)
        {
            password.isPassword = true;
            passvisible = false;
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (username.Text != "")
                picture.Image = new user().obtenerFoto(username.Text);
        }
    }
}
