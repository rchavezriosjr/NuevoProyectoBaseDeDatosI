namespace ProyectoBDI___SisVent.vista
{
    partial class categoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoriaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.editarButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescripcion = new iTalk.iTalk_RichTextBox();
            this.txtId = new iTalk.iTalk_TextBox_Small();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombre = new iTalk.iTalk_TextBox_Small();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.estadoValor = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.aceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editarButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.editarButton);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 40);
            this.panel1.TabIndex = 0;
            // 
            // editarButton
            // 
            this.editarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.editarButton.Image = ((System.Drawing.Image)(resources.GetObject("editarButton.Image")));
            this.editarButton.ImageActive = null;
            this.editarButton.Location = new System.Drawing.Point(450, 5);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(30, 30);
            this.editarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.editarButton.TabIndex = 13;
            this.editarButton.TabStop = false;
            this.editarButton.Zoom = 10;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(17, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(175, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Información categoría";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(297, 57);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(67, 13);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "ID categoría";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoWordSelection = false;
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.txtDescripcion.Location = new System.Drawing.Point(22, 132);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = false;
            this.txtDescripcion.Size = new System.Drawing.Size(360, 74);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.WordWrap = true;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Transparent;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.txtId.Location = new System.Drawing.Point(295, 74);
            this.txtId.MaxLength = 32767;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = false;
            this.txtId.Size = new System.Drawing.Size(87, 28);
            this.txtId.TabIndex = 5;
            this.txtId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(24, 116);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(63, 13);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.txtNombre.Location = new System.Drawing.Point(22, 74);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.Size = new System.Drawing.Size(189, 28);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(24, 57);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(93, 13);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Nombre categoría";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(49, 216);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(45, 13);
            this.bunifuCustomLabel5.TabIndex = 10;
            this.bunifuCustomLabel5.Text = "Habilitar";
            // 
            // estadoValor
            // 
            this.estadoValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.estadoValor.ChechedOffColor = System.Drawing.Color.Silver;
            this.estadoValor.Checked = true;
            this.estadoValor.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.estadoValor.ForeColor = System.Drawing.Color.White;
            this.estadoValor.Location = new System.Drawing.Point(22, 212);
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.Size = new System.Drawing.Size(20, 20);
            this.estadoValor.TabIndex = 9;
            // 
            // cancelar
            // 
            this.cancelar.ActiveBorderThickness = 1;
            this.cancelar.ActiveCornerRadius = 20;
            this.cancelar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.cancelar.ActiveForecolor = System.Drawing.Color.White;
            this.cancelar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelar.BackgroundImage")));
            this.cancelar.ButtonText = "Cancelar";
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.cancelar.IdleBorderThickness = 1;
            this.cancelar.IdleCornerRadius = 20;
            this.cancelar.IdleFillColor = System.Drawing.Color.White;
            this.cancelar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.cancelar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.cancelar.Location = new System.Drawing.Point(254, 234);
            this.cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 35);
            this.cancelar.TabIndex = 11;
            this.cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.ActiveBorderThickness = 1;
            this.aceptar.ActiveCornerRadius = 20;
            this.aceptar.ActiveFillColor = System.Drawing.Color.White;
            this.aceptar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.aceptar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptar.BackgroundImage")));
            this.aceptar.ButtonText = "Guardar";
            this.aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.aceptar.IdleBorderThickness = 1;
            this.aceptar.IdleCornerRadius = 20;
            this.aceptar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.aceptar.IdleForecolor = System.Drawing.Color.White;
            this.aceptar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.aceptar.Location = new System.Drawing.Point(374, 234);
            this.aceptar.Margin = new System.Windows.Forms.Padding(5);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(100, 35);
            this.aceptar.TabIndex = 12;
            this.aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // categoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 283);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.estadoValor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoriaForm";
            this.Load += new System.EventHandler(this.categoriaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editarButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private iTalk.iTalk_RichTextBox txtDescripcion;
        private iTalk.iTalk_TextBox_Small txtId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private iTalk.iTalk_TextBox_Small txtNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox estadoValor;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 aceptar;
        private Bunifu.Framework.UI.BunifuImageButton editarButton;
    }
}