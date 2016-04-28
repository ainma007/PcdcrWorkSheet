namespace PcdcrSystem.WorkFrm
{
    partial class AddWorkFrm
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.endtimeTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.startTimeTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.EmpComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            this.workTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endtimeTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.AddBtn);
            this.layoutControl1.Controls.Add(this.endtimeTimeEdit);
            this.layoutControl1.Controls.Add(this.startTimeTimeEdit);
            this.layoutControl1.Controls.Add(this.EmpComboBox);
            this.layoutControl1.Controls.Add(this.radDateTimePicker1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(396, 156);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 108);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(372, 36);
            this.AddBtn.StyleController = this.layoutControl1;
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // endtimeTimeEdit
            // 
            this.endtimeTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.workTableBindingSource, "endtime", true));
            this.endtimeTimeEdit.EditValue = new System.DateTime(2016, 4, 15, 0, 0, 0, 0);
            this.endtimeTimeEdit.Location = new System.Drawing.Point(12, 84);
            this.endtimeTimeEdit.Name = "endtimeTimeEdit";
            this.endtimeTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endtimeTimeEdit.Size = new System.Drawing.Size(295, 20);
            this.endtimeTimeEdit.StyleController = this.layoutControl1;
            this.endtimeTimeEdit.TabIndex = 8;
            // 
            // startTimeTimeEdit
            // 
            this.startTimeTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.workTableBindingSource, "endtime", true));
            this.startTimeTimeEdit.EditValue = new System.DateTime(2016, 4, 15, 0, 0, 0, 0);
            this.startTimeTimeEdit.Location = new System.Drawing.Point(12, 60);
            this.startTimeTimeEdit.Name = "startTimeTimeEdit";
            this.startTimeTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startTimeTimeEdit.Size = new System.Drawing.Size(295, 20);
            this.startTimeTimeEdit.StyleController = this.layoutControl1;
            this.startTimeTimeEdit.TabIndex = 6;
            this.startTimeTimeEdit.EditValueChanged += new System.EventHandler(this.startTimeTimeEdit_EditValueChanged);
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
            this.EmpComboBox.Size = new System.Drawing.Size(295, 20);
            this.EmpComboBox.TabIndex = 4;
            this.EmpComboBox.TabStop = false;
            this.EmpComboBox.ThemeName = "Office2013Dark";
            this.EmpComboBox.SelectedIndexChanged += new System.EventHandler(this.radMultiColumnComboBox1_SelectedIndexChanged);
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.AutoSize = false;
            this.radDateTimePicker1.Culture = new System.Globalization.CultureInfo("en-UG");
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.radDateTimePicker1.Location = new System.Drawing.Point(12, 36);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(295, 20);
            this.radDateTimePicker1.TabIndex = 5;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "15/04/2016";
            this.radDateTimePicker1.ThemeName = "Office2013Dark";
            this.radDateTimePicker1.Value = new System.DateTime(2016, 4, 15, 16, 42, 27, 691);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(396, 156);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.EmpComboBox;
            this.layoutControlItem1.CustomizationFormText = "اسم الموظف:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem1.Text = "اسم الموظف:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.startTimeTimeEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem3.Text = "ساعة الحضور";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.radDateTimePicker1;
            this.layoutControlItem2.CustomizationFormText = "تاريخ الاجازة:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem2.Text = "تاريخ الاجازة:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.endtimeTimeEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem5.Text = "ساعة الانصراف:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.AddBtn;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(376, 40);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // workTableBindingSource
            // 
            this.workTableBindingSource.DataSource = typeof(PcdcrData.WorkTable);
            // 
            // AddWorkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 156);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddWorkFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة دوام";
            this.Load += new System.EventHandler(this.AddWorkFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.endtimeTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox EmpComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TimeEdit startTimeTimeEdit;
        private System.Windows.Forms.BindingSource workTableBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private DevExpress.XtraEditors.TimeEdit endtimeTimeEdit;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
    }
}