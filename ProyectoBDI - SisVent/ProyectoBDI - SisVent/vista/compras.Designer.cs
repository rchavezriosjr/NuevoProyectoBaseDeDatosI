namespace ProyectoBDI___SisVent.vista
{
    partial class compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compras));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metodoBusqueda = new iTalk.iTalk_ComboBox();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.agregarButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.dataGridView1.Location = new System.Drawing.Point(75, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 498);
            this.dataGridView1.TabIndex = 16;
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
            "ID",
            "Proveedor",
            "Fecha",
            "Monto"});
            this.metodoBusqueda.Location = new System.Drawing.Point(44, 69);
            this.metodoBusqueda.Name = "metodoBusqueda";
            this.metodoBusqueda.Size = new System.Drawing.Size(135, 26);
            this.metodoBusqueda.StartIndex = 0;
            this.metodoBusqueda.TabIndex = 15;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(44, 100);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(350, 40);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.text = "";
            this.txtBuscar.OnTextChange += new System.EventHandler(this.txtBuscar_OnTextChange);
            // 
            // agregarButton
            // 
            this.agregarButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(149)))), ((int)(((byte)(69)))));
            this.agregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(149)))), ((int)(((byte)(69)))));
            this.agregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarButton.BorderRadius = 0;
            this.agregarButton.ButtonText = "   Nueva compra";
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
            this.agregarButton.Location = new System.Drawing.Point(451, 100);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(149)))), ((int)(((byte)(69)))));
            this.agregarButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(166)))), ((int)(((byte)(78)))));
            this.agregarButton.OnHoverTextColor = System.Drawing.Color.White;
            this.agregarButton.selected = false;
            this.agregarButton.Size = new System.Drawing.Size(150, 40);
            this.agregarButton.TabIndex = 12;
            this.agregarButton.Text = "   Nueva compra";
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarButton.Textcolor = System.Drawing.Color.White;
            this.agregarButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 50);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "/Compras";
            // 
            // compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metodoBusqueda);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.panel1);
            this.Name = "compras";
            this.Size = new System.Drawing.Size(950, 670);
            this.Load += new System.EventHandler(this.compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private iTalk.iTalk_ComboBox metodoBusqueda;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuFlatButton agregarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
