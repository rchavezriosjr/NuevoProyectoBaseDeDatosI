using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDI___SisVent
{
    public partial class Register : Form
    {
        bool edt = false;
        string n, a, nu, p;
        Image pic;
        public Register(bool e)
        {
            InitializeComponent();
            CircleUserPicture();
            lateral.Visible = false;
            bac.Visible = false;
            pass.isPassword = true;
            confirPass.isPassword = true;

            edt = e;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (CVacios()){
                popup p = new popup("Campos vacios...", popup.AlertType.error);

            }else{
                if (pass.Text.Equals(confirPass.Text)){

                    if (edt)
                    {
                        editInfo();
                    }
                    else
                    {
                        saveNew();
                    }
                    
                    this.Close();

                }else{
                    popup p = new popup("Contraseñas no coinciden...", popup.AlertType.error);
                }
            }
            
        }

        private bool CVacios()
        {
            bool vacio = false;

            if (nomUser.Text.Equals("")) { vacio = true; }    

            if (pass.Text.Equals("")) { vacio = true; }  

            if (confirPass.Text.Equals("")) { vacio = true; }
            Console.Write(vacio);
            return vacio;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(val())
            {
                bunifuTransition1.ShowSync(lateral);
                bac.Visible = true;
                if(!edt)
                    nomUser.Text = "@" + nombreTxt.Text.Substring(0, 3) + apellidoTxt.Text.Substring(0, 3);
            }
            else
            {
                popup p = new popup("Rellenar todos los campos", popup.AlertType.error);
            }
        }

        public bool val()
        {
            bool val = true;

            if (nombreTxt.Text.Equals("")) { val = false; }
            if(apellidoTxt.Text.Equals("")) { val = false; }

            return val;
        }

        private void nomUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                pass.Focus();
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                confirPass.Focus();
        }

        private void confirPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                registrar_Click(null, null);
        }

        private void apellidoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                pass.Focus();
                next_Click(null, null);
            }
        }

        private void nombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                apellidoTxt.Focus();
        }

        private void bac_Click(object sender, EventArgs e)
        {
            lateral.Visible = false;
            bac.Visible = false;
        }

        void saveNew()
        {
            //user u = new user();
            //datosUser du = new datosUser();

            //u.Nombre = nombreTxt.Text;
            //u.Apellido = apellidoTxt.Text;
            //u.UserName = nomUser.Text;
            //u.Password = pass.Text;
            //u.PPic = perfil.Image;

            //du.addUser(u);
            //Console.WriteLine(du.getUsers()[0].UserName + "  " + du.getUsers()[0].Password);
            new popup("Usuario creado correctamente", popup.AlertType.check);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Console.WriteLine(edt);
            if (edt)
            {
                Edit();
            }
        }

        public void Edit()
        {
            nombreTxt.Text = n;
            apellidoTxt.Text = a;
            nomUser.Text = nu;
            pass.Text = p;
            perfil.Image = pic;

        }

        private void perfil_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagen = new Bitmap(open.FileName);
                perfil.Image = imagen;
            }
        }

        private void nombreTxt_Leave(object sender, EventArgs e)
        {
            nombreTxt.Text = nombreTxt.Text.Replace(nombreTxt.Text[0], nombreTxt.Text.ToUpper()[0]);
        }

        private void apellidoTxt_Leave(object sender, EventArgs e)
        {
            apellidoTxt.Text = apellidoTxt.Text.Replace(apellidoTxt.Text[0], apellidoTxt.Text.ToUpper()[0]);
        }

        public void setInfo(string nom, string ape, string nUs, string ps, Image pct)
        {
            this.n = nom;
            this.a = ape;
            this.nu = nUs;
            this.p = ps;
            this.pic = pct;
        }

        public void editInfo()
        {
            //user tem = new user();
            //datosUser du = new datosUser();
            //home h = new home();

            //tem.Nombre = nombreTxt.Text;
            //tem.Apellido = apellidoTxt.Text;
            //tem.UserName = nomUser.Text;
            //tem.Password = pass.Text;
            //tem.PPic = perfil.Image;

            //du.getUsers()[index] = tem;
            //h.setInfo(nombreTxt.Text, apellidoTxt.Text, perfil.Image);
            new popup("Cambios guardados correctamente", popup.AlertType.check);
        }

        public void CircleUserPicture()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, perfil.Width - 3, perfil.Height - 3);
            Region rg = new Region(gp);
            perfil.Region = rg;
        }


    }
}
