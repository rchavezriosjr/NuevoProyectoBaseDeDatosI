namespace ProyectoBDI___SisVent.vista
{
    partial class clientes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.panelNC = new System.Windows.Forms.Panel();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.panelLC = new System.Windows.Forms.Panel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.productosMasVendidos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.listarButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.agregarButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buscarButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkID = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkNombre = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkCorreo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkTelefono = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkDireccion = new Bunifu.Framework.UI.BunifuCheckbox();
            this.listar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.listadoClientes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.metodoBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.resultadoBusqueda = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.contenedor.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.panelLC.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "/Clientes";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.contenedor.Controls.Add(this.panelLC);
            this.contenedor.Controls.Add(this.panelBuscar);
            this.contenedor.Controls.Add(this.panelNC);
            this.contenedor.Location = new System.Drawing.Point(22, 105);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(612, 547);
            this.contenedor.TabIndex = 4;
            // 
            // panelNC
            // 
            this.panelNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.panelNC.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNC.Location = new System.Drawing.Point(0, 0);
            this.panelNC.Name = "panelNC";
            this.panelNC.Size = new System.Drawing.Size(10, 547);
            this.panelNC.TabIndex = 0;
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(146)))), ((int)(((byte)(195)))));
            this.panelBuscar.Controls.Add(this.resultadoBusqueda);
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.metodoBusqueda);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBuscar.Location = new System.Drawing.Point(602, 0);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(10, 547);
            this.panelBuscar.TabIndex = 1;
            // 
            // panelLC
            // 
            this.panelLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(205)))), ((int)(((byte)(156)))));
            this.panelLC.Controls.Add(this.label7);
            this.panelLC.Controls.Add(this.listadoClientes);
            this.panelLC.Controls.Add(this.listar);
            this.panelLC.Controls.Add(this.label6);
            this.panelLC.Controls.Add(this.checkDireccion);
            this.panelLC.Controls.Add(this.label5);
            this.panelLC.Controls.Add(this.checkTelefono);
            this.panelLC.Controls.Add(this.label4);
            this.panelLC.Controls.Add(this.checkCorreo);
            this.panelLC.Controls.Add(this.label3);
            this.panelLC.Controls.Add(this.checkNombre);
            this.panelLC.Controls.Add(this.label2);
            this.panelLC.Controls.Add(this.checkID);
            this.panelLC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLC.Location = new System.Drawing.Point(10, 0);
            this.panelLC.Name = "panelLC";
            this.panelLC.Size = new System.Drawing.Size(592, 12);
            this.panelLC.TabIndex = 2;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 10;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Goldenrod;
            this.bunifuCards1.Controls.Add(this.productosMasVendidos);
            this.bunifuCards1.Controls.Add(this.label11);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(649, 58);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 50;
            this.bunifuCards1.Size = new System.Drawing.Size(286, 394);
            this.bunifuCards1.TabIndex = 7;
            // 
            // productosMasVendidos
            // 
            this.productosMasVendidos.BackgroundColor = System.Drawing.Color.White;
            this.productosMasVendidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productosMasVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosMasVendidos.GridColor = System.Drawing.Color.RoyalBlue;
            this.productosMasVendidos.Location = new System.Drawing.Point(0, 28);
            this.productosMasVendidos.Name = "productosMasVendidos";
            this.productosMasVendidos.Size = new System.Drawing.Size(284, 318);
            this.productosMasVendidos.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(0, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(274, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "       Añadidos recientemente";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listarButton
            // 
            this.listarButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.listarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.listarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listarButton.BorderRadius = 0;
            this.listarButton.ButtonText = "   Listar clientes";
            this.listarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listarButton.DisabledColor = System.Drawing.Color.Gray;
            this.listarButton.Iconcolor = System.Drawing.Color.Transparent;
            this.listarButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("listarButton.Iconimage")));
            this.listarButton.Iconimage_right = null;
            this.listarButton.Iconimage_right_Selected = null;
            this.listarButton.Iconimage_Selected = null;
            this.listarButton.IconMarginLeft = 0;
            this.listarButton.IconMarginRight = 0;
            this.listarButton.IconRightVisible = true;
            this.listarButton.IconRightZoom = 0D;
            this.listarButton.IconVisible = true;
            this.listarButton.IconZoom = 70D;
            this.listarButton.IsTab = false;
            this.listarButton.Location = new System.Drawing.Point(228, 56);
            this.listarButton.Name = "listarButton";
            this.listarButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.listarButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(205)))), ((int)(((byte)(156)))));
            this.listarButton.OnHoverTextColor = System.Drawing.Color.White;
            this.listarButton.selected = false;
            this.listarButton.Size = new System.Drawing.Size(200, 50);
            this.listarButton.TabIndex = 3;
            this.listarButton.Text = "   Listar clientes";
            this.listarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listarButton.Textcolor = System.Drawing.Color.White;
            this.listarButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.agregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.agregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarButton.BorderRadius = 0;
            this.agregarButton.ButtonText = "   Nuevo cliente";
            this.agregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarButton.DisabledColor = System.Drawing.Color.Gray;
            this.agregarButton.Iconcolor = System.Drawing.Color.Transparent;
            this.agregarButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("agregarButton.Iconimage")));
            this.agregarButton.Iconimage_right = null;
            this.agregarButton.Iconimage_right_Selected = null;
            this.agregarButton.Iconimage_Selected = null;
            this.agregarButton.IconMarginLeft = 0;
            this.agregarButton.IconMarginRight = 0;
            this.agregarButton.IconRightVisible = true;
            this.agregarButton.IconRightZoom = 0D;
            this.agregarButton.IconVisible = true;
            this.agregarButton.IconZoom = 70D;
            this.agregarButton.IsTab = false;
            this.agregarButton.Location = new System.Drawing.Point(22, 56);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.agregarButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.agregarButton.OnHoverTextColor = System.Drawing.Color.White;
            this.agregarButton.selected = false;
            this.agregarButton.Size = new System.Drawing.Size(200, 50);
            this.agregarButton.TabIndex = 2;
            this.agregarButton.Text = "   Nuevo cliente";
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarButton.Textcolor = System.Drawing.Color.White;
            this.agregarButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.buscarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarButton.BorderRadius = 0;
            this.buscarButton.ButtonText = "   Buscar";
            this.buscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarButton.DisabledColor = System.Drawing.Color.Gray;
            this.buscarButton.Iconcolor = System.Drawing.Color.Transparent;
            this.buscarButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("buscarButton.Iconimage")));
            this.buscarButton.Iconimage_right = null;
            this.buscarButton.Iconimage_right_Selected = null;
            this.buscarButton.Iconimage_Selected = null;
            this.buscarButton.IconMarginLeft = 0;
            this.buscarButton.IconMarginRight = 0;
            this.buscarButton.IconRightVisible = true;
            this.buscarButton.IconRightZoom = 0D;
            this.buscarButton.IconVisible = true;
            this.buscarButton.IconZoom = 60D;
            this.buscarButton.IsTab = false;
            this.buscarButton.Location = new System.Drawing.Point(434, 56);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.buscarButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(146)))), ((int)(((byte)(195)))));
            this.buscarButton.OnHoverTextColor = System.Drawing.Color.White;
            this.buscarButton.selected = false;
            this.buscarButton.Size = new System.Drawing.Size(200, 50);
            this.buscarButton.TabIndex = 1;
            this.buscarButton.Text = "   Buscar";
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Textcolor = System.Drawing.Color.White;
            this.buscarButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // checkID
            // 
            this.checkID.BackColor = System.Drawing.Color.SeaGreen;
            this.checkID.ChechedOffColor = System.Drawing.Color.White;
            this.checkID.Checked = true;
            this.checkID.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.checkID.ForeColor = System.Drawing.Color.White;
            this.checkID.Location = new System.Drawing.Point(37, 23);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(20, 20);
            this.checkID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // checkNombre
            // 
            this.checkNombre.BackColor = System.Drawing.Color.SeaGreen;
            this.checkNombre.ChechedOffColor = System.Drawing.Color.White;
            this.checkNombre.Checked = true;
            this.checkNombre.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.checkNombre.ForeColor = System.Drawing.Color.White;
            this.checkNombre.Location = new System.Drawing.Point(101, 22);
            this.checkNombre.Name = "checkNombre";
            this.checkNombre.Size = new System.Drawing.Size(20, 20);
            this.checkNombre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(230, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo";
            // 
            // checkCorreo
            // 
            this.checkCorreo.BackColor = System.Drawing.Color.SeaGreen;
            this.checkCorreo.ChechedOffColor = System.Drawing.Color.White;
            this.checkCorreo.Checked = true;
            this.checkCorreo.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.checkCorreo.ForeColor = System.Drawing.Color.White;
            this.checkCorreo.Location = new System.Drawing.Point(204, 22);
            this.checkCorreo.Name = "checkCorreo";
            this.checkCorreo.Size = new System.Drawing.Size(20, 20);
            this.checkCorreo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(326, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Teléfono";
            // 
            // checkTelefono
            // 
            this.checkTelefono.BackColor = System.Drawing.Color.SeaGreen;
            this.checkTelefono.ChechedOffColor = System.Drawing.Color.White;
            this.checkTelefono.Checked = true;
            this.checkTelefono.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.checkTelefono.ForeColor = System.Drawing.Color.White;
            this.checkTelefono.Location = new System.Drawing.Point(300, 22);
            this.checkTelefono.Name = "checkTelefono";
            this.checkTelefono.Size = new System.Drawing.Size(20, 20);
            this.checkTelefono.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(434, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dirección";
            // 
            // checkDireccion
            // 
            this.checkDireccion.BackColor = System.Drawing.Color.SeaGreen;
            this.checkDireccion.ChechedOffColor = System.Drawing.Color.White;
            this.checkDireccion.Checked = true;
            this.checkDireccion.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.checkDireccion.ForeColor = System.Drawing.Color.White;
            this.checkDireccion.Location = new System.Drawing.Point(408, 23);
            this.checkDireccion.Name = "checkDireccion";
            this.checkDireccion.Size = new System.Drawing.Size(20, 20);
            this.checkDireccion.TabIndex = 8;
            // 
            // listar
            // 
            this.listar.ActiveBorderThickness = 1;
            this.listar.ActiveCornerRadius = 20;
            this.listar.ActiveFillColor = System.Drawing.Color.White;
            this.listar.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.listar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.listar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(205)))), ((int)(((byte)(156)))));
            this.listar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listar.BackgroundImage")));
            this.listar.ButtonText = "Listar";
            this.listar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listar.ForeColor = System.Drawing.Color.SeaGreen;
            this.listar.IdleBorderThickness = 2;
            this.listar.IdleCornerRadius = 20;
            this.listar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.listar.IdleForecolor = System.Drawing.Color.White;
            this.listar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.listar.Location = new System.Drawing.Point(37, 61);
            this.listar.Margin = new System.Windows.Forms.Padding(5);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(150, 35);
            this.listar.TabIndex = 10;
            this.listar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listadoClientes
            // 
            this.listadoClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(205)))), ((int)(((byte)(156)))));
            this.listadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoClientes.GridColor = System.Drawing.Color.SeaGreen;
            this.listadoClientes.Location = new System.Drawing.Point(37, 138);
            this.listadoClientes.Name = "listadoClientes";
            this.listadoClientes.Size = new System.Drawing.Size(510, 388);
            this.listadoClientes.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lista clientes";
            // 
            // metodoBusqueda
            // 
            this.metodoBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(182)))), ((int)(((byte)(215)))));
            this.metodoBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metodoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodoBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.metodoBusqueda.FormattingEnabled = true;
            this.metodoBusqueda.ItemHeight = 18;
            this.metodoBusqueda.Items.AddRange(new object[] {
            "Nombre o ID",
            "Correo",
            "Teléfono",
            "Dirección"});
            this.metodoBusqueda.Location = new System.Drawing.Point(29, 61);
            this.metodoBusqueda.Name = "metodoBusqueda";
            this.metodoBusqueda.Size = new System.Drawing.Size(121, 26);
            this.metodoBusqueda.TabIndex = 0;
            this.metodoBusqueda.Text = "Buscar por...";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(182)))), ((int)(((byte)(215)))));
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(29, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 30);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.text = "";
            // 
            // resultadoBusqueda
            // 
            this.resultadoBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(146)))), ((int)(((byte)(195)))));
            this.resultadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadoBusqueda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.resultadoBusqueda.Location = new System.Drawing.Point(29, 136);
            this.resultadoBusqueda.Name = "resultadoBusqueda";
            this.resultadoBusqueda.Size = new System.Drawing.Size(537, 390);
            this.resultadoBusqueda.TabIndex = 2;
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buscarButton);
            this.Name = "clientes";
            this.Size = new System.Drawing.Size(950, 670);
            this.Load += new System.EventHandler(this.clientes_Load);
            this.panel1.ResumeLayout(false);
            this.contenedor.ResumeLayout(false);
            this.panelBuscar.ResumeLayout(false);
            this.panelLC.ResumeLayout(false);
            this.panelLC.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosMasVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton buscarButton;
        private Bunifu.Framework.UI.BunifuFlatButton agregarButton;
        private Bunifu.Framework.UI.BunifuFlatButton listarButton;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel panelLC;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Panel panelNC;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.DataGridView productosMasVendidos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView listadoClientes;
        private Bunifu.Framework.UI.BunifuThinButton2 listar;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCheckbox checkDireccion;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox checkTelefono;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox checkCorreo;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox checkNombre;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox checkID;
        private System.Windows.Forms.DataGridView resultadoBusqueda;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private System.Windows.Forms.ComboBox metodoBusqueda;
    }
}
