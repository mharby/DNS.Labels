using System;
using static DNS.Labels.Utilities;

namespace DNS.Labels
{
    public partial class dxSettings : DevExpress.XtraEditors.XtraForm
    {
        public dxSettings()
        {
            InitializeComponent();
        }

        private void dxSettings_Load(object sender, EventArgs e)
        {
            CompanyListTextEdit.EditValue = Properties.Settings.Default.CompanyList;
            NextBarcodeNoTextEdit.EditValue = Properties.Settings.Default.NextBarcodeNo;
            BarcodePrefixTextEdit.EditValue = Properties.Settings.Default.BarcodePrefix;
            ShowBarcodeTextCheckEdit.Checked = Properties.Settings.Default.ShowBarcodeText;
            BarcodeTypeListTextEdit.EditValue = Properties.Settings.Default.BarcodeTypeList;
            SelectedBarcodeTypeTextEdit.EditValue = Properties.Settings.Default.BarcodeType;
        }
        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the controls.
                int NextBarcodeNo = NZInt(NextBarcodeNoTextEdit.EditValue, 1);
                bool ShowBarcodeText = ShowBarcodeTextCheckEdit.Checked;
                string BarcodePrefix = NZString(BarcodePrefixTextEdit.EditValue.ToString(), "");
                string CompanyList = NZString(CompanyListTextEdit.EditValue, "");
                string BarcodeTypeList = NZString(BarcodeTypeListTextEdit.EditValue, "");
                string SelectedBarcodeType = NZString(SelectedBarcodeTypeTextEdit.EditValue, "");

                // Save any changes back to the settings file for next time.
                Properties.Settings.Default.CompanyList = CompanyList;
                Properties.Settings.Default.BarcodeTypeList = BarcodeTypeList;
                Properties.Settings.Default.NextBarcodeNo = NextBarcodeNo;
                Properties.Settings.Default.BarcodePrefix = BarcodePrefix;
                Properties.Settings.Default.BarcodeType = SelectedBarcodeType;
                Properties.Settings.Default.ShowBarcodeText = ShowBarcodeText;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                ShowMessage(string.Format("An error occurred while trying to update the settings.{0}{1}", Environment.NewLine, ex.Message), "ERROR");
            }
            Close();
        }
        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}