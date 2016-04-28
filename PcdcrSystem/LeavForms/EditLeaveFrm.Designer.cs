namespace PcdcrSystem.LeavForms
{
    partial class EditLeaveFrm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.LeaveDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.backTimeTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.leaveTimeTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.EmpComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backTimeTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTimeTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.LeaveDateTimePicker);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.radDropDownList1);
            this.layoutControl1.Controls.Add(this.backTimeTimeEdit);
            this.layoutControl1.Controls.Add(this.leaveTimeTimeEdit);
            this.layoutControl1.Controls.Add(this.EmpComboBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(344, 189);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // LeaveDateTimePicker
            // 
            this.LeaveDateTimePicker.AutoSize = false;
            this.LeaveDateTimePicker.Culture = new System.Globalization.CultureInfo("en-UG");
            this.LeaveDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LeaveDateTimePicker.Location = new System.Drawing.Point(12, 36);
            this.LeaveDateTimePicker.Name = "LeaveDateTimePicker";
            this.LeaveDateTimePicker.Size = new System.Drawing.Size(253, 20);
            this.LeaveDateTimePicker.TabIndex = 6;
            this.LeaveDateTimePicker.TabStop = false;
            this.LeaveDateTimePicker.Text = "15/04/2016";
            this.LeaveDateTimePicker.ThemeName = "Office2013Dark";
            this.LeaveDateTimePicker.Value = new System.DateTime(2016, 4, 15, 16, 42, 27, 691);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 134);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(320, 43);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "تعديل";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.AutoSize = false;
            radListDataItem1.Text = "عمل ميداني";
            radListDataItem2.Text = "خاص";
            this.radDropDownList1.Items.Add(radListDataItem1);
            this.radDropDownList1.Items.Add(radListDataItem2);
            this.radDropDownList1.Location = new System.Drawing.Point(12, 108);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(253, 22);
            this.radDropDownList1.TabIndex = 9;
            this.radDropDownList1.ThemeName = "Office2013Dark";
            // 
            // backTimeTimeEdit
            // 
            this.backTimeTimeEdit.EditValue = new System.DateTime(2016, 4, 23, 0, 0, 0, 0);
            this.backTimeTimeEdit.Location = new System.Drawing.Point(12, 84);
            this.backTimeTimeEdit.Name = "backTimeTimeEdit";
            this.backTimeTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.backTimeTimeEdit.Size = new System.Drawing.Size(253, 20);
            this.backTimeTimeEdit.StyleController = this.layoutControl1;
            this.backTimeTimeEdit.TabIndex = 8;
            // 
            // leaveTimeTimeEdit
            // 
            this.leaveTimeTimeEdit.EditValue = new System.DateTime(2016, 4, 23, 0, 0, 0, 0);
            this.leaveTimeTimeEdit.Location = new System.Drawing.Point(12, 60);
            this.leaveTimeTimeEdit.Name = "leaveTimeTimeEdit";
            this.leaveTimeTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leaveTimeTimeEdit.Size = new System.Drawing.Size(253, 20);
            this.leaveTimeTimeEdit.StyleController = this.layoutControl1;
            this.leaveTimeTimeEdit.TabIndex = 7;
            // 
            // EmpComboBox
            // 
            this.EmpComboBox.AutoScroll = true;
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
            gridViewDecimalColumn5.DataType = typeof(int);
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "Id";
            gridViewDecimalColumn5.HeaderText = "Id";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.IsVisible = false;
            gridViewDecimalColumn5.Name = "Id";
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "EmpName";
            gridViewTextBoxColumn9.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "EmpName";
            gridViewTextBoxColumn9.Width = 158;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "EmpNo";
            gridViewTextBoxColumn10.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "EmpNo";
            gridViewTextBoxColumn10.Width = 62;
            this.EmpComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn5,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10});
            this.EmpComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.EmpComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.EmpComboBox.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.EmpComboBox.EditorControl.Name = "NestedRadGridView";
            this.EmpComboBox.EditorControl.ReadOnly = true;
            this.EmpComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmpComboBox.EditorControl.ShowGroupPanel = false;
            this.EmpComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.EmpComboBox.EditorControl.TabIndex = 0;
            this.EmpComboBox.Location = new System.Drawing.Point(12, 12);
            this.EmpComboBox.Name = "EmpComboBox";
            this.EmpComboBox.Size = new System.Drawing.Size(253, 20);
            this.EmpComboBox.TabIndex = 5;
            this.EmpComboBox.TabStop = false;
            this.EmpComboBox.ThemeName = "Office2013Dark";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(344, 189);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.EmpComboBox;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(324, 24);
            this.layoutControlItem2.Text = "اسم الموظف:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.leaveTimeTimeEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(324, 24);
            this.layoutControlItem4.Text = "ساعة الخروج:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.backTimeTimeEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(324, 24);
            this.layoutControlItem5.Text = "ساعة الرجوع:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radDropDownList1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(324, 26);
            this.layoutControlItem1.Text = "نوع الخروج:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(324, 47);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.LeaveDateTimePicker;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(324, 24);
            this.layoutControlItem3.Text = "تاريخ الخروج:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 13);
            // 
            // EditLeaveFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 189);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 228);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 228);
            this.Name = "EditLeaveFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل خروج";
            this.Load += new System.EventHandler(this.EditLeaveFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeaveDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backTimeTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTimeTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private Telerik.WinControls.UI.RadDateTimePicker LeaveDateTimePicker;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private DevExpress.XtraEditors.TimeEdit backTimeTimeEdit;
        private DevExpress.XtraEditors.TimeEdit leaveTimeTimeEdit;
        private Telerik.WinControls.UI.RadMultiColumnComboBox EmpComboBox;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
    }
}