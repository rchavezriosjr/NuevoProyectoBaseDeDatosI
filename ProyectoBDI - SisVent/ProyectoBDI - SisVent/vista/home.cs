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
        public home()
        {
            InitializeComponent();
            navbar.Width = 0;
        }

        private void navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            if(navbar.Width == 0)
                Transition.run(navbar, "Width", 240, new TransitionType_EaseInEaseOut(1000));
            else
                Transition.run(navbar, "Width", 0, new TransitionType_EaseInEaseOut(1000));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
