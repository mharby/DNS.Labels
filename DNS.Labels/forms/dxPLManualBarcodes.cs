using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using static DNS.Labels.Utilities;

namespace DNS.Labels
{
    public partial class dxPLManualBarcodes : DevExpress.XtraEditors.XtraForm
    {
        private const int _ROWCOUNT = 10;
        private readonly bool _ShowBarcodeText = false;
        private readonly string _BarcodeType = string.Empty;
        private readonly string _BarcodePrefix = string.Empty;
        private readonly string _CompanyNo = string.Empty;
        private List<PLManualBarcode> _BarcodeList = new List<PLManualBarcode>(_ROWCOUNT);

        public dxPLManualBarcodes()
        {
            InitializeComponent();
        }
        public dxPLManualBarcodes(string Prefix, string CompanyNo, string BarcodeType, bool ShowBarcodeText)
        {
            InitializeComponent();

            _BarcodeType = BarcodeType;
            _ShowBarcodeText = ShowBarcodeText;
            _BarcodePrefix = Prefix;
            _CompanyNo = CompanyNo;
        }

        private void dxPLManualBarcodes_Load(object sender, EventArgs e)
        {
            // Connect the grid to the string list.
            _BarcodeList = BuildEmptyBarcodeList(_ROWCOUNT);
            LabelBindingSource.DataSource = _BarcodeList;

            // Setup defaults
            BarcodePrefixTextEdit.EditValue = _BarcodePrefix;
            CompanyNoTextEdit.EditValue = _CompanyNo;
        }

        private void GenerateSimpleButton_Click(object sender, EventArgs e)
        {
            string BarcodePrefix = NZString(BarcodePrefixTextEdit.EditValue, "");
            string CompanyNo = NZString(CompanyNoTextEdit.EditValue, "");

            var ReportLayout = new dxBarcodePrint(_BarcodeType, _ShowBarcodeText) { DataSource = BuildBarcodeData(BarcodePrefix, CompanyNo, _BarcodeList, _ROWCOUNT) };
            ReportLayout.ShowPreviewDialog();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}