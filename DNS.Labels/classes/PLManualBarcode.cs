using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS.Labels
{
    public class PLManualBarcode
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }

        public PLManualBarcode(string Column1, string Column2, string Column3, string Column4)
        {
            this.Column1 = Column1;
            this.Column2 = Column2;
            this.Column3 = Column3;
            this.Column4 = Column4;
        }
    }
}
