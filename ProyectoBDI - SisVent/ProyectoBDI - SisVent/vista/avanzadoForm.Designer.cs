namespace ProyectoBDI___SisVent.vista
{
    partial class avanzadoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(avanzadoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.iTalk_TabControl1 = new iTalk.iTalk_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.agregarCategoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.vistaCategorias = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mostrarInhabilitados = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtBuscarCategoria = new Bunifu.Framework.UI.BunifuTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vistaProductosInhabilitados = new System.Windows.Forms.DataGridView();
            this.txtBuscarProductoInhabilitado = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.iTalk_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCategorias)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosInhabilitados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 40);
            this.panel1.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(672, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeButton.TabIndex = 11;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(13, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(93, 21);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Avanzado";
            // 
            // iTalk_TabControl1
            // 
            this.iTalk_TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.iTalk_TabControl1.Controls.Add(this.tabPage1);
            this.iTalk_TabControl1.Controls.Add(this.tabPage2);
            this.iTalk_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.iTalk_TabControl1.ItemSize = new System.Drawing.Size(50, 150);
            this.iTalk_TabControl1.Location = new System.Drawing.Point(0, 40);
            this.iTalk_TabControl1.Multiline = true;
            this.iTalk_TabControl1.Name = "iTalk_TabControl1";
            this.iTalk_TabControl1.SelectedIndex = 0;
            this.iTalk_TabControl1.Size = new System.Drawing.Size(711, 447);
            this.iTalk_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.agregarCategoria);
            this.tabPage1.Controls.Add(this.vistaCategorias);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage1.Controls.Add(this.mostrarInhabilitados);
            this.tabPage1.Controls.Add(this.txtBuscarCategoria);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(553, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Administrar categorías";
            // 
            // agregarCategoria
            // 
            this.agregarCategoria.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.agregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.agregarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarCategoria.BorderRadius = 0;
            this.agregarCategoria.ButtonText = "     Agregar categoría";
            this.agregarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarCategoria.DisabledColor = System.Drawing.Color.Gray;
            this.agregarCategoria.Iconcolor = System.Drawing.Color.Transparent;
            this.agregarCategoria.Iconimage = ((System.Drawing.Image)(resources.GetObject("agregarCategoria.Iconimage")));
            this.agregarCategoria.Iconimage_right = null;
            this.agregarCategoria.Iconimage_right_Selected = null;
            this.agregarCategoria.Iconimage_Selected = null;
            this.agregarCategoria.IconMarginLeft = 0;
            this.agregarCategoria.IconMarginRight = 0;
            this.agregarCategoria.IconRightVisible = true;
            this.agregarCategoria.IconRightZoom = 0D;
            this.agregarCategoria.IconVisible = true;
            this.agregarCategoria.IconZoom = 60D;
            this.agregarCategoria.IsTab = false;
            this.agregarCategoria.Location = new System.Drawing.Point(262, 18);
            this.agregarCategoria.Name = "agregarCategoria";
            this.agregarCategoria.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.agregarCategoria.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.agregarCategoria.OnHoverTextColor = System.Drawing.Color.White;
            this.agregarCategoria.selected = false;
            this.agregarCategoria.Size = new System.Drawing.Size(170, 35);
            this.agregarCategoria.TabIndex = 7;
            this.agregarCategoria.Text = "     Agregar categoría";
            this.agregarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarCategoria.Textcolor = System.Drawing.Color.White;
            this.agregarCategoria.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarCategoria.Click += new System.EventHandler(this.agregarCategoria_Click_1);
            // 
            // vistaCategorias
            // 
            this.vistaCategorias.AllowUserToAddRows = false;
            this.vistaCategorias.AllowUserToDeleteRows = false;
            this.vistaCategorias.BackgroundColor = System.Drawing.Color.White;
            this.vistaCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vistaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.vistaCategorias.Location = new System.Drawing.Point(25, 118);
            this.vistaCategorias.MultiSelect = false;
            this.vistaCategorias.Name = "vistaCategorias";
            this.vistaCategorias.ReadOnly = true;
            this.vistaCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vistaCategorias.Size = new System.Drawing.Size(503, 272);
            this.vistaCategorias.TabIndex = 4;
            this.vistaCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vistaCategorias_CellDoubleClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 64);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(157, 13);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Mostrar categorías inhabilitadas";
            // 
            // mostrarInhabilitados
            // 
            this.mostrarInhabilitados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.mostrarInhabilitados.ChechedOffColor = System.Drawing.Color.Silver;
            this.mostrarInhabilitados.Checked = true;
            this.mostrarInhabilitados.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.mostrarInhabilitados.ForeColor = System.Drawing.Color.White;
            this.mostrarInhabilitados.Location = new System.Drawing.Point(21, 60);
            this.mostrarInhabilitados.Name = "mostrarInhabilitados";
            this.mostrarInhabilitados.Size = new System.Drawing.Size(20, 20);
            this.mostrarInhabilitados.TabIndex = 1;
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.BackColor = System.Drawing.Color.White;
            this.txtBuscarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarCategoria.BackgroundImage")));
            this.txtBuscarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.txtBuscarCategoria.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarCategoria.Icon")));
            this.txtBuscarCategoria.Location = new System.Drawing.Point(21, 18);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(200, 35);
            this.txtBuscarCategoria.TabIndex = 0;
            this.txtBuscarCategoria.text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.vistaProductosInhabilitados);
            this.tabPage2.Controls.Add(this.txtBuscarProductoInhabilitado);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.MinimumSize = new System.Drawing.Size(126, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos deshabilitados";
            // 
            // vistaProductosInhabilitados
            // 
            this.vistaProductosInhabilitados.AllowUserToAddRows = false;
            this.vistaProductosInhabilitados.AllowUserToDeleteRows = false;
            this.vistaProductosInhabilitados.BackgroundColor = System.Drawing.Color.White;
            this.vistaProductosInhabilitados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vistaProductosInhabilitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaProductosInhabilitados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.vistaProductosInhabilitados.Location = new System.Drawing.Point(27, 115);
            this.vistaProductosInhabilitados.MultiSelect = false;
            this.vistaProductosInhabilitados.Name = "vistaProductosInhabilitados";
            this.vistaProductosInhabilitados.ReadOnly = true;
            this.vistaProductosInhabilitados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vistaProductosInhabilitados.Size = new System.Drawing.Size(503, 272);
            this.vistaProductosInhabilitados.TabIndex = 8;
            this.vistaProductosInhabilitados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vistaProductosInhabilitados_CellDoubleClick);
            // 
            // txtBuscarProductoInhabilitado
            // 
            this.txtBuscarProductoInhabilitado.BackColor = System.Drawing.Color.White;
            this.txtBuscarProductoInhabilitado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarProductoInhabilitado.BackgroundImage")));
            this.txtBuscarProductoInhabilitado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarProductoInhabilitado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.txtBuscarProductoInhabilitado.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarProductoInhabilitado.Icon")));
            this.txtBuscarProductoInhabilitado.Location = new System.Drawing.Point(27, 33);
            this.txtBuscarProductoInhabilitado.Name = "txtBuscarProductoInhabilitado";
            this.txtBuscarProductoInhabilitado.Size = new System.Drawing.Size(200, 35);
            this.txtBuscarProductoInhabilitado.TabIndex = 7;
            this.txtBuscarProductoInhabilitado.text = "";
            // 
            // avanzadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 487);
            this.Controls.Add(this.iTalk_TabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "avanzadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTalk_ThemeContainer1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.iTalk_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCategorias)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosInhabilitados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_TabControl iTalk_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView vistaCategorias;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox mostrarInhabilitados;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarCategoria;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView vistaProductosInhabilitados;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarProductoInhabilitado;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton agregarCategoria;
    }
}