namespace ProyectoBDI___SisVent.vista
{
    partial class adminCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminCuentas));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iTalk_TabControl1 = new iTalk.iTalk_TabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.agregarButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.erraseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.vistaUsuarios = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.tabInformacion = new System.Windows.Forms.TabPage();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelContentVentas = new System.Windows.Forms.Panel();
            this.contentPanelCompras = new System.Windows.Forms.Panel();
            this.contentPanelGeneral = new System.Windows.Forms.Panel();
            this.chartGeneral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.generalClick = new System.Windows.Forms.PictureBox();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ventasClick = new System.Windows.Forms.PictureBox();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comprasClick = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.iTalk_TabControl1.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erraseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuarios)).BeginInit();
            this.tabInformacion.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.contentPanelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral)).BeginInit();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalClick)).BeginInit();
            this.panelVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasClick)).BeginInit();
            this.panelCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasClick)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "/Administración";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.iTalk_TabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.MinimumSize = new System.Drawing.Size(126, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 620);
            this.panel2.TabIndex = 1;
            // 
            // iTalk_TabControl1
            // 
            this.iTalk_TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.iTalk_TabControl1.Controls.Add(this.tabUsuarios);
            this.iTalk_TabControl1.Controls.Add(this.tabInformacion);
            this.iTalk_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.iTalk_TabControl1.ItemSize = new System.Drawing.Size(44, 135);
            this.iTalk_TabControl1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_TabControl1.Multiline = true;
            this.iTalk_TabControl1.Name = "iTalk_TabControl1";
            this.iTalk_TabControl1.SelectedIndex = 0;
            this.iTalk_TabControl1.Size = new System.Drawing.Size(950, 620);
            this.iTalk_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl1.TabIndex = 0;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabUsuarios.Controls.Add(this.agregarButton);
            this.tabUsuarios.Controls.Add(this.panel3);
            this.tabUsuarios.Controls.Add(this.erraseButton);
            this.tabUsuarios.Controls.Add(this.vistaUsuarios);
            this.tabUsuarios.Controls.Add(this.txtBuscar);
            this.tabUsuarios.Location = new System.Drawing.Point(139, 4);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(807, 612);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuarios";
            // 
            // agregarButton
            // 
            this.agregarButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.agregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.agregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarButton.BorderRadius = 0;
            this.agregarButton.ButtonText = "   Crear usuario";
            this.agregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarButton.DisabledColor = System.Drawing.Color.Gray;
            this.agregarButton.Iconcolor = System.Drawing.Color.Transparent;
            this.agregarButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("agregarButton.Iconimage")));
            this.agregarButton.Iconimage_right = null;
            this.agregarButton.Iconimage_right_Selected = null;
            this.agregarButton.Iconimage_Selected = null;
            this.agregarButton.IconMarginLeft = 0;
            this.agregarButton.IconMarginRight = 0;
            this.agregarButton.IconRightVisible = false;
            this.agregarButton.IconRightZoom = 0D;
            this.agregarButton.IconVisible = false;
            this.agregarButton.IconZoom = 60D;
            this.agregarButton.IsTab = false;
            this.agregarButton.Location = new System.Drawing.Point(105, 93);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.agregarButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.agregarButton.OnHoverTextColor = System.Drawing.Color.White;
            this.agregarButton.selected = false;
            this.agregarButton.Size = new System.Drawing.Size(150, 40);
            this.agregarButton.TabIndex = 26;
            this.agregarButton.Text = "   Crear usuario";
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarButton.Textcolor = System.Drawing.Color.White;
            this.agregarButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 50);
            this.panel3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "/Administración/Usuarios";
            // 
            // erraseButton
            // 
            this.erraseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(146)))), ((int)(((byte)(195)))));
            this.erraseButton.Image = ((System.Drawing.Image)(resources.GetObject("erraseButton.Image")));
            this.erraseButton.ImageActive = null;
            this.erraseButton.Location = new System.Drawing.Point(661, 93);
            this.erraseButton.Name = "erraseButton";
            this.erraseButton.Size = new System.Drawing.Size(40, 40);
            this.erraseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.erraseButton.TabIndex = 24;
            this.erraseButton.TabStop = false;
            this.erraseButton.Zoom = 10;
            // 
            // vistaUsuarios
            // 
            this.vistaUsuarios.AllowUserToAddRows = false;
            this.vistaUsuarios.AllowUserToDeleteRows = false;
            this.vistaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vistaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.vistaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vistaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.vistaUsuarios.Location = new System.Drawing.Point(105, 144);
            this.vistaUsuarios.MultiSelect = false;
            this.vistaUsuarios.Name = "vistaUsuarios";
            this.vistaUsuarios.ReadOnly = true;
            this.vistaUsuarios.RowHeadersVisible = false;
            this.vistaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vistaUsuarios.Size = new System.Drawing.Size(596, 376);
            this.vistaUsuarios.TabIndex = 23;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(276, 93);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(379, 40);
            this.txtBuscar.TabIndex = 22;
            this.txtBuscar.text = "";
            this.txtBuscar.OnTextChange += new System.EventHandler(this.txtBuscar_OnTextChange);
            // 
            // tabInformacion
            // 
            this.tabInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabInformacion.Controls.Add(this.bunifuCards1);
            this.tabInformacion.Controls.Add(this.panel4);
            this.tabInformacion.Location = new System.Drawing.Point(139, 4);
            this.tabInformacion.Name = "tabInformacion";
            this.tabInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformacion.Size = new System.Drawing.Size(807, 612);
            this.tabInformacion.TabIndex = 1;
            this.tabInformacion.Text = "Información";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.White;
            this.bunifuCards1.Controls.Add(this.panel8);
            this.bunifuCards1.Controls.Add(this.panelGeneral);
            this.bunifuCards1.Controls.Add(this.panelVentas);
            this.bunifuCards1.Controls.Add(this.panelCompras);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(75, 59);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 25;
            this.bunifuCards1.Size = new System.Drawing.Size(657, 539);
            this.bunifuCards1.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panelContentVentas);
            this.panel8.Controls.Add(this.contentPanelCompras);
            this.panel8.Controls.Add(this.contentPanelGeneral);
            this.panel8.Location = new System.Drawing.Point(12, 77);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(632, 450);
            this.panel8.TabIndex = 12;
            // 
            // panelContentVentas
            // 
            this.panelContentVentas.BackColor = System.Drawing.Color.White;
            this.panelContentVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContentVentas.Location = new System.Drawing.Point(98, 0);
            this.panelContentVentas.Name = "panelContentVentas";
            this.panelContentVentas.Size = new System.Drawing.Size(461, 100);
            this.panelContentVentas.TabIndex = 2;
            // 
            // contentPanelCompras
            // 
            this.contentPanelCompras.BackColor = System.Drawing.Color.White;
            this.contentPanelCompras.Dock = System.Windows.Forms.DockStyle.Left;
            this.contentPanelCompras.Location = new System.Drawing.Point(0, 0);
            this.contentPanelCompras.Name = "contentPanelCompras";
            this.contentPanelCompras.Size = new System.Drawing.Size(98, 450);
            this.contentPanelCompras.TabIndex = 1;
            // 
            // contentPanelGeneral
            // 
            this.contentPanelGeneral.BackColor = System.Drawing.Color.White;
            this.contentPanelGeneral.Controls.Add(this.chartGeneral);
            this.contentPanelGeneral.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentPanelGeneral.Location = new System.Drawing.Point(559, 0);
            this.contentPanelGeneral.Name = "contentPanelGeneral";
            this.contentPanelGeneral.Size = new System.Drawing.Size(73, 450);
            this.contentPanelGeneral.TabIndex = 0;
            // 
            // chartGeneral
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGeneral.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGeneral.Legends.Add(legend1);
            this.chartGeneral.Location = new System.Drawing.Point(25, 131);
            this.chartGeneral.Name = "chartGeneral";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGeneral.Series.Add(series1);
            this.chartGeneral.Size = new System.Drawing.Size(300, 300);
            this.chartGeneral.TabIndex = 0;
            this.chartGeneral.Text = "chart1";
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.panelGeneral.Controls.Add(this.label4);
            this.panelGeneral.Controls.Add(this.label5);
            this.panelGeneral.Controls.Add(this.generalClick);
            this.panelGeneral.Location = new System.Drawing.Point(444, 11);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(200, 50);
            this.panelGeneral.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "General";
            // 
            // generalClick
            // 
            this.generalClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(216)))));
            this.generalClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generalClick.Image = ((System.Drawing.Image)(resources.GetObject("generalClick.Image")));
            this.generalClick.Location = new System.Drawing.Point(1, 0);
            this.generalClick.Name = "generalClick";
            this.generalClick.Size = new System.Drawing.Size(50, 50);
            this.generalClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.generalClick.TabIndex = 2;
            this.generalClick.TabStop = false;
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.panelVentas.Controls.Add(this.label8);
            this.panelVentas.Controls.Add(this.label9);
            this.panelVentas.Controls.Add(this.ventasClick);
            this.panelVentas.Location = new System.Drawing.Point(228, 11);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(200, 50);
            this.panelVentas.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(73, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "#";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(64, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ventas";
            // 
            // ventasClick
            // 
            this.ventasClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(68)))), ((int)(((byte)(50)))));
            this.ventasClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ventasClick.Image = ((System.Drawing.Image)(resources.GetObject("ventasClick.Image")));
            this.ventasClick.Location = new System.Drawing.Point(1, 0);
            this.ventasClick.Name = "ventasClick";
            this.ventasClick.Size = new System.Drawing.Size(50, 50);
            this.ventasClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ventasClick.TabIndex = 2;
            this.ventasClick.TabStop = false;
            // 
            // panelCompras
            // 
            this.panelCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.panelCompras.Controls.Add(this.label6);
            this.panelCompras.Controls.Add(this.label7);
            this.panelCompras.Controls.Add(this.comprasClick);
            this.panelCompras.Location = new System.Drawing.Point(12, 11);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(200, 50);
            this.panelCompras.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "#";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(64, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Compras";
            // 
            // comprasClick
            // 
            this.comprasClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(81)))));
            this.comprasClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comprasClick.Image = ((System.Drawing.Image)(resources.GetObject("comprasClick.Image")));
            this.comprasClick.Location = new System.Drawing.Point(1, 0);
            this.comprasClick.Name = "comprasClick";
            this.comprasClick.Size = new System.Drawing.Size(50, 50);
            this.comprasClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.comprasClick.TabIndex = 2;
            this.comprasClick.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(801, 50);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(17, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "/Administración/Información";
            // 
            // adminCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminCuentas";
            this.Size = new System.Drawing.Size(950, 670);
            this.Load += new System.EventHandler(this.clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.iTalk_TabControl1.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erraseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuarios)).EndInit();
            this.tabInformacion.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.contentPanelGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral)).EndInit();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalClick)).EndInit();
            this.panelVentas.ResumeLayout(false);
            this.panelVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasClick)).EndInit();
            this.panelCompras.ResumeLayout(false);
            this.panelCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasClick)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private iTalk.iTalk_TabControl iTalk_TabControl1;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton erraseButton;
        private System.Windows.Forms.DataGridView vistaUsuarios;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private System.Windows.Forms.TabPage tabInformacion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton agregarButton;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelContentVentas;
        private System.Windows.Forms.Panel contentPanelCompras;
        private System.Windows.Forms.Panel contentPanelGeneral;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeneral;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox generalClick;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ventasClick;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox comprasClick;
    }
}
