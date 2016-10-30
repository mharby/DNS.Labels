using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using static DNS.Labels.Utilities;

namespace DNS.Labels
{
    public partial class dxPLBarcodes : DevExpress.XtraEditors.XtraForm
    {
        private readonly List<string> _CompanyList = null;
        private readonly List<string> _BarcodeTypeList = null;
        private readonly int _NextBarcodeNo = 0;
        private readonly bool _ShowBarcodeText = true;
        private readonly string _Prefix = string.Empty;
        private readonly string _BarcodeType = string.Empty;
        private const int LABELS_PER_PAGE = 40;

        public dxPLBarcodes()
        {
            InitializeComponent();

            // Read the settings file to pre-populate the controls.
            _NextBarcodeNo = Properties.Settings.Default.NextBarcodeNo;
            _BarcodeType = Properties.Settings.Default.BarcodeType;
            _ShowBarcodeText = Properties.Settings.Default.ShowBarcodeText;
            _Prefix = Properties.Settings.Default.BarcodePrefix;

            _CompanyList = BuildCompanyList(Properties.Settings.Default.CompanyList);
            _BarcodeTypeList = BuildBarcodeTypeList(Properties.Settings.Default.BarcodeTypeList);
        }
        private void dxPLBarcodes_Load(object sender, EventArgs e)
        {
            // Setup the company combobox.
            CompanyNoComboBoxEdit.Properties.Items.AddRange(_CompanyList);
            CompanyNoComboBoxEdit.SelectedIndex = 0;

            // Setup the Barcode Type (Symbology) combobox.
            BarcodeTypeComboBoxEdit.Properties.Items.AddRange(_BarcodeTypeList);
            BarcodeTypeComboBoxEdit.EditValue = _BarcodeType;

            // Setup the remaining control defaults.
            BarcodeStartNoTextEdit.EditValue = _NextBarcodeNo;
            BarcodePrefixTextEdit.EditValue = _Prefix;
            ShowBarcodeTextCheckEdit.EditValue = _ShowBarcodeText;
        }
        private void GenerateSimpleButton_Click(object sender, EventArgs e)
        {
            int ThisBarcodeNo = 0;
            try
            {
                string TheEnteredBarcodeNo = NZString(BarcodeStartNoTextEdit.EditValue, "");
                if (string.IsNullOrEmpty(TheEnteredBarcodeNo)) throw new ApplicationException("Invalid barcode entered.");

                if (!int.TryParse(TheEnteredBarcodeNo, out ThisBarcodeNo))
                {
                    throw new ApplicationException("Invalid barcode entered.");
                }
            }
            catch 
            {
                ShowMessage("You have entered an invalid start number for the Barcode.\nOnly numbers are allowed.", "Invalid Barcode");
                return;
            }

            int NoPages = NZInt(PageCountSpinEdit.Value, 1);
            bool ShowBarcodeText = ShowBarcodeTextCheckEdit.Checked;
            string Prefix = NZString(BarcodePrefixTextEdit.EditValue.ToString(), "");
            string CompanyNo = NZString(CompanyNoComboBoxEdit.EditValue.ToString(), "");
            string BarcodeType = NZString(BarcodeTypeComboBoxEdit.EditValue, "");

            if (ManualCheckEdit.Checked)
            {
                var ManualBarcodeForm = new dxPLManualBarcodes(Prefix, CompanyNo, BarcodeType, ShowBarcodeText);
                ManualBarcodeForm.Show();
                return;
            }

            List<PLBarcodeData> BarcodeList = BuildBarcodeData(Prefix, CompanyNo, ThisBarcodeNo, LABELS_PER_PAGE);
            //List<PLBarcodeData> BarcodeList = new List<PLBarcodeData>();
            //for (int i = 0; i < LABELS_PER_PAGE * NoPages; i++)
            //{
            //    BarcodeList.Add(new PLBarcodeData(Prefix, CompanyNo, ThisBarcodeNo));
            //    ThisBarcodeNo++;
            //}

            
            // Save any changes back to the settings file for next time.
            ThisBarcodeNo++;
            Properties.Settings.Default.NextBarcodeNo = ThisBarcodeNo;
            Properties.Settings.Default.BarcodePrefix = Prefix;
            Properties.Settings.Default.BarcodeType = BarcodeType;
            Properties.Settings.Default.ShowBarcodeText = ShowBarcodeText;
            Properties.Settings.Default.Save();

            var ReportLayout = new dxBarcodePrint(BarcodeType, ShowBarcodeText) { DataSource = BarcodeList };
            ReportLayout.ShowPreviewDialog();
        }
        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}