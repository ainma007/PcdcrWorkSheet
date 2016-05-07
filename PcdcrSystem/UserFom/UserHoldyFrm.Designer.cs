namespace PcdcrSystem.UserFom
{
    partial class UserHoldyFrm
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.HoldyTypeDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.holdyDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoldyTypeDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdyDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.SaveBtn);
            this.layoutControl1.Controls.Add(this.HoldyTypeDropDownList);
            this.layoutControl1.Controls.Add(this.holdyDateTimePicker);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(388, 117);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::PcdcrSystem.Properties.Resources.add_32x32;
            this.SaveBtn.Location = new System.Drawing.Point(12, 60);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(364, 45);
            this.SaveBtn.StyleController = this.layoutControl1;
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "اضافة";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // HoldyTypeDropDownList
            // 
            this.HoldyTypeDropDownList.AutoSize = false;
            radListDataItem1.Text = "طارئة";
            radListDataItem2.Text = "سنوية";
            radListDataItem3.Text = "مرضية";
            radListDataItem4.Text = "وفاة";
            radListDataItem5.Text = "زواج";
            radListDataItem6.Text = "ولادة امومة";
            radListDataItem7.Text = "اخرى";
            this.HoldyTypeDropDownList.Items.Add(radListDataItem1);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem2);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem3);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem4);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem5);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem6);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem7);
            this.HoldyTypeDropDownList.Location = new System.Drawing.Point(12, 36);
            this.HoldyTypeDropDownList.Name = "HoldyTypeDropDownList";
            this.HoldyTypeDropDownList.Size = new System.Drawing.Size(304, 20);
            this.HoldyTypeDropDownList.TabIndex = 6;
            this.HoldyTypeDropDownList.ThemeName = "Office2013Dark";
            this.HoldyTypeDropDownList.UseCompatibleTextRendering = false;
            // 
            // holdyDateTimePicker
            // 
            this.holdyDateTimePicker.AutoSize = false;
            this.holdyDateTimePicker.Culture = new System.Globalization.CultureInfo("en-UG");
            this.holdyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.holdyDateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.holdyDateTimePicker.Name = "holdyDateTimePicker";
            this.holdyDateTimePicker.Size = new System.Drawing.Size(304, 20);
            this.holdyDateTimePicker.TabIndex = 5;
            this.holdyDateTimePicker.TabStop = false;
            this.holdyDateTimePicker.Text = "15/04/2016";
            this.holdyDateTimePicker.ThemeName = "Office2013Dark";
            this.holdyDateTimePicker.Value = new System.DateTime(2016, 4, 15, 16, 42, 27, 691);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(388, 117);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.holdyDateTimePicker;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(368, 24);
            this.layoutControlItem2.Text = "تاريخ الاجازة:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.HoldyTypeDropDownList;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(368, 24);
            this.layoutControlItem3.Text = "نوع الاجازة:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.SaveBtn;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(368, 49);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // UserHoldyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 117);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 156);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 156);
            this.Name = "UserHoldyFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل اجازة";
            this.Load += new System.EventHandler(this.UserHoldyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HoldyTypeDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdyDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private Telerik.WinControls.UI.RadDropDownList HoldyTypeDropDownList;
        private Telerik.WinControls.UI.RadDateTimePicker holdyDateTimePicker;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
    }
}