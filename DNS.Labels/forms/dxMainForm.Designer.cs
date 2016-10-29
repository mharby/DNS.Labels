namespace DNS.Labels
{
    partial class dxMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxMainForm));
            this.MainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.PLBarcodesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.NLCoversheetBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.PLCoversheetBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SettingsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.AboutBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.MainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.MainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CoversheetsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ToolsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.MainRibbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.MainDefaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ExitBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbon)).BeginInit();
            this.SuspendLayout();
            // 
            // MainRibbon
            // 
            this.MainRibbon.ExpandCollapseItem.Id = 0;
            this.MainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MainRibbon.ExpandCollapseItem,
            this.PLBarcodesBarButtonItem,
            this.NLCoversheetBarButtonItem,
            this.PLCoversheetBarButtonItem,
            this.SettingsBarButtonItem,
            this.AboutBarButtonItem,
            this.ExitBarButtonItem});
            this.MainRibbon.Location = new System.Drawing.Point(0, 0);
            this.MainRibbon.MaxItemId = 7;
            this.MainRibbon.Name = "MainRibbon";
            this.MainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.MainRibbonPage});
            this.MainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.MainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.MainRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.MainRibbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.MainRibbon.ShowToolbarCustomizeItem = false;
            this.MainRibbon.Size = new System.Drawing.Size(941, 147);
            this.MainRibbon.StatusBar = this.MainRibbonStatusBar;
            this.MainRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // PLBarcodesBarButtonItem
            // 
            this.PLBarcodesBarButtonItem.Caption = "Purchase Ledger Barcodes";
            this.PLBarcodesBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("PLBarcodesBarButtonItem.Glyph")));
            this.PLBarcodesBarButtonItem.Id = 1;
            this.PLBarcodesBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("PLBarcodesBarButtonItem.LargeGlyph")));
            this.PLBarcodesBarButtonItem.Name = "PLBarcodesBarButtonItem";
            this.PLBarcodesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PLBarcodesBarButtonItem_ItemClick);
            // 
            // NLCoversheetBarButtonItem
            // 
            this.NLCoversheetBarButtonItem.Caption = "Nominal Ledger Coversheet";
            this.NLCoversheetBarButtonItem.Enabled = false;
            this.NLCoversheetBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("NLCoversheetBarButtonItem.Glyph")));
            this.NLCoversheetBarButtonItem.Id = 2;
            this.NLCoversheetBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("NLCoversheetBarButtonItem.LargeGlyph")));
            this.NLCoversheetBarButtonItem.Name = "NLCoversheetBarButtonItem";
            // 
            // PLCoversheetBarButtonItem
            // 
            this.PLCoversheetBarButtonItem.Caption = "Purchase Ledger Coversheet";
            this.PLCoversheetBarButtonItem.Enabled = false;
            this.PLCoversheetBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("PLCoversheetBarButtonItem.Glyph")));
            this.PLCoversheetBarButtonItem.Id = 3;
            this.PLCoversheetBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("PLCoversheetBarButtonItem.LargeGlyph")));
            this.PLCoversheetBarButtonItem.Name = "PLCoversheetBarButtonItem";
            // 
            // SettingsBarButtonItem
            // 
            this.SettingsBarButtonItem.Caption = "Settings";
            this.SettingsBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("SettingsBarButtonItem.Glyph")));
            this.SettingsBarButtonItem.Id = 4;
            this.SettingsBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("SettingsBarButtonItem.LargeGlyph")));
            this.SettingsBarButtonItem.Name = "SettingsBarButtonItem";
            this.SettingsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SettingsBarButtonItem_ItemClick);
            // 
            // AboutBarButtonItem
            // 
            this.AboutBarButtonItem.Caption = "About";
            this.AboutBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("AboutBarButtonItem.Glyph")));
            this.AboutBarButtonItem.Id = 5;
            this.AboutBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AboutBarButtonItem.LargeGlyph")));
            this.AboutBarButtonItem.Name = "AboutBarButtonItem";
            this.AboutBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AboutBarButtonItem_ItemClick);
            // 
            // MainRibbonPage
            // 
            this.MainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.MainRibbonPageGroup,
            this.CoversheetsRibbonPageGroup,
            this.ToolsRibbonPageGroup});
            this.MainRibbonPage.Name = "MainRibbonPage";
            this.MainRibbonPage.Text = "Barcodes";
            // 
            // MainRibbonPageGroup
            // 
            this.MainRibbonPageGroup.ItemLinks.Add(this.PLBarcodesBarButtonItem);
            this.MainRibbonPageGroup.Name = "MainRibbonPageGroup";
            this.MainRibbonPageGroup.Text = "Barcodes";
            // 
            // CoversheetsRibbonPageGroup
            // 
            this.CoversheetsRibbonPageGroup.ItemLinks.Add(this.PLCoversheetBarButtonItem);
            this.CoversheetsRibbonPageGroup.ItemLinks.Add(this.NLCoversheetBarButtonItem);
            this.CoversheetsRibbonPageGroup.Name = "CoversheetsRibbonPageGroup";
            this.CoversheetsRibbonPageGroup.Text = "Coversheets";
            // 
            // ToolsRibbonPageGroup
            // 
            this.ToolsRibbonPageGroup.ItemLinks.Add(this.SettingsBarButtonItem);
            this.ToolsRibbonPageGroup.ItemLinks.Add(this.AboutBarButtonItem);
            this.ToolsRibbonPageGroup.ItemLinks.Add(this.ExitBarButtonItem);
            this.ToolsRibbonPageGroup.Name = "ToolsRibbonPageGroup";
            this.ToolsRibbonPageGroup.Text = "Tools";
            // 
            // MainRibbonStatusBar
            // 
            this.MainRibbonStatusBar.Location = new System.Drawing.Point(0, 593);
            this.MainRibbonStatusBar.Name = "MainRibbonStatusBar";
            this.MainRibbonStatusBar.Ribbon = this.MainRibbon;
            this.MainRibbonStatusBar.Size = new System.Drawing.Size(941, 23);
            // 
            // MainDefaultLookAndFeel
            // 
            this.MainDefaultLookAndFeel.LookAndFeel.SkinName = "Office 2013";
            // 
            // ExitBarButtonItem
            // 
            this.ExitBarButtonItem.Caption = "Exit";
            this.ExitBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ExitBarButtonItem.Glyph")));
            this.ExitBarButtonItem.Id = 6;
            this.ExitBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ExitBarButtonItem.LargeGlyph")));
            this.ExitBarButtonItem.Name = "ExitBarButtonItem";
            this.ExitBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitBarButtonItem_ItemClick);
            // 
            // dxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 616);
            this.Controls.Add(this.MainRibbonStatusBar);
            this.Controls.Add(this.MainRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dxMainForm";
            this.Ribbon = this.MainRibbon;
            this.StatusBar = this.MainRibbonStatusBar;
            this.Text = "DNS Barcode and Coversheet Generator";
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl MainRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage MainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup MainRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar MainRibbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem PLBarcodesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem NLCoversheetBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem PLCoversheetBarButtonItem;
        private DevExpress.LookAndFeel.DefaultLookAndFeel MainDefaultLookAndFeel;
        private DevExpress.XtraBars.BarButtonItem SettingsBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem AboutBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CoversheetsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ToolsRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem ExitBarButtonItem;
    }
}