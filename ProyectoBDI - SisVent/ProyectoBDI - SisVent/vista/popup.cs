﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoBDI___SisVent
{
    public partial class popup : Form
    {
        public popup(string message, AlertType type)
        {
            InitializeComponent();
            //this.txtMessage.SelectionAlignment = HorizontalAlignment.Left;

            switch (type)
            {
                case AlertType.check:
                    this.BackColor = Color.SeaGreen;
                    icon.Image = lista.Images[0];
                    //txtMessage.BackColor = Color.SeaGreen;
                    txtMessage.Text = message;
                    break;

                case AlertType.error:
                    this.BackColor = Color.Crimson;
                    icon.Image = lista.Images[1];
                    //txtMessage.BackColor = Color.Crimson;
                    txtMessage.Text = message;
                    break;

                case AlertType.info:
                    this.BackColor = Color.RoyalBlue;
                    icon.Image = lista.Images[2];
                    //txtMessage.BackColor = Color.RoyalBlue;
                    txtMessage.Text = message;
                    break;

                case AlertType.warning:
                    this.BackColor = Color.FromArgb(255,128,0);
                    icon.Image = lista.Images[3];
                    //txtMessage.BackColor = Color.FromArgb(255, 128, 0);
                    txtMessage.Text = message;
                    break;
            }

            this.Show();
            this.Top = 0;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 40;
            show.Start();

        }

        public enum AlertType
        {
            check,error,info,warning
        }

        private void popup_Load(object sender, EventArgs e)
        {
            //this.Top = 60;
            //this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            //show.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            closed.Start();
        }

        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if(this.Top < 60)
            {
                this.Top += interval;
                interval += 1;
            }
            else
            {
                show.Stop();
                time.Start();
            }
        }

        private void closed_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0)
            {
                this.Opacity -= 0.01;
            }
            else
            {
                this.Close();
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            closed.Start();
        }

        private void icon_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
