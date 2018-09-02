namespace dProAnalytics {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.serPort = new System.IO.Ports.SerialPort(this.components);
            this.output = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ComTest = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ReadRom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ClearRom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // serPort
            // 
            this.serPort.PortName = "port";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.output.Location = new System.Drawing.Point(197, 72);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(114, 138);
            this.output.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(194, 56);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(117, 13);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Device Output / Status";
            // 
            // ComTest
            // 
            this.ComTest.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ComTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ComTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComTest.BorderRadius = 0;
            this.ComTest.ButtonText = "Test Com";
            this.ComTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComTest.DisabledColor = System.Drawing.Color.Gray;
            this.ComTest.Iconcolor = System.Drawing.Color.Transparent;
            this.ComTest.Iconimage = null;
            this.ComTest.Iconimage_right = null;
            this.ComTest.Iconimage_right_Selected = null;
            this.ComTest.Iconimage_Selected = null;
            this.ComTest.IconMarginLeft = 0;
            this.ComTest.IconMarginRight = 0;
            this.ComTest.IconRightVisible = true;
            this.ComTest.IconRightZoom = 0D;
            this.ComTest.IconVisible = true;
            this.ComTest.IconZoom = 90D;
            this.ComTest.IsTab = false;
            this.ComTest.Location = new System.Drawing.Point(12, 72);
            this.ComTest.Name = "ComTest";
            this.ComTest.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ComTest.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ComTest.OnHoverTextColor = System.Drawing.Color.White;
            this.ComTest.selected = false;
            this.ComTest.Size = new System.Drawing.Size(85, 18);
            this.ComTest.TabIndex = 2;
            this.ComTest.Text = "Test Com";
            this.ComTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComTest.Textcolor = System.Drawing.Color.White;
            this.ComTest.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComTest.Click += new System.EventHandler(this.ComTest_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(148)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 33);
            this.panel1.TabIndex = 3;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(298, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(31, 31);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panel1;
            this.bunifuDragControl3.Vertical = true;
            // 
            // ReadRom
            // 
            this.ReadRom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ReadRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ReadRom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReadRom.BorderRadius = 0;
            this.ReadRom.ButtonText = "Read Rom";
            this.ReadRom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadRom.DisabledColor = System.Drawing.Color.Gray;
            this.ReadRom.Iconcolor = System.Drawing.Color.Transparent;
            this.ReadRom.Iconimage = null;
            this.ReadRom.Iconimage_right = null;
            this.ReadRom.Iconimage_right_Selected = null;
            this.ReadRom.Iconimage_Selected = null;
            this.ReadRom.IconMarginLeft = 0;
            this.ReadRom.IconMarginRight = 0;
            this.ReadRom.IconRightVisible = true;
            this.ReadRom.IconRightZoom = 0D;
            this.ReadRom.IconVisible = true;
            this.ReadRom.IconZoom = 90D;
            this.ReadRom.IsTab = false;
            this.ReadRom.Location = new System.Drawing.Point(12, 96);
            this.ReadRom.Name = "ReadRom";
            this.ReadRom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ReadRom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ReadRom.OnHoverTextColor = System.Drawing.Color.White;
            this.ReadRom.selected = false;
            this.ReadRom.Size = new System.Drawing.Size(85, 18);
            this.ReadRom.TabIndex = 4;
            this.ReadRom.Text = "Read Rom";
            this.ReadRom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReadRom.Textcolor = System.Drawing.Color.White;
            this.ReadRom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadRom.Click += new System.EventHandler(this.ReadRom_Click);
            // 
            // ClearRom
            // 
            this.ClearRom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ClearRom.BackColor = System.Drawing.Color.Red;
            this.ClearRom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearRom.BorderRadius = 0;
            this.ClearRom.ButtonText = "Clear Rom";
            this.ClearRom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearRom.DisabledColor = System.Drawing.Color.Gray;
            this.ClearRom.Iconcolor = System.Drawing.Color.Transparent;
            this.ClearRom.Iconimage = null;
            this.ClearRom.Iconimage_right = null;
            this.ClearRom.Iconimage_right_Selected = null;
            this.ClearRom.Iconimage_Selected = null;
            this.ClearRom.IconMarginLeft = 0;
            this.ClearRom.IconMarginRight = 0;
            this.ClearRom.IconRightVisible = true;
            this.ClearRom.IconRightZoom = 0D;
            this.ClearRom.IconVisible = true;
            this.ClearRom.IconZoom = 90D;
            this.ClearRom.IsTab = false;
            this.ClearRom.Location = new System.Drawing.Point(12, 190);
            this.ClearRom.Name = "ClearRom";
            this.ClearRom.Normalcolor = System.Drawing.Color.Red;
            this.ClearRom.OnHovercolor = System.Drawing.Color.Red;
            this.ClearRom.OnHoverTextColor = System.Drawing.Color.White;
            this.ClearRom.selected = false;
            this.ClearRom.Size = new System.Drawing.Size(85, 18);
            this.ClearRom.TabIndex = 5;
            this.ClearRom.Text = "Clear Rom";
            this.ClearRom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearRom.Textcolor = System.Drawing.Color.White;
            this.ClearRom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearRom.Click += new System.EventHandler(this.ClearRom_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(323, 220);
            this.Controls.Add(this.ClearRom);
            this.Controls.Add(this.ReadRom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ComTest);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serPort;
        private System.Windows.Forms.TextBox output;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton ComTest;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuFlatButton ReadRom;
        private Bunifu.Framework.UI.BunifuFlatButton ClearRom;
    }
}