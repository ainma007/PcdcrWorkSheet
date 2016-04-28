namespace PcdcrSystem.Report
{
    partial class ReportEmployeeFrm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ToTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.EmpComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.FromTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.AddBtn);
            this.layoutControl1.Controls.Add(this.ToTimePicker);
            this.layoutControl1.Controls.Add(this.EmpComboBox);
            this.layoutControl1.Controls.Add(this.FromTimePicker);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(415, 114);
            this.layoutControl1.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 60);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(391, 42);
            this.AddBtn.StyleController = this.layoutControl1;
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "طباعة";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.AutoSize = false;
            this.ToTimePicker.Culture = new System.Globalization.CultureInfo("en-UG");
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToTimePicker.Location = new System.Drawing.Point(12, 36);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.Size = new System.Drawing.Size(173, 20);
            this.ToTimePicker.TabIndex = 5;
            this.ToTimePicker.TabStop = false;
            this.ToTimePicker.Text = "15/04/2016";
            this.ToTimePicker.ThemeName = "Office2013Dark";
            this.ToTimePicker.Value = new System.DateTime(2016, 4, 15, 16, 42, 27, 691);
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
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Id";
            gridViewDecimalColumn2.HeaderText = "Id";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "Id";
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "EmpName";
            gridViewTextBoxColumn3.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "EmpName";
            gridViewTextBoxColumn3.Width = 158;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "EmpNo";
            gridViewTextBoxColumn4.HeaderText = "الرقم الوظيفي";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "EmpNo";
            gridViewTextBoxColumn4.Width = 62;
            this.EmpComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.EmpComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.EmpComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.EmpComboBox.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.EmpComboBox.EditorControl.Name = "NestedRadGridView";
            this.EmpComboBox.EditorControl.ReadOnly = true;
            this.EmpComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmpComboBox.EditorControl.ShowGroupPanel = false;
            this.EmpComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.EmpComboBox.EditorControl.TabIndex = 0;
            this.EmpComboBox.Location = new System.Drawing.Point(12, 12);
            this.EmpComboBox.Name = "EmpComboBox";
            this.EmpComboBox.Size = new System.Drawing.Size(324, 20);
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
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(415, 114);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.EmpComboBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(395, 24);
            this.layoutControlItem1.Text = "اسم الموظف:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ToTimePicker;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(203, 24);
            this.layoutControlItem2.Text = "إلى:";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(21, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.AddBtn;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(395, 46);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.AutoSize = false;
            this.FromTimePicker.Culture = new System.Globalization.CultureInfo("en-UG");
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromTimePicker.Location = new System.Drawing.Point(215, 36);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.Size = new System.Drawing.Size(167, 20);
            this.FromTimePicker.TabIndex = 5;
            this.FromTimePicker.TabStop = false;
            this.FromTimePicker.Text = "15/04/2016";
            this.FromTimePicker.ThemeName = "Office2013Dark";
            this.FromTimePicker.Value = new System.DateTime(2016, 4, 15, 16, 42, 27, 691);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.FromTimePicker;
            this.layoutControlItem5.CustomizationFormText = "تاريخ الاجازة:";
            this.layoutControlItem5.Location = new System.Drawing.Point(203, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(192, 24);
            this.layoutControlItem5.Text = "من:";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(18, 13);
            this.layoutControlItem5.TextToControlDistance = 3;
            // 
            // ReportEmployeeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 114);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ReportEmployeeFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportEmployeeFrm";
            this.Load += new System.EventHandler(this.ReportEmployeeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private Telerik.WinControls.UI.RadDateTimePicker ToTimePicker;
        private Telerik.WinControls.UI.RadMultiColumnComboBox EmpComboBox;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Telerik.WinControls.UI.RadDateTimePicker FromTimePicker;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;

    }
}