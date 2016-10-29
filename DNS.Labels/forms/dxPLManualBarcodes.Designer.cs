namespace DNS.Labels
{
    partial class dxPLManualBarcodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNS.Labels.dxPLManualBarcodes));
            this.GenerateSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.LabelsGridControl = new DevExpress.XtraGrid.GridControl();
            this.LabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BarcodePrefixTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CompanyNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.LabelsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePrefixTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNoTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateSimpleButton
            // 
            this.GenerateSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateSimpleButton.Location = new System.Drawing.Point(407, 316);
            this.GenerateSimpleButton.Margin = new System.Windows.Forms.Padding(12, 12, 6, 12);
            this.GenerateSimpleButton.Name = "GenerateSimpleButton";
            this.GenerateSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateSimpleButton.TabIndex = 0;
            this.GenerateSimpleButton.Text = "Generate";
            this.GenerateSimpleButton.Click += new System.EventHandler(this.GenerateSimpleButton_Click);
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Location = new System.Drawing.Point(494, 316);
            this.CancelSimpleButton.Margin = new System.Windows.Forms.Padding(6, 12, 12, 12);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.CancelSimpleButton.TabIndex = 1;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // LabelsGridControl
            // 
            this.LabelsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelsGridControl.DataSource = this.LabelBindingSource;
            this.LabelsGridControl.Location = new System.Drawing.Point(21, 21);
            this.LabelsGridControl.MainView = this.LabelsGridView;
            this.LabelsGridControl.Margin = new System.Windows.Forms.Padding(12);
            this.LabelsGridControl.Name = "LabelsGridControl";
            this.LabelsGridControl.Size = new System.Drawing.Size(548, 271);
            this.LabelsGridControl.TabIndex = 2;
            this.LabelsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LabelsGridView});
            // 
            // LabelsGridView
            // 
            this.LabelsGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelsGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.LabelsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colColumn1,
            this.colColumn2,
            this.colColumn3,
            this.colColumn4});
            this.LabelsGridView.GridControl = this.LabelsGridControl;
            this.LabelsGridView.Name = "LabelsGridView";
            this.LabelsGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.LabelsGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.LabelsGridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.LabelsGridView.OptionsView.ShowColumnHeaders = false;
            this.LabelsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colColumn1
            // 
            this.colColumn1.Caption = "gridColumn1";
            this.colColumn1.FieldName = "Column1";
            this.colColumn1.Name = "colColumn1";
            this.colColumn1.Visible = true;
            this.colColumn1.VisibleIndex = 0;
            // 
            // colColumn2
            // 
            this.colColumn2.Caption = "gridColumn2";
            this.colColumn2.FieldName = "Column2";
            this.colColumn2.Name = "colColumn2";
            this.colColumn2.Visible = true;
            this.colColumn2.VisibleIndex = 1;
            // 
            // colColumn3
            // 
            this.colColumn3.Caption = "gridColumn3";
            this.colColumn3.FieldName = "Column3";
            this.colColumn3.Name = "colColumn3";
            this.colColumn3.Visible = true;
            this.colColumn3.VisibleIndex = 2;
            // 
            // colColumn4
            // 
            this.colColumn4.Caption = "gridColumn4";
            this.colColumn4.FieldName = "Column4";
            this.colColumn4.Name = "colColumn4";
            this.colColumn4.Visible = true;
            this.colColumn4.VisibleIndex = 3;
            // 
            // BarcodePrefixTextEdit
            // 
            this.BarcodePrefixTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BarcodePrefixTextEdit.Location = new System.Drawing.Point(101, 318);
            this.BarcodePrefixTextEdit.Name = "BarcodePrefixTextEdit";
            this.BarcodePrefixTextEdit.Size = new System.Drawing.Size(60, 20);
            this.BarcodePrefixTextEdit.TabIndex = 3;
            // 
            // CompanyNoTextEdit
            // 
            this.CompanyNoTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CompanyNoTextEdit.Location = new System.Drawing.Point(259, 318);
            this.CompanyNoTextEdit.Name = "CompanyNoTextEdit";
            this.CompanyNoTextEdit.Size = new System.Drawing.Size(60, 20);
            this.CompanyNoTextEdit.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Location = new System.Drawing.Point(21, 321);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Barcode Prefix:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Location = new System.Drawing.Point(184, 321);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Company No.:";
            // 
            // dxPLManualBarcodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 360);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.CompanyNoTextEdit);
            this.Controls.Add(this.BarcodePrefixTextEdit);
            this.Controls.Add(this.LabelsGridControl);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.GenerateSimpleButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dxPLManualBarcodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Barcode Entry";
            this.Load += new System.EventHandler(this.dxPLManualBarcodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LabelsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePrefixTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNoTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton GenerateSimpleButton;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraGrid.GridControl LabelsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView LabelsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn4;
        private System.Windows.Forms.BindingSource LabelBindingSource;
        private DevExpress.XtraEditors.TextEdit BarcodePrefixTextEdit;
        private DevExpress.XtraEditors.TextEdit CompanyNoTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}