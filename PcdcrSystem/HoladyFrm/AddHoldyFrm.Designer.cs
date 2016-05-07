namespace PcdcrSystem.HoladyFrm
{
    partial class AddHoldyFrm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.HoldyTypeDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.holdyDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.EmpComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoldyTypeDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdyDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.HoldyTypeDropDownList);
            this.layoutControl1.Controls.Add(this.AddBtn);
            this.layoutControl1.Controls.Add(this.holdyDateTimePicker);
            this.layoutControl1.Controls.Add(this.EmpComboBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(394, 137);
            this.layoutControl1.TabIndex = 0;
            // 
            // HoldyTypeDropDownList
            // 
            this.HoldyTypeDropDownList.AutoSize = false;
            radListDataItem1.Text = "طارئة";
            radListDataItem2.Text = "سنوية";
            radListDataItem3.Text = "مرضية";
            radListDataItem4.Text = "ولادة امومة";
            radListDataItem5.Text = "وفاة";
            radListDataItem6.Text = "زواج";
            radListDataItem7.Text = "اخرى";
            this.HoldyTypeDropDownList.Items.Add(radListDataItem1);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem2);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem3);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem4);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem5);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem6);
            this.HoldyTypeDropDownList.Items.Add(radListDataItem7);
            this.HoldyTypeDropDownList.Location = new System.Drawing.Point(12, 60);
            this.HoldyTypeDropDownList.Name = "HoldyTypeDropDownList";
            this.HoldyTypeDropDownList.Size = new System.Drawing.Size(303, 20);
            this.HoldyTypeDropDownList.TabIndex = 8;
            this.HoldyTypeDropDownList.ThemeName = "Office2013Dark";
            this.HoldyTypeDropDownList.UseCompatibleTextRendering = false;
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::PcdcrSystem.Properties.Resources.add_32x32;
            this.AddBtn.Location = new System.Drawing.Point(12, 84);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(370, 41);
            this.AddBtn.StyleController = this.layoutControl1;
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // holdyDateTimePicker
            // 
            this.holdyDateTimePicker.AutoSize = false;
            this.holdyDateTimePicker.Culture = new System.Globalization.CultureInfo("en-UG");
            this.holdyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.holdyDateTimePicker.Location = new System.Drawing.Point(12, 36);
            this.holdyDateTimePicker.Name = "holdyDateTimePicker";
            this.holdyDateTimePicker.Size = new System.Drawing.Size(303, 20);
            this.holdyDateTimePicker.TabIndex = 5;
            this.holdyDateTimePicker.TabStop = false;
            this.holdyDateTimePicker.Text = "15/04/2016";
            this.holdyDateTimePicker.ThemeName = "Office2013Dark";
            this.holdyDateTimePicker.Value = new System.DateTime(2016, 4, 15, 16, 42, 27, 691);
            // 
            // EmpComboBox
            // 
            this.EmpComboBox.DisplayMember = "EmpName";
            // 
            // EmpComboBox.NestedRadGridView
            // 
            this.EmpComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.EmpComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmpComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.EmpComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmpComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmpComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.EmpComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.EmpComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.EmpComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.EmpComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.EmpComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Id";
            gridViewDecimalColumn1.HeaderText = "Id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "Id";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "EmpName";
            gridViewTextBoxColumn1.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "EmpName";
            gridViewTextBoxColumn1.Width = 158;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "EmpNo";
            gridViewTextBoxColumn2.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "EmpNo";
            gridViewTextBoxColumn2.Width = 62;
            this.EmpComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.EmpComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.EmpComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.EmpComboBox.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.EmpComboBox.EditorControl.Name = "NestedRadGridView";
            this.EmpComboBox.EditorControl.ReadOnly = true;
            this.EmpComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmpComboBox.EditorControl.ShowGroupPanel = false;
            this.EmpComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.EmpComboBox.EditorControl.TabIndex = 0;
            this.EmpComboBox.Location = new System.Drawing.Point(12, 12);
            this.EmpComboBox.Name = "EmpComboBox";
            this.EmpComboBox.Size = new System.Drawing.Size(303, 20);
            this.EmpComboBox.TabIndex = 4;
            this.EmpComboBox.TabStop = false;
            this.EmpComboBox.ThemeName = "Office2013Dark";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(394, 137);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.EmpComboBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem1.Text = "اسم الموظف:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.holdyDateTimePicker;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem2.Text = "تاريخ الاجازة:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.AddBtn;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(374, 45);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.HoldyTypeDropDownList;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem3.Text = "نوع الاجازة:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 13);
            // 
            // AddHoldyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 137);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 176);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 176);
            this.Name = "AddHoldyFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة اجازة";
            this.Load += new System.EventHandler(this.AddHoldyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HoldyTypeDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdyDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox EmpComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private Telerik.WinControls.UI.RadDateTimePicker holdyDateTimePicker;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Telerik.WinControls.UI.RadDropDownList HoldyTypeDropDownList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}