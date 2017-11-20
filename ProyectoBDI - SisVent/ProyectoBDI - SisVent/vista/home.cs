using System;
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

        public home()
        {
            InitializeComponent();
            navbar.Width = 0;
        }

        // evt carga del form
        private void home_Load(object sender, EventArgs e)
        {
            CircleUserPicture();
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
                menu.Image = ProyectoBDI___SisVent.Properties.Resources.Xbox_Menu_40px;
            }
                
        }


        // evt close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

    }
}
