namespace PcdcrSystem.Report
{
    partial class MonthRptFrm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.RadDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.RadDateTimePicker);
            this.layoutControl1.Controls.Add(this.radDateTimePicker1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(313, 98);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(313, 98);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 64);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(289, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(40, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(293, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.AutoSize = false;
            this.radDateTimePicker1.Culture = new System.Globalization.CultureInfo("en-UG");
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.radDateTimePicker1.Location = new System.Drawing.Point(109, 36);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(192, 24);
            this.radDateTimePicker1.TabIndex = 7;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "15/04/2016";
            this.radDateTimePicker1.ThemeName = "Office2013Dark";
            this.radDateTimePicker1.Value = new System.DateTime(2016, 4, 15, 16, 42, 27, 691);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.radDateTimePicker1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(293, 28);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            // 
            // RadDateTimePicker
            // 
            this.RadDateTimePicker.AutoSize = false;
            this.RadDateTimePicker.Culture = new System.Globalization.CultureInfo("en-UG");
            this.RadDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RadDateTimePicker.Location = new System.Drawing.Point(109, 12);
            this.RadDateTimePicker.Name = "RadDateTimePicker";
            this.RadDateTimePicker.Size = new System.Drawing.Size(192, 20);
            this.RadDateTimePicker.TabIndex = 7;
            this.RadDateTimePicker.TabStop = false;
            this.RadDateTimePicker.Text = "15/04/2016";
            this.RadDateTimePicker.ThemeName = "Office2013Dark";
            this.RadDateTimePicker.Value = new System.DateTime(2016, 4, 15, 16, 42, 27, 691);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.RadDateTimePicker;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(293, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // MonthRptFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 98);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MonthRptFrm";
            this.Text = "MonthRptFrm";
            this.Load += new System.EventHandler(this.MonthRptFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Telerik.WinControls.UI.RadDateTimePicker RadDateTimePicker;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}