using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class COE01
    {
        public string hdrWhseToID { get; set; }
        public string hdrStreet01 { get; set; }
        public string hdrStreet02 { get; set; }
        public string hdrCityStateZip { get; set; }
        public string CustPartNo { get; set; }
        public string hdrLocationID { get; set; }
        public string hdrLotID { get; set; }
        public Nullable<System.DateTime> hdrMnfctrdDate { get; set; }
        public string hdrPlantID { get; set; }
        public string hdrItemDesc { get; set; }
        public string hdrItemID { get; set; }
        public Nullable<double> hdrQuantity { get; set; }
        public string hdrWTOrder { get; set; }
        public string hdrBOL { get; set; }
        public string hdrUOM { get; set; }
        public Nullable<short> linenbr { get; set; }
    }
}
