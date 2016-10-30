using System;
using System.Linq;
using System.Collections.Generic;

namespace DNS.Labels
{
    public static class Utilities
    {
        public static List<string> BuildCompanyList(string ListOfCompanies)
        {
            return ListOfCompanies.Split(',').ToList();
        }
        public static List<string> BuildBarcodeTypeList(string ListOfBarcodeTypes)
        {
            return ListOfBarcodeTypes.Split(',').ToList();
        }
        public static List<PLManualBarcode> BuildEmptyBarcodeList(int RowCount)
        {
            List<PLManualBarcode> BarcodeList = new List<PLManualBarcode>(RowCount);
            for (int i = 0; i < RowCount; i++)
            {
                BarcodeList.Add(new PLManualBarcode("", "", "", ""));
            }
            return BarcodeList;
        }

        public static List<PLBarcodeData> BuildBarcodeData(string BarcodePrefix, string CompanyNo, List<PLManualBarcode> ManualBarcodeData, int RowCount)
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

        public static void ShowMessage(string MessageText, string MessageTitle)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(MessageText, MessageTitle);
        }
        public static string NZString(object Data, string DefaultValue = "")
        {
            string ReturnValue = DefaultValue;
            if (Data != null) ReturnValue = Convert.ToString(Data);

            return ReturnValue;
        }
        public static int NZInt(object Data, int DefaultValue = 0)
        {
            int ReturnValue = DefaultValue;
            if (Data != null) ReturnValue = Convert.ToInt32(Data);

            return ReturnValue;
        }
    }
}
