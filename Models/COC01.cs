using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class COC01
    {
        public string hdrCustPartID { get; set; }
        public string hdrCustPOID { get; set; }
        public string hdrINT { get; set; }
        public string hdrLoadID { get; set; }
        public string hdrLocationID { get; set; }
        public string hdrLotID { get; set; }
        public Nullable<System.DateTime> hdrMnfctrdDate { get; set; }
        public string hdrPlantID { get; set; }
        public string hdrProductDesc { get; set; }
        public string hdrProductID { get; set; }
        public Nullable<double> hdrQuantity { get; set; }
        public short hdrSalesDetail { get; set; }
        public string hdrSalesOrder { get; set; }
        public string hdrShipToID { get; set; }
        public string hdrUOM { get; set; }
        public string in_whs_key { get; set; }
        public string in_lot_key { get; set; }
        public string in_item_key { get; set; }
    }
}
