using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

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
            string BarcodePrefix = Utilities.NZString(BarcodePrefixTextEdit.EditValue, "");
            string CompanyNo = Utilities.NZString(CompanyNoTextEdit.EditValue, "");

            var ReportLayout = new dxBarcodePrint(_BarcodeType, _ShowBarcodeText);
            ReportLayout.DataSource = BuildBarcodeData( BarcodePrefix, CompanyNo, _BarcodeList, _ROWCOUNT);
            ReportLayout.ShowPreviewDialog();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static List<PLManualBarcode> BuildEmptyBarcodeList(int RowCount)
        {
            List<PLManualBarcode> BarcodeList = new List<PLManualBarcode>(RowCount);
            for (int i = 0; i < RowCount; i++)
            {
                BarcodeList.Add(new PLManualBarcode("", "", "", ""));
            }
            return BarcodeList;
        }

        private static List<PLBarcodeData> BuildBarcodeData(string BarcodePrefix, string CompanyNo, List<PLManualBarcode> ManualBarcodeData, int RowCount)
        {
            List<PLBarcodeData> BarcodeData = new List<PLBarcodeData>();
            for (int i = 0; i < RowCount; i++)
            {
                BarcodeData.Add(new PLBarcodeData(BarcodePrefix, CompanyNo, ManualBarcodeData[i].Column1));
                BarcodeData.Add(new PLBarcodeData(BarcodePrefix, CompanyNo, ManualBarcodeData[i].Column2));
                BarcodeData.Add(new PLBarcodeData(BarcodePrefix, CompanyNo, ManualBarcodeData[i].Column3));
                BarcodeData.Add(new PLBarcodeData(BarcodePrefix, CompanyNo, ManualBarcodeData[i].Column4));
            }
            return BarcodeData;
        }

    }
}