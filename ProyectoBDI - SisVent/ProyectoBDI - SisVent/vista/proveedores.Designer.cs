namespace ProyectoBDI___SisVent.vista
{
    partial class proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proveedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listarButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.agregarButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.vistaProveedores = new System.Windows.Forms.DataGridView();
            this.seeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.editButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.erraseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.metodoBusqueda = new iTalk.iTalk_ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erraseButton)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "/Proveedores";
            // 
            // listarButton
            // 
            this.listarButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(58)))), ((int)(((byte)(110)))));
            this.listarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(121)))));
            this.listarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listarButton.BorderRadius = 0;
            this.listarButton.ButtonText = "   Mostrar todos";
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
            this.listarButton.IconZoom = 60D;
            this.listarButton.IsTab = false;
            this.listarButton.Location = new System.Drawing.Point(642, 87);
            this.listarButton.Name = "listarButton";
            this.listarButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(121)))));
            this.listarButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(58)))), ((int)(((byte)(110)))));
            this.listarButton.OnHoverTextColor = System.Drawing.Color.White;
            this.listarButton.selected = false;
            this.listarButton.Size = new System.Drawing.Size(170, 40);
            this.listarButton.TabIndex = 3;
            this.listarButton.Text = "   Mostrar todos";
            this.listarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listarButton.Textcolor = System.Drawing.Color.White;
            this.listarButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.agregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.agregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarButton.BorderRadius = 0;
            this.agregarButton.ButtonText = "   Nuevo proveedor";
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
            this.agregarButton.IconZoom = 60D;
            this.agregarButton.IsTab = false;
            this.agregarButton.Location = new System.Drawing.Point(451, 87);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.agregarButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.agregarButton.OnHoverTextColor = System.Drawing.Color.White;
            this.agregarButton.selected = false;
            this.agregarButton.Size = new System.Drawing.Size(170, 40);
            this.agregarButton.TabIndex = 2;
            this.agregarButton.Text = "   Nuevo proveedor";
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarButton.Textcolor = System.Drawing.Color.White;
            this.agregarButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(44, 87);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(350, 40);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.text = "";
            // 
            // vistaProveedores
            // 
            this.vistaProveedores.AllowUserToAddRows = false;
            this.vistaProveedores.AllowUserToDeleteRows = false;
            this.vistaProveedores.BackgroundColor = System.Drawing.Color.White;
            this.vistaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vistaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.vistaProveedores.Location = new System.Drawing.Point(75, 146);
            this.vistaProveedores.Name = "vistaProveedores";
            this.vistaProveedores.ReadOnly = true;
            this.vistaProveedores.Size = new System.Drawing.Size(800, 498);
            this.vistaProveedores.TabIndex = 7;
            // 
            // seeButton
            // 
            this.seeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.seeButton.Image = ((System.Drawing.Image)(resources.GetObject("seeButton.Image")));
            this.seeButton.ImageActive = null;
            this.seeButton.Location = new System.Drawing.Point(34, 151);
            this.seeButton.Name = "seeButton";
            this.seeButton.Size = new System.Drawing.Size(35, 35);
            this.seeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.seeButton.TabIndex = 8;
            this.seeButton.TabStop = false;
            this.seeButton.Zoom = 10;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageActive = null;
            this.editButton.Location = new System.Drawing.Point(34, 192);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(35, 35);
            this.editButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.editButton.TabIndex = 9;
            this.editButton.TabStop = false;
            this.editButton.Zoom = 10;
            // 
            // erraseButton
            // 
            this.erraseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.erraseButton.Image = ((System.Drawing.Image)(resources.GetObject("erraseButton.Image")));
            this.erraseButton.ImageActive = null;
            this.erraseButton.Location = new System.Drawing.Point(34, 233);
            this.erraseButton.Name = "erraseButton";
            this.erraseButton.Size = new System.Drawing.Size(35, 35);
            this.erraseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.erraseButton.TabIndex = 10;
            this.erraseButton.TabStop = false;
            this.erraseButton.Zoom = 10;
            // 
            // metodoBusqueda
            // 
            this.metodoBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.metodoBusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metodoBusqueda.DropDownHeight = 100;
            this.metodoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metodoBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.metodoBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.metodoBusqueda.FormattingEnabled = true;
            this.metodoBusqueda.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(182)))), ((int)(((byte)(215)))));
            this.metodoBusqueda.IntegralHeight = false;
            this.metodoBusqueda.ItemHeight = 20;
            this.metodoBusqueda.Items.AddRange(new object[] {
            "Nombre o ID",
            "Correo",
            "Dirección",
            "Teléfono"});
            this.metodoBusqueda.Location = new System.Drawing.Point(44, 56);
            this.metodoBusqueda.Name = "metodoBusqueda";
            this.metodoBusqueda.Size = new System.Drawing.Size(135, 26);
            this.metodoBusqueda.StartIndex = 0;
            this.metodoBusqueda.TabIndex = 5;
            // 
            // proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.erraseButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.seeButton);
            this.Controls.Add(this.vistaProveedores);
            this.Controls.Add(this.metodoBusqueda);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.panel1);
            this.Name = "proveedores";
            this.Size = new System.Drawing.Size(950, 670);
            this.Load += new System.EventHandler(this.clientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vistaProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erraseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton agregarButton;
        private Bunifu.Framework.UI.BunifuFlatButton listarButton;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private iTalk.iTalk_ComboBox metodoBusqueda;
        private System.Windows.Forms.DataGridView vistaProveedores;
        private Bunifu.Framework.UI.BunifuImageButton seeButton;
        private Bunifu.Framework.UI.BunifuImageButton editButton;
        private Bunifu.Framework.UI.BunifuImageButton erraseButton;
    }
}
