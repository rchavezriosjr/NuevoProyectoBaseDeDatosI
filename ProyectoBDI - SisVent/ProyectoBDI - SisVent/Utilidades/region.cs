using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.Utilidades
{
    class region
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Region Circle(int width, int height)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, width - 3, height - 3);

            return new Region(gp);
        }

        public Region RoundBorder(int width, int height, int border)
        {
            return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, width, height, border, border));
        }
    }
}
