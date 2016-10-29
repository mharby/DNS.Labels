using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DNS.Labels
{
    public partial class dxBarcodePrint : DevExpress.XtraReports.UI.XtraReport
    {
        private string BarcodeType { get; set; }
        private bool ShowBarcodeText { get; set; }

        public dxBarcodePrint()
        {
            InitializeComponent();
            this.BarcodeType = "Code 39";
            this.ShowBarcodeText = true;
        }
        public dxBarcodePrint(string BarcodeType, bool ShowBarcodeText)
        {
            InitializeComponent();
            this.BarcodeType = BarcodeType;
            this.ShowBarcodeText = ShowBarcodeText;
        }

        private void MainXRBarCode_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string BarcodeData = this.GetCurrentColumnValue("BarcodeData").ToString();
            if (string.IsNullOrEmpty(BarcodeData))
                MainXRBarCode.ForeColor = Color.White;
            else
            {
                MainXRBarCode.ForeColor = Color.Black;
            }
        }

        private void dxBarcodePrint_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.BarcodeType == "Code 39")
            {
                DevExpress.XtraPrinting.BarCode.Code39Generator code39Generator = new DevExpress.XtraPrinting.BarCode.Code39Generator();
                code39Generator.CalcCheckSum = false;
                this.MainXRBarCode.Symbology = code39Generator;
                this.MainXRBarCode.ShowText = ShowBarcodeText;
                
                return;
            }

            if (this.BarcodeType == "Code 128")
            {
                DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator = new DevExpress.XtraPrinting.BarCode.Code128Generator();
                this.MainXRBarCode.Symbology = code128Generator;
                this.MainXRBarCode.ShowText = ShowBarcodeText;
                return;
            }

            if (this.BarcodeType == "QRCode")
            {
                DevExpress.XtraPrinting.BarCode.QRCodeGenerator codeQRGenerator = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
                this.MainXRBarCode.Symbology = codeQRGenerator;
                this.MainXRBarCode.ShowText = ShowBarcodeText;
                return;
            }
        }

    }
}
