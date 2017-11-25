namespace ProyectoBDI___SisVent.vista
{
    partial class ventaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelDatosVenta = new System.Windows.Forms.Panel();
            this.vistaClientes = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fechaVenta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tipoPago = new iTalk.iTalk_ComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCodigoCompra = new iTalk.iTalk_TextBox_Small();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCliente = new iTalk.iTalk_TextBox_Small();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDatosDetalleVenta = new System.Windows.Forms.Panel();
            this.cantidadVentaProducto = new iTalk.iTalk_TextBox_Small();
            this.vistaProducto = new System.Windows.Forms.DataGridView();
            this.agregarProductoDetalle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.descuentoProducto = new iTalk.iTalk_TextBox_Small();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtProducto = new iTalk.iTalk_TextBox_Small();
            this.detalleVenta = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cancelarButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.guardarButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ventaCredito = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtStock = new iTalk.iTalk_TextBox_Small();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPrecioVenta = new iTalk.iTalk_TextBox_Small();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.impuestoValue = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDescuentoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuestoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelDatosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaClientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDatosDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVenta)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 40);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(182, 22);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Información venta";
            // 
            // panelDatosVenta
            // 
            this.panelDatosVenta.BackColor = System.Drawing.Color.White;
            this.panelDatosVenta.Controls.Add(this.bunifuCustomLabel7);
            this.panelDatosVenta.Controls.Add(this.ventaCredito);
            this.panelDatosVenta.Controls.Add(this.vistaClientes);
            this.panelDatosVenta.Controls.Add(this.bunifuCustomLabel6);
            this.panelDatosVenta.Controls.Add(this.fechaVenta);
            this.panelDatosVenta.Controls.Add(this.bunifuCustomLabel5);
            this.panelDatosVenta.Controls.Add(this.tipoPago);
            this.panelDatosVenta.Controls.Add(this.bunifuCustomLabel4);
            this.panelDatosVenta.Controls.Add(this.txtCodigoCompra);
            this.panelDatosVenta.Controls.Add(this.bunifuCustomLabel3);
            this.panelDatosVenta.Controls.Add(this.panel2);
            this.panelDatosVenta.Controls.Add(this.txtCliente);
            this.panelDatosVenta.Location = new System.Drawing.Point(20, 81);
            this.panelDatosVenta.Name = "panelDatosVenta";
            this.panelDatosVenta.Size = new System.Drawing.Size(640, 160);
            this.panelDatosVenta.TabIndex = 1;
            // 
            // vistaClientes
            // 
            this.vistaClientes.BackgroundColor = System.Drawing.Color.White;
            this.vistaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vistaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.vistaClientes.Location = new System.Drawing.Point(100, 166);
            this.vistaClientes.Name = "vistaClientes";
            this.vistaClientes.Size = new System.Drawing.Size(485, 150);
            this.vistaClientes.TabIndex = 10;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(207, 105);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(67, 13);
            this.bunifuCustomLabel6.TabIndex = 9;
            this.bunifuCustomLabel6.Text = "Fecha venta";
            // 
            // fechaVenta
            // 
            this.fechaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.fechaVenta.BorderRadius = 7;
            this.fechaVenta.ForeColor = System.Drawing.Color.White;
            this.fechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVenta.FormatCustom = null;
            this.fechaVenta.Location = new System.Drawing.Point(200, 121);
            this.fechaVenta.Name = "fechaVenta";
            this.fechaVenta.Size = new System.Drawing.Size(178, 26);
            this.fechaVenta.TabIndex = 8;
            this.fechaVenta.Value = new System.DateTime(2017, 11, 24, 15, 30, 34, 680);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(23, 105);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(70, 13);
            this.bunifuCustomLabel5.TabIndex = 7;
            this.bunifuCustomLabel5.Text = "Tipo de pago";
            // 
            // tipoPago
            // 
            this.tipoPago.BackColor = System.Drawing.Color.White;
            this.tipoPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tipoPago.DropDownHeight = 100;
            this.tipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(149)))), ((int)(((byte)(69)))));
            this.tipoPago.FormattingEnabled = true;
            this.tipoPago.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(149)))), ((int)(((byte)(69)))));
            this.tipoPago.IntegralHeight = false;
            this.tipoPago.ItemHeight = 20;
            this.tipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Cheque"});
            this.tipoPago.Location = new System.Drawing.Point(18, 121);
            this.tipoPago.Name = "tipoPago";
            this.tipoPago.Size = new System.Drawing.Size(135, 26);
            this.tipoPago.StartIndex = 0;
            this.tipoPago.TabIndex = 6;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(311, 45);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(65, 13);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "Cod. factura";
            // 
            // txtCodigoCompra
            // 
            this.txtCodigoCompra.BackColor = System.Drawing.Color.White;
            this.txtCodigoCompra.Enabled = false;
            this.txtCodigoCompra.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCodigoCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(149)))), ((int)(((byte)(69)))));
            this.txtCodigoCompra.Location = new System.Drawing.Point(306, 61);
            this.txtCodigoCompra.MaxLength = 32767;
            this.txtCodigoCompra.Multiline = false;
            this.txtCodigoCompra.Name = "txtCodigoCompra";
            this.txtCodigoCompra.ReadOnly = false;
            this.txtCodigoCompra.Size = new System.Drawing.Size(123, 28);
            this.txtCodigoCompra.TabIndex = 4;
            this.txtCodigoCompra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoCompra.UseSystemPasswordChar = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(23, 45);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(39, 13);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 25);
            this.panel2.TabIndex = 2;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(23, 4);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 17);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "> Datos venta";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(149)))), ((int)(((byte)(69)))));
            this.txtCliente.Location = new System.Drawing.Point(18, 61);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = false;
            this.txtCliente.Size = new System.Drawing.Size(235, 28);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCliente.UseSystemPasswordChar = false;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            this.txtCliente.Leave += new System.EventHandler(this.txtProveedor_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panelDatosDetalleVenta);
            this.panel3.Controls.Add(this.detalleVenta);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(20, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 360);
            this.panel3.TabIndex = 2;
            // 
            // panelDatosDetalleVenta
            // 
            this.panelDatosDetalleVenta.Controls.Add(this.bunifuCustomLabel14);
            this.panelDatosDetalleVenta.Controls.Add(this.impuestoValue);
            this.panelDatosDetalleVenta.Controls.Add(this.bunifuCustomLabel12);
            this.panelDatosDetalleVenta.Controls.Add(this.txtPrecioVenta);
            this.panelDatosDetalleVenta.Controls.Add(this.bunifuCustomLabel11);
            this.panelDatosDetalleVenta.Controls.Add(this.txtStock);
            this.panelDatosDetalleVenta.Controls.Add(this.cantidadVentaProducto);
            this.panelDatosDetalleVenta.Controls.Add(this.vistaProducto);
            this.panelDatosDetalleVenta.Controls.Add(this.agregarProductoDetalle);
            this.panelDatosDetalleVenta.Controls.Add(this.bunifuCustomLabel10);
            this.panelDatosDetalleVenta.Controls.Add(this.descuentoProducto);
            this.panelDatosDetalleVenta.Controls.Add(this.bunifuCustomLabel9);
            this.panelDatosDetalleVenta.Controls.Add(this.bunifuCustomLabel8);
            this.panelDatosDetalleVenta.Controls.Add(this.txtProducto);
            this.panelDatosDetalleVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatosDetalleVenta.Location = new System.Drawing.Point(0, 25);
            this.panelDatosDetalleVenta.Name = "panelDatosDetalleVenta";
            this.panelDatosDetalleVenta.Size = new System.Drawing.Size(640, 100);
            this.panelDatosDetalleVenta.TabIndex = 11;
            // 
            // cantidadVentaProducto
            // 
            this.cantidadVentaProducto.BackColor = System.Drawing.Color.White;
            this.cantidadVentaProducto.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cantidadVentaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.cantidadVentaProducto.Location = new System.Drawing.Point(264, 29);
            this.cantidadVentaProducto.MaxLength = 32767;
            this.cantidadVentaProducto.Multiline = false;
            this.cantidadVentaProducto.Name = "cantidadVentaProducto";
            this.cantidadVentaProducto.ReadOnly = false;
            this.cantidadVentaProducto.Size = new System.Drawing.Size(75, 28);
            this.cantidadVentaProducto.TabIndex = 13;
            this.cantidadVentaProducto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cantidadVentaProducto.UseSystemPasswordChar = false;
            // 
            // vistaProducto
            // 
            this.vistaProducto.BackgroundColor = System.Drawing.Color.White;
            this.vistaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vistaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaProducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.vistaProducto.Location = new System.Drawing.Point(77, 106);
            this.vistaProducto.Name = "vistaProducto";
            this.vistaProducto.Size = new System.Drawing.Size(485, 150);
            this.vistaProducto.TabIndex = 12;
            // 
            // agregarProductoDetalle
            // 
            this.agregarProductoDetalle.ActiveBorderThickness = 1;
            this.agregarProductoDetalle.ActiveCornerRadius = 20;
            this.agregarProductoDetalle.ActiveFillColor = System.Drawing.Color.White;
            this.agregarProductoDetalle.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.agregarProductoDetalle.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.agregarProductoDetalle.BackColor = System.Drawing.Color.White;
            this.agregarProductoDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agregarProductoDetalle.BackgroundImage")));
            this.agregarProductoDetalle.ButtonText = "Agregar";
            this.agregarProductoDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarProductoDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarProductoDetalle.ForeColor = System.Drawing.Color.White;
            this.agregarProductoDetalle.IdleBorderThickness = 1;
            this.agregarProductoDetalle.IdleCornerRadius = 20;
            this.agregarProductoDetalle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.agregarProductoDetalle.IdleForecolor = System.Drawing.Color.White;
            this.agregarProductoDetalle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.agregarProductoDetalle.Location = new System.Drawing.Point(18, 63);
            this.agregarProductoDetalle.Margin = new System.Windows.Forms.Padding(5);
            this.agregarProductoDetalle.Name = "agregarProductoDetalle";
            this.agregarProductoDetalle.Size = new System.Drawing.Size(100, 35);
            this.agregarProductoDetalle.TabIndex = 11;
            this.agregarProductoDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(542, 13);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(59, 13);
            this.bunifuCustomLabel10.TabIndex = 10;
            this.bunifuCustomLabel10.Text = "Descuento";
            // 
            // descuentoProducto
            // 
            this.descuentoProducto.BackColor = System.Drawing.Color.White;
            this.descuentoProducto.Font = new System.Drawing.Font("Tahoma", 11F);
            this.descuentoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.descuentoProducto.Location = new System.Drawing.Point(537, 29);
            this.descuentoProducto.MaxLength = 32767;
            this.descuentoProducto.Multiline = false;
            this.descuentoProducto.Name = "descuentoProducto";
            this.descuentoProducto.ReadOnly = false;
            this.descuentoProducto.Size = new System.Drawing.Size(90, 28);
            this.descuentoProducto.TabIndex = 9;
            this.descuentoProducto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.descuentoProducto.UseSystemPasswordChar = false;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(264, 13);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(49, 13);
            this.bunifuCustomLabel9.TabIndex = 7;
            this.bunifuCustomLabel9.Text = "Cantidad";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(23, 13);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(50, 13);
            this.bunifuCustomLabel8.TabIndex = 5;
            this.bunifuCustomLabel8.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.txtProducto.Location = new System.Drawing.Point(18, 29);
            this.txtProducto.MaxLength = 32767;
            this.txtProducto.Multiline = false;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = false;
            this.txtProducto.Size = new System.Drawing.Size(235, 28);
            this.txtProducto.TabIndex = 4;
            this.txtProducto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProducto.UseSystemPasswordChar = false;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // detalleVenta
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.detalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.detalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.detalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.detalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.nombreProducto,
            this.cantidadProducto,
            this.precioProducto,
            this.valorDescuentoProducto,
            this.impuestoProducto,
            this.costoTotal});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detalleVenta.DefaultCellStyle = dataGridViewCellStyle21;
            this.detalleVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.detalleVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.detalleVenta.Location = new System.Drawing.Point(0, 131);
            this.detalleVenta.Name = "detalleVenta";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.detalleVenta.Size = new System.Drawing.Size(640, 229);
            this.detalleVenta.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.bunifuCustomLabel13);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(640, 25);
            this.panel4.TabIndex = 2;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(23, 4);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(108, 17);
            this.bunifuCustomLabel13.TabIndex = 1;
            this.bunifuCustomLabel13.Text = "> Detalle venta";
            // 
            // cancelarButton
            // 
            this.cancelarButton.ActiveBorderThickness = 1;
            this.cancelarButton.ActiveCornerRadius = 20;
            this.cancelarButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.cancelarButton.ActiveForecolor = System.Drawing.Color.White;
            this.cancelarButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.cancelarButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelarButton.BackgroundImage")));
            this.cancelarButton.ButtonText = "Cancelar";
            this.cancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelarButton.IdleBorderThickness = 1;
            this.cancelarButton.IdleCornerRadius = 20;
            this.cancelarButton.IdleFillColor = System.Drawing.Color.White;
            this.cancelarButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.cancelarButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.cancelarButton.Location = new System.Drawing.Point(433, 646);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(100, 40);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.ActiveBorderThickness = 1;
            this.guardarButton.ActiveCornerRadius = 20;
            this.guardarButton.ActiveFillColor = System.Drawing.Color.White;
            this.guardarButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.guardarButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.guardarButton.BackColor = System.Drawing.SystemColors.Control;
            this.guardarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarButton.BackgroundImage")));
            this.guardarButton.ButtonText = "Guardar";
            this.guardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.guardarButton.IdleBorderThickness = 1;
            this.guardarButton.IdleCornerRadius = 20;
            this.guardarButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.guardarButton.IdleForecolor = System.Drawing.Color.White;
            this.guardarButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.guardarButton.Location = new System.Drawing.Point(553, 646);
            this.guardarButton.Margin = new System.Windows.Forms.Padding(5);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(100, 40);
            this.guardarButton.TabIndex = 3;
            this.guardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ventaCredito
            // 
            this.ventaCredito.BackColor = System.Drawing.Color.Silver;
            this.ventaCredito.ChechedOffColor = System.Drawing.Color.Silver;
            this.ventaCredito.Checked = false;
            this.ventaCredito.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.ventaCredito.ForeColor = System.Drawing.Color.White;
            this.ventaCredito.Location = new System.Drawing.Point(426, 121);
            this.ventaCredito.Name = "ventaCredito";
            this.ventaCredito.Size = new System.Drawing.Size(20, 20);
            this.ventaCredito.TabIndex = 11;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(455, 124);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel7.TabIndex = 12;
            this.bunifuCustomLabel7.Text = "Crédito";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(355, 13);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(35, 13);
            this.bunifuCustomLabel11.TabIndex = 15;
            this.bunifuCustomLabel11.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.txtStock.Location = new System.Drawing.Point(350, 29);
            this.txtStock.MaxLength = 32767;
            this.txtStock.Multiline = false;
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = false;
            this.txtStock.Size = new System.Drawing.Size(75, 28);
            this.txtStock.TabIndex = 14;
            this.txtStock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStock.UseSystemPasswordChar = false;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(441, 13);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(67, 13);
            this.bunifuCustomLabel12.TabIndex = 17;
            this.bunifuCustomLabel12.Text = "Precio venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.White;
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.txtPrecioVenta.Location = new System.Drawing.Point(436, 29);
            this.txtPrecioVenta.MaxLength = 32767;
            this.txtPrecioVenta.Multiline = false;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = false;
            this.txtPrecioVenta.Size = new System.Drawing.Size(90, 28);
            this.txtPrecioVenta.TabIndex = 16;
            this.txtPrecioVenta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(569, 66);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(50, 13);
            this.bunifuCustomLabel14.TabIndex = 19;
            this.bunifuCustomLabel14.Text = "Impuesto";
            // 
            // impuestoValue
            // 
            this.impuestoValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.impuestoValue.ChechedOffColor = System.Drawing.Color.Silver;
            this.impuestoValue.Checked = true;
            this.impuestoValue.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.impuestoValue.ForeColor = System.Drawing.Color.White;
            this.impuestoValue.Location = new System.Drawing.Point(540, 63);
            this.impuestoValue.Name = "impuestoValue";
            this.impuestoValue.Size = new System.Drawing.Size(20, 20);
            this.impuestoValue.TabIndex = 18;
            // 
            // ID_Producto
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.ID_Producto.DefaultCellStyle = dataGridViewCellStyle14;
            this.ID_Producto.HeaderText = "ID";
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.Width = 25;
            // 
            // nombreProducto
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.nombreProducto.DefaultCellStyle = dataGridViewCellStyle15;
            this.nombreProducto.HeaderText = "Producto";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Width = 107;
            // 
            // cantidadProducto
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.cantidadProducto.DefaultCellStyle = dataGridViewCellStyle16;
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.Width = 65;
            // 
            // precioProducto
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.precioProducto.DefaultCellStyle = dataGridViewCellStyle17;
            this.precioProducto.HeaderText = "Precio unitario";
            this.precioProducto.Name = "precioProducto";
            // 
            // valorDescuentoProducto
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.valorDescuentoProducto.DefaultCellStyle = dataGridViewCellStyle18;
            this.valorDescuentoProducto.HeaderText = "Descuento";
            this.valorDescuentoProducto.Name = "valorDescuentoProducto";
            // 
            // impuestoProducto
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.impuestoProducto.DefaultCellStyle = dataGridViewCellStyle19;
            this.impuestoProducto.HeaderText = "Impuesto";
            this.impuestoProducto.Name = "impuestoProducto";
            // 
            // costoTotal
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.costoTotal.DefaultCellStyle = dataGridViewCellStyle20;
            this.costoTotal.HeaderText = "Total";
            this.costoTotal.Name = "costoTotal";
            // 
            // ventaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 700);
            this.Controls.Add(this.panelDatosVenta);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "compraForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatosVenta.ResumeLayout(false);
            this.panelDatosVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaClientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelDatosDetalleVenta.ResumeLayout(false);
            this.panelDatosDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVenta)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelDatosVenta;
        private iTalk.iTalk_TextBox_Small txtCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private iTalk.iTalk_ComboBox tipoPago;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private iTalk.iTalk_TextBox_Small txtCodigoCompra;
        private System.Windows.Forms.DataGridView vistaClientes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker fechaVenta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDatosDetalleVenta;
        private System.Windows.Forms.DataGridView vistaProducto;
        private Bunifu.Framework.UI.BunifuThinButton2 agregarProductoDetalle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private iTalk.iTalk_TextBox_Small descuentoProducto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private iTalk.iTalk_TextBox_Small txtProducto;
        private System.Windows.Forms.DataGridView detalleVenta;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuThinButton2 guardarButton;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelarButton;
        private iTalk.iTalk_TextBox_Small cantidadVentaProducto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCheckbox ventaCredito;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private iTalk.iTalk_TextBox_Small txtPrecioVenta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private iTalk.iTalk_TextBox_Small txtStock;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCheckbox impuestoValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDescuentoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuestoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotal;
    }
}