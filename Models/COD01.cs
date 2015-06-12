using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class COD01
    {
        public string gl_cmp_key { get; set; }
        public string in_wthdr_remk { get; set; }
        public string hdrWhseToID { get; set; }
        public string hdrStreet01 { get; set; }
        public string hdrStreet02 { get; set; }
        public string hdrCityStateZip { get; set; }
        public string CustPartNo { get; set; }
        public string hdrLocationID { get; set; }
        public string hdrLotID { get; set; }
        public Nullable<System.DateTime> hdrMnfctrdDate { get; set; }
        public string hdrPlantID { get; set; }
        public Nullable<int> hdrStatus { get; set; }
        public string hdrItemDesc { get; set; }
        public string hdrItemID { get; set; }
        public Nullable<double> hdrQuantity { get; set; }
        public string hdrWTOrder { get; set; }
        public string hdrBOL { get; set; }
        public string hdrUOM { get; set; }
        public Nullable<short> line { get; set; }
        public string CustomerCode { get; set; }
    }
}
