namespace ProyectoBDI___SisVent.vista
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.navbar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idUsuario = new System.Windows.Forms.Label();
            this.nameUser = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.timerTab = new System.Windows.Forms.Timer(this.components);
            this.contenedor = new System.Windows.Forms.Panel();
            this.minButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.inicioTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.proveedorTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adminCuentasTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clientesTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comprasTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VentasTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.productosTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.navbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.navbar.Controls.Add(this.inicioTab);
            this.navbar.Controls.Add(this.proveedorTab);
            this.navbar.Controls.Add(this.adminCuentasTab);
            this.navbar.Controls.Add(this.clientesTab);
            this.navbar.Controls.Add(this.comprasTab);
            this.navbar.Controls.Add(this.panel1);
            this.navbar.Controls.Add(this.panel4);
            this.navbar.Controls.Add(this.VentasTab);
            this.navbar.Controls.Add(this.productosTab);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(221, 720);
            this.navbar.TabIndex = 0;
            this.navbar.Paint += new System.Windows.Forms.PaintEventHandler(this.navbar_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idUsuario);
            this.panel1.Controls.Add(this.nameUser);
            this.panel1.Controls.Add(this.userPicture);
            this.panel1.Location = new System.Drawing.Point(3, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 148);
            this.panel1.TabIndex = 2;
            // 
            // idUsuario
            // 
            this.idUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.idUsuario.Location = new System.Drawing.Point(-3, 120);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(240, 25);
            this.idUsuario.TabIndex = 4;
            this.idUsuario.Text = "ID Usuario";
            this.idUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameUser
            // 
            this.nameUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameUser.Location = new System.Drawing.Point(-3, 95);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(240, 25);
            this.nameUser.TabIndex = 3;
            this.nameUser.Text = "Nombre Usuario";
            this.nameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(66)))), ((int)(((byte)(159)))));
            this.panel4.Controls.Add(this.bunifuCustomLabel4);
            this.panel4.Controls.Add(this.bunifuCustomLabel3);
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 50);
            this.panel4.TabIndex = 2;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(76, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(90, 33);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "SisVent";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(75, 4);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(90, 33);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "SisVent";
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.toppanel.Controls.Add(this.minButton);
            this.toppanel.Controls.Add(this.closeButton);
            this.toppanel.Controls.Add(this.menu);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(221, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(729, 50);
            this.toppanel.TabIndex = 1;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            this.toppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseUp);
            // 
            // timerTab
            // 
            this.timerTab.Interval = 500;
            this.timerTab.Tick += new System.EventHandler(this.timerTab_Tick);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(221, 50);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(729, 670);
            this.contenedor.TabIndex = 2;
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.minButton.Image = ((System.Drawing.Image)(resources.GetObject("minButton.Image")));
            this.minButton.ImageActive = null;
            this.minButton.Location = new System.Drawing.Point(658, 12);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(25, 25);
            this.minButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minButton.TabIndex = 4;
            this.minButton.TabStop = false;
            this.minButton.Zoom = 15;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(693, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 15;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageActive = null;
            this.menu.Location = new System.Drawing.Point(2, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(50, 50);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menu.TabIndex = 2;
            this.menu.TabStop = false;
            this.menu.Zoom = 25;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // inicioTab
            // 
            this.inicioTab.Activecolor = System.Drawing.Color.SeaGreen;
            this.inicioTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.inicioTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inicioTab.BorderRadius = 0;
            this.inicioTab.ButtonText = " Inicio";
            this.inicioTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inicioTab.DisabledColor = System.Drawing.Color.Gray;
            this.inicioTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioTab.Iconcolor = System.Drawing.Color.Transparent;
            this.inicioTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("inicioTab.Iconimage")));
            this.inicioTab.Iconimage_right = null;
            this.inicioTab.Iconimage_right_Selected = null;
            this.inicioTab.Iconimage_Selected = null;
            this.inicioTab.IconMarginLeft = 0;
            this.inicioTab.IconMarginRight = 0;
            this.inicioTab.IconRightVisible = true;
            this.inicioTab.IconRightZoom = 0D;
            this.inicioTab.IconVisible = true;
            this.inicioTab.IconZoom = 65D;
            this.inicioTab.IsTab = false;
            this.inicioTab.Location = new System.Drawing.Point(3, 214);
            this.inicioTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inicioTab.Name = "inicioTab";
            this.inicioTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.inicioTab.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.inicioTab.OnHoverTextColor = System.Drawing.Color.White;
            this.inicioTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inicioTab.selected = true;
            this.inicioTab.Size = new System.Drawing.Size(240, 50);
            this.inicioTab.TabIndex = 8;
            this.inicioTab.Text = " Inicio";
            this.inicioTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inicioTab.Textcolor = System.Drawing.Color.White;
            this.inicioTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioTab.Click += new System.EventHandler(this.inicioTab_Click);
            // 
            // proveedorTab
            // 
            this.proveedorTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(96)))), ((int)(((byte)(179)))));
            this.proveedorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.proveedorTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proveedorTab.BorderRadius = 0;
            this.proveedorTab.ButtonText = "  Proveedores";
            this.proveedorTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proveedorTab.DisabledColor = System.Drawing.Color.Gray;
            this.proveedorTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedorTab.Iconcolor = System.Drawing.Color.Transparent;
            this.proveedorTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("proveedorTab.Iconimage")));
            this.proveedorTab.Iconimage_right = null;
            this.proveedorTab.Iconimage_right_Selected = null;
            this.proveedorTab.Iconimage_Selected = null;
            this.proveedorTab.IconMarginLeft = 0;
            this.proveedorTab.IconMarginRight = 0;
            this.proveedorTab.IconRightVisible = true;
            this.proveedorTab.IconRightZoom = 0D;
            this.proveedorTab.IconVisible = true;
            this.proveedorTab.IconZoom = 65D;
            this.proveedorTab.IsTab = false;
            this.proveedorTab.Location = new System.Drawing.Point(3, 504);
            this.proveedorTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.proveedorTab.Name = "proveedorTab";
            this.proveedorTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.proveedorTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(96)))), ((int)(((byte)(179)))));
            this.proveedorTab.OnHoverTextColor = System.Drawing.Color.White;
            this.proveedorTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.proveedorTab.selected = true;
            this.proveedorTab.Size = new System.Drawing.Size(240, 50);
            this.proveedorTab.TabIndex = 7;
            this.proveedorTab.Text = "  Proveedores";
            this.proveedorTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedorTab.Textcolor = System.Drawing.Color.White;
            this.proveedorTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedorTab.Click += new System.EventHandler(this.proveedorTab_Click);
            // 
            // adminCuentasTab
            // 
            this.adminCuentasTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.adminCuentasTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.adminCuentasTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminCuentasTab.BorderRadius = 0;
            this.adminCuentasTab.ButtonText = "  Administración";
            this.adminCuentasTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminCuentasTab.DisabledColor = System.Drawing.Color.Gray;
            this.adminCuentasTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCuentasTab.Iconcolor = System.Drawing.Color.Transparent;
            this.adminCuentasTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("adminCuentasTab.Iconimage")));
            this.adminCuentasTab.Iconimage_right = null;
            this.adminCuentasTab.Iconimage_right_Selected = null;
            this.adminCuentasTab.Iconimage_Selected = null;
            this.adminCuentasTab.IconMarginLeft = 0;
            this.adminCuentasTab.IconMarginRight = 0;
            this.adminCuentasTab.IconRightVisible = true;
            this.adminCuentasTab.IconRightZoom = 0D;
            this.adminCuentasTab.IconVisible = true;
            this.adminCuentasTab.IconZoom = 65D;
            this.adminCuentasTab.IsTab = false;
            this.adminCuentasTab.Location = new System.Drawing.Point(3, 562);
            this.adminCuentasTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminCuentasTab.Name = "adminCuentasTab";
            this.adminCuentasTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.adminCuentasTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.adminCuentasTab.OnHoverTextColor = System.Drawing.Color.White;
            this.adminCuentasTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminCuentasTab.selected = true;
            this.adminCuentasTab.Size = new System.Drawing.Size(240, 50);
            this.adminCuentasTab.TabIndex = 6;
            this.adminCuentasTab.Text = "  Administración";
            this.adminCuentasTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminCuentasTab.Textcolor = System.Drawing.Color.White;
            this.adminCuentasTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCuentasTab.Click += new System.EventHandler(this.adminCuentasTab_Click);
            // 
            // clientesTab
            // 
            this.clientesTab.Activecolor = System.Drawing.Color.MediumSpringGreen;
            this.clientesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.clientesTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientesTab.BorderRadius = 0;
            this.clientesTab.ButtonText = " Clientes";
            this.clientesTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientesTab.DisabledColor = System.Drawing.Color.Gray;
            this.clientesTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesTab.Iconcolor = System.Drawing.Color.Transparent;
            this.clientesTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("clientesTab.Iconimage")));
            this.clientesTab.Iconimage_right = null;
            this.clientesTab.Iconimage_right_Selected = null;
            this.clientesTab.Iconimage_Selected = null;
            this.clientesTab.IconMarginLeft = 0;
            this.clientesTab.IconMarginRight = 0;
            this.clientesTab.IconRightVisible = true;
            this.clientesTab.IconRightZoom = 0D;
            this.clientesTab.IconVisible = true;
            this.clientesTab.IconZoom = 65D;
            this.clientesTab.IsTab = false;
            this.clientesTab.Location = new System.Drawing.Point(3, 272);
            this.clientesTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientesTab.Name = "clientesTab";
            this.clientesTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.clientesTab.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.clientesTab.OnHoverTextColor = System.Drawing.Color.White;
            this.clientesTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientesTab.selected = true;
            this.clientesTab.Size = new System.Drawing.Size(240, 50);
            this.clientesTab.TabIndex = 4;
            this.clientesTab.Text = " Clientes";
            this.clientesTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesTab.Textcolor = System.Drawing.Color.White;
            this.clientesTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesTab.Click += new System.EventHandler(this.clientesTab_Click);
            // 
            // comprasTab
            // 
            this.comprasTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.comprasTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.comprasTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comprasTab.BorderRadius = 0;
            this.comprasTab.ButtonText = "  Compras";
            this.comprasTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comprasTab.DisabledColor = System.Drawing.Color.Gray;
            this.comprasTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasTab.Iconcolor = System.Drawing.Color.Transparent;
            this.comprasTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("comprasTab.Iconimage")));
            this.comprasTab.Iconimage_right = null;
            this.comprasTab.Iconimage_right_Selected = null;
            this.comprasTab.Iconimage_Selected = null;
            this.comprasTab.IconMarginLeft = 0;
            this.comprasTab.IconMarginRight = 0;
            this.comprasTab.IconRightVisible = true;
            this.comprasTab.IconRightZoom = 0D;
            this.comprasTab.IconVisible = true;
            this.comprasTab.IconZoom = 65D;
            this.comprasTab.IsTab = false;
            this.comprasTab.Location = new System.Drawing.Point(3, 388);
            this.comprasTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comprasTab.Name = "comprasTab";
            this.comprasTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.comprasTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.comprasTab.OnHoverTextColor = System.Drawing.Color.White;
            this.comprasTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comprasTab.selected = true;
            this.comprasTab.Size = new System.Drawing.Size(240, 50);
            this.comprasTab.TabIndex = 3;
            this.comprasTab.Text = "  Compras";
            this.comprasTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comprasTab.Textcolor = System.Drawing.Color.White;
            this.comprasTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasTab.Click += new System.EventHandler(this.comprasTab_Click);
            // 
            // userPicture
            // 
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
            this.userPicture.Location = new System.Drawing.Point(81, 3);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(70, 70);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userPicture.TabIndex = 2;
            this.userPicture.TabStop = false;
            this.userPicture.Click += new System.EventHandler(this.userPicture_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuCustomLabel4.Image")));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 33);
            this.bunifuCustomLabel4.TabIndex = 1;
            // 
            // VentasTab
            // 
            this.VentasTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.VentasTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.VentasTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VentasTab.BorderRadius = 0;
            this.VentasTab.ButtonText = " Ventas";
            this.VentasTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VentasTab.DisabledColor = System.Drawing.Color.Gray;
            this.VentasTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasTab.Iconcolor = System.Drawing.Color.Transparent;
            this.VentasTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("VentasTab.Iconimage")));
            this.VentasTab.Iconimage_right = null;
            this.VentasTab.Iconimage_right_Selected = null;
            this.VentasTab.Iconimage_Selected = null;
            this.VentasTab.IconMarginLeft = 0;
            this.VentasTab.IconMarginRight = 0;
            this.VentasTab.IconRightVisible = true;
            this.VentasTab.IconRightZoom = 0D;
            this.VentasTab.IconVisible = true;
            this.VentasTab.IconZoom = 65D;
            this.VentasTab.IsTab = false;
            this.VentasTab.Location = new System.Drawing.Point(3, 330);
            this.VentasTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VentasTab.Name = "VentasTab";
            this.VentasTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.VentasTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.VentasTab.OnHoverTextColor = System.Drawing.Color.White;
            this.VentasTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VentasTab.selected = true;
            this.VentasTab.Size = new System.Drawing.Size(240, 50);
            this.VentasTab.TabIndex = 2;
            this.VentasTab.Text = " Ventas";
            this.VentasTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentasTab.Textcolor = System.Drawing.Color.White;
            this.VentasTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasTab.Click += new System.EventHandler(this.VentasTab_Click);
            // 
            // productosTab
            // 
            this.productosTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.productosTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.productosTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productosTab.BorderRadius = 0;
            this.productosTab.ButtonText = "  Productos";
            this.productosTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productosTab.DisabledColor = System.Drawing.Color.Gray;
            this.productosTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosTab.Iconcolor = System.Drawing.Color.Transparent;
            this.productosTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("productosTab.Iconimage")));
            this.productosTab.Iconimage_right = null;
            this.productosTab.Iconimage_right_Selected = null;
            this.productosTab.Iconimage_Selected = null;
            this.productosTab.IconMarginLeft = 0;
            this.productosTab.IconMarginRight = 0;
            this.productosTab.IconRightVisible = true;
            this.productosTab.IconRightZoom = 0D;
            this.productosTab.IconVisible = true;
            this.productosTab.IconZoom = 65D;
            this.productosTab.IsTab = false;
            this.productosTab.Location = new System.Drawing.Point(3, 446);
            this.productosTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productosTab.Name = "productosTab";
            this.productosTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.productosTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(100)))), ((int)(((byte)(239)))));
            this.productosTab.OnHoverTextColor = System.Drawing.Color.White;
            this.productosTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productosTab.selected = true;
            this.productosTab.Size = new System.Drawing.Size(240, 50);
            this.productosTab.TabIndex = 2;
            this.productosTab.Text = "  Productos";
            this.productosTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productosTab.Textcolor = System.Drawing.Color.White;
            this.productosTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosTab.Click += new System.EventHandler(this.productosTab_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 720);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.navbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private Bunifu.Framework.UI.BunifuFlatButton VentasTab;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton productosTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameUser;
        private System.Windows.Forms.PictureBox userPicture;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton comprasTab;
        private Bunifu.Framework.UI.BunifuFlatButton clientesTab;
        private Bunifu.Framework.UI.BunifuFlatButton adminCuentasTab;
        private System.Windows.Forms.Label idUsuario;
        private Bunifu.Framework.UI.BunifuImageButton minButton;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuImageButton menu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton proveedorTab;
        private Bunifu.Framework.UI.BunifuFlatButton inicioTab;
        private System.Windows.Forms.Timer timerTab;
        private System.Windows.Forms.Panel contenedor;
    }
}