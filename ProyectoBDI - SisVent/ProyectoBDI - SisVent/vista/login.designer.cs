namespace ProyectoBDI___SisVent
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.ingresar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.preloading = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.texto = new System.Windows.Forms.Timer(this.components);
            this.duracion = new System.Windows.Forms.Timer(this.components);
            this.contentUser = new System.Windows.Forms.Panel();
            this.username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contentPassword = new System.Windows.Forms.Panel();
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.viewpass = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.loading.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preloading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.contentUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contentPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewpass)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("exitButton.ImageActive")));
            this.exitButton.Location = new System.Drawing.Point(333, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exitButton.TabIndex = 9;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // ingresar
            // 
            this.ingresar.ActiveBorderThickness = 1;
            this.ingresar.ActiveCornerRadius = 30;
            this.ingresar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.ingresar.ActiveForecolor = System.Drawing.Color.White;
            this.ingresar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.ingresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingresar.BackgroundImage")));
            this.ingresar.ButtonText = "Ingresar";
            this.ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ingresar.IdleBorderThickness = 1;
            this.ingresar.IdleCornerRadius = 30;
            this.ingresar.IdleFillColor = System.Drawing.Color.Transparent;
            this.ingresar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.ingresar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.ingresar.Location = new System.Drawing.Point(45, 426);
            this.ingresar.Margin = new System.Windows.Forms.Padding(5);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(280, 45);
            this.ingresar.TabIndex = 6;
            this.ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(198)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.loading);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(370, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 503);
            this.panel1.TabIndex = 11;
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.White;
            this.loading.Controls.Add(this.panel2);
            this.loading.Controls.Add(this.preloading);
            this.loading.Dock = System.Windows.Forms.DockStyle.Top;
            this.loading.Location = new System.Drawing.Point(0, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(370, 12);
            this.loading.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 63);
            this.panel2.TabIndex = 11;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(34, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(126, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Iniciando...";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(36, 35);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(121, 17);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Por favor, espere.";
            // 
            // preloading
            // 
            this.preloading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preloading.Image = ((System.Drawing.Image)(resources.GetObject("preloading.Image")));
            this.preloading.Location = new System.Drawing.Point(110, -213);
            this.preloading.Name = "preloading";
            this.preloading.Size = new System.Drawing.Size(150, 150);
            this.preloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preloading.TabIndex = 10;
            this.preloading.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 117);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(370, 260);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // texto
            // 
            this.texto.Interval = 500;
            this.texto.Tick += new System.EventHandler(this.texto_Tick);
            // 
            // duracion
            // 
            this.duracion.Interval = 6000;
            this.duracion.Tick += new System.EventHandler(this.duracion_Tick);
            // 
            // contentUser
            // 
            this.contentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.contentUser.Controls.Add(this.username);
            this.contentUser.Controls.Add(this.pictureBox2);
            this.contentUser.Location = new System.Drawing.Point(45, 250);
            this.contentUser.Name = "contentUser";
            this.contentUser.Size = new System.Drawing.Size(280, 35);
            this.contentUser.TabIndex = 12;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            this.username.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            this.username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            this.username.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            this.username.BorderThickness = 1;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Dock = System.Windows.Forms.DockStyle.Right;
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.username.isPassword = false;
            this.username.Location = new System.Drawing.Point(35, 0);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(245, 35);
            this.username.TabIndex = 12;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(162)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // contentPassword
            // 
            this.contentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.contentPassword.Controls.Add(this.password);
            this.contentPassword.Controls.Add(this.pictureBox3);
            this.contentPassword.Controls.Add(this.viewpass);
            this.contentPassword.Location = new System.Drawing.Point(45, 330);
            this.contentPassword.Name = "contentPassword";
            this.contentPassword.Size = new System.Drawing.Size(280, 35);
            this.contentPassword.TabIndex = 13;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            this.password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            this.password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            this.password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            this.password.BorderThickness = 3;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.password.isPassword = false;
            this.password.Location = new System.Drawing.Point(35, 0);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(210, 35);
            this.password.TabIndex = 12;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.OnValueChanged += new System.EventHandler(this.password_OnValueChanged);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(162)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // viewpass
            // 
            this.viewpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            this.viewpass.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewpass.Image = ((System.Drawing.Image)(resources.GetObject("viewpass.Image")));
            this.viewpass.ImageActive = ((System.Drawing.Image)(resources.GetObject("viewpass.ImageActive")));
            this.viewpass.Location = new System.Drawing.Point(245, 0);
            this.viewpass.Name = "viewpass";
            this.viewpass.Size = new System.Drawing.Size(35, 35);
            this.viewpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.viewpass.TabIndex = 14;
            this.viewpass.TabStop = false;
            this.viewpass.Zoom = 5;
            this.viewpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewpass_MouseDown);
            this.viewpass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewpass_MouseUp);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(740, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.contentUser);
            this.Controls.Add(this.contentPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTalk_ThemeContainer1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.loading.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preloading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.contentUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contentPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewpass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuImageButton exitButton;
        public Bunifu.Framework.UI.BunifuThinButton2 ingresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox preloading;
        private System.Windows.Forms.Panel loading;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel label;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Timer texto;
        private System.Windows.Forms.Timer duracion;
        private System.Windows.Forms.Panel contentUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox username;
        private System.Windows.Forms.Panel contentPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuImageButton viewpass;
        private System.Windows.Forms.Timer timer1;
    }
}

