﻿namespace ProyectoBDI___SisVent.vista
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
            this.agregarButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.vistaClientes = new System.Windows.Forms.DataGridView();
            this.erraseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.metodoBusqueda = new iTalk.iTalk_ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaClientes)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "/Clientes";
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
            this.agregarButton.IconZoom = 60D;
            this.agregarButton.IsTab = false;
            this.agregarButton.Location = new System.Drawing.Point(451, 87);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.agregarButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.agregarButton.OnHoverTextColor = System.Drawing.Color.White;
            this.agregarButton.selected = false;
            this.agregarButton.Size = new System.Drawing.Size(150, 40);
            this.agregarButton.TabIndex = 2;
            this.agregarButton.Text = "   Nuevo cliente";
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
            this.txtBuscar.OnTextChange += new System.EventHandler(this.txtBuscar_OnTextChange);
            // 
            // vistaClientes
            // 
            this.vistaClientes.AllowUserToAddRows = false;
            this.vistaClientes.AllowUserToDeleteRows = false;
            this.vistaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vistaClientes.BackgroundColor = System.Drawing.Color.White;
            this.vistaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vistaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.vistaClientes.Location = new System.Drawing.Point(75, 146);
            this.vistaClientes.MultiSelect = false;
            this.vistaClientes.Name = "vistaClientes";
            this.vistaClientes.ReadOnly = true;
            this.vistaClientes.RowHeadersVisible = false;
            this.vistaClientes.RowHeadersWidth = 10;
            this.vistaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vistaClientes.Size = new System.Drawing.Size(800, 498);
            this.vistaClientes.TabIndex = 7;
            this.vistaClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // erraseButton
            // 
            this.erraseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(146)))), ((int)(((byte)(195)))));
            this.erraseButton.Image = ((System.Drawing.Image)(resources.GetObject("erraseButton.Image")));
            this.erraseButton.ImageActive = null;
            this.erraseButton.Location = new System.Drawing.Point(639, 87);
            this.erraseButton.Name = "erraseButton";
            this.erraseButton.Size = new System.Drawing.Size(40, 40);
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
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.erraseButton);
            this.Controls.Add(this.vistaClientes);
            this.Controls.Add(this.metodoBusqueda);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.panel1);
            this.Name = "clientes";
            this.Size = new System.Drawing.Size(950, 670);
            this.Load += new System.EventHandler(this.clientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vistaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erraseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton agregarButton;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private iTalk.iTalk_ComboBox metodoBusqueda;
        private System.Windows.Forms.DataGridView vistaClientes;
        private Bunifu.Framework.UI.BunifuImageButton erraseButton;
    }
}
