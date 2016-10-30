using DevExpress.XtraBars;
namespace DNS.Labels
{
    public partial class dxMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public dxMainForm()
        {
            InitializeComponent();
        }

        private void PLBarcodesBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var BarcodeForm = new dxPLBarcodes();
            BarcodeForm.Show();
        }
        private void ManualBarcodesBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var BarcodeForm = new dxPLManualBarcodes();
            BarcodeForm.Show();
        }

        private void SettingsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var SettingsForm = new dxSettings();
            SettingsForm.Show();
        }

        private void AboutBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var AboutForm = new dxAbout();
            AboutForm.Show();
        }

        private void ExitBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

    }
}