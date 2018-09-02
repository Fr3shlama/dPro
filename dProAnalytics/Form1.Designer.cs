namespace dProAnalytics
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.GetData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReadFile = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Drag1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Drag2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.updategraph = new Bunifu.Framework.UI.BunifuFlatButton();
            this.serPort = new System.IO.Ports.SerialPort(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuBorder
            // 
            this.bunifuBorder.ElipseRadius = 5;
            this.bunifuBorder.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // GetData
            // 
            this.GetData.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.GetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            this.GetData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GetData.BorderRadius = 0;
            this.GetData.ButtonText = "Get Data";
            this.GetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetData.DisabledColor = System.Drawing.Color.Gray;
            this.GetData.Iconcolor = System.Drawing.Color.Transparent;
            this.GetData.Iconimage = ((System.Drawing.Image)(resources.GetObject("GetData.Iconimage")));
            this.GetData.Iconimage_right = null;
            this.GetData.Iconimage_right_Selected = null;
            this.GetData.Iconimage_Selected = null;
            this.GetData.IconMarginLeft = 0;
            this.GetData.IconMarginRight = 0;
            this.GetData.IconRightVisible = true;
            this.GetData.IconRightZoom = 0D;
            this.GetData.IconVisible = true;
            this.GetData.IconZoom = 90D;
            this.GetData.IsTab = false;
            this.GetData.Location = new System.Drawing.Point(877, 468);
            this.GetData.Name = "GetData";
            this.GetData.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            this.GetData.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            this.GetData.OnHoverTextColor = System.Drawing.Color.White;
            this.GetData.selected = false;
            this.GetData.Size = new System.Drawing.Size(106, 48);
            this.GetData.TabIndex = 1;
            this.GetData.Text = "Get Data";
            this.GetData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GetData.Textcolor = System.Drawing.Color.White;
            this.GetData.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // ReadFile
            // 
            this.ReadFile.FileName = "data.rxt";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 31);
            this.panel1.TabIndex = 2;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(959, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 31);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 70);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Drag1
            // 
            this.Drag1.Fixed = true;
            this.Drag1.Horizontal = true;
            this.Drag1.TargetControl = this.panel1;
            this.Drag1.Vertical = true;
            // 
            // Drag2
            // 
            this.Drag2.Fixed = true;
            this.Drag2.Horizontal = true;
            this.Drag2.TargetControl = this.pictureBox1;
            this.Drag2.Vertical = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chart1.BorderlineWidth = 10;
            chartArea9.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea9.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea9.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea9.AxisX.ScrollBar.Size = 20D;
            chartArea9.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea9.BackSecondaryColor = System.Drawing.Color.White;
            chartArea9.BorderColor = System.Drawing.Color.White;
            chartArea9.CursorX.AutoScroll = false;
            chartArea9.CursorX.Interval = 15D;
            chartArea9.CursorX.IsUserEnabled = true;
            chartArea9.CursorX.IsUserSelectionEnabled = true;
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            legend9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend9.ForeColor = System.Drawing.Color.White;
            legend9.IsTextAutoFit = false;
            legend9.MaximumAutoSize = 80F;
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(-38, 113);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.IsValueShownAsLabel = true;
            series9.IsXValueIndexed = true;
            series9.Legend = "Legend1";
            series9.Name = "Fluid";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series9.YValueMembers = "Daten";
            series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(909, 403);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // errorbox
            // 
            this.errorbox.Location = new System.Drawing.Point(265, 55);
            this.errorbox.Name = "errorbox";
            this.errorbox.Size = new System.Drawing.Size(97, 20);
            this.errorbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Errorcode Output";
            // 
            // updategraph
            // 
            this.updategraph.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updategraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updategraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updategraph.BorderRadius = 0;
            this.updategraph.ButtonText = "Update Graph";
            this.updategraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updategraph.DisabledColor = System.Drawing.Color.Gray;
            this.updategraph.Iconcolor = System.Drawing.Color.Transparent;
            this.updategraph.Iconimage = ((System.Drawing.Image)(resources.GetObject("updategraph.Iconimage")));
            this.updategraph.Iconimage_right = null;
            this.updategraph.Iconimage_right_Selected = null;
            this.updategraph.Iconimage_Selected = null;
            this.updategraph.IconMarginLeft = 0;
            this.updategraph.IconMarginRight = 0;
            this.updategraph.IconRightVisible = true;
            this.updategraph.IconRightZoom = 0D;
            this.updategraph.IconVisible = true;
            this.updategraph.IconZoom = 90D;
            this.updategraph.IsTab = false;
            this.updategraph.Location = new System.Drawing.Point(877, 422);
            this.updategraph.Name = "updategraph";
            this.updategraph.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updategraph.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.updategraph.OnHoverTextColor = System.Drawing.Color.White;
            this.updategraph.selected = false;
            this.updategraph.Size = new System.Drawing.Size(106, 40);
            this.updategraph.TabIndex = 7;
            this.updategraph.Text = "Update Graph";
            this.updategraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updategraph.Textcolor = System.Drawing.Color.White;
            this.updategraph.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updategraph.Click += new System.EventHandler(this.updategraph_Click);
            // 
            // serPort
            // 
            this.serPort.PortName = "port";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Tools";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(265, 81);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(97, 26);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Tools";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-17, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(991, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.updategraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorbox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GetData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuBorder;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuFlatButton GetData;
        private System.Windows.Forms.OpenFileDialog ReadFile;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl Drag1;
        private Bunifu.Framework.UI.BunifuDragControl Drag2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox errorbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Bunifu.Framework.UI.BunifuFlatButton updategraph;
        private System.IO.Ports.SerialPort serPort;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label2;
    }
}

