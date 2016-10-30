namespace DNS.Labels
{
    public class PLBarcodeData
    {
        public string BarcodeData { get; set; }
        public string TextData { get; set; }

        public PLBarcodeData(string BarcodeData)
        {
            if (string.IsNullOrEmpty(BarcodeData))
            {
                this.BarcodeData = "";
                this.TextData = "";
            }
            else
            {
                this.BarcodeData = string.Format("PL{0}", BarcodeData);
                this.TextData = string.Format("PL {0}", BarcodeData);
            }
        }
        public PLBarcodeData(string Prefix, string BarcodeData)
        {
            if (string.IsNullOrEmpty(BarcodeData))
            {
                this.BarcodeData = "";
                this.TextData = "";
            }
            else
            {
                this.BarcodeData = string.Format("{0}{1}",Prefix, BarcodeData);
                this.TextData = string.Format("{0}{1}", Prefix, BarcodeData);
            }
        }
        public PLBarcodeData(string CompanyNo, int BarcodeNo)
        {
            this.BarcodeData = string.Format("PL{0}{1:000000}", CompanyNo, BarcodeNo);
            this.TextData = string.Format("PL {0} {1:000000}", CompanyNo, BarcodeNo);
        }
        public PLBarcodeData(string Prefix, string CompanyNo, int BarcodeNo)
        {
            this.BarcodeData = string.Format("{0}{1}{2:000000}", Prefix, CompanyNo, BarcodeNo);
            this.TextData = string.Format("{0} {1} {2:000000}", Prefix, CompanyNo, BarcodeNo);
        }
        public PLBarcodeData(string Prefix, string CompanyNo, string BarcodeData)
        {
            if (string.IsNullOrEmpty(BarcodeData))
            {
                this.BarcodeData = "";
                this.TextData = "";
            }
            else
            {
                this.BarcodeData = string.Format("{0}{1}{2}", Prefix, CompanyNo, BarcodeData);
                this.TextData = string.Format("{0} {1} {2}", Prefix, CompanyNo, BarcodeData);
            }
        }
    }
}
