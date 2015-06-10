using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class COA01
    {
        public string hdrBillToID { get; set; }
        public string hdrStreet01 { get; set; }
        public string hdrStreet02 { get; set; }
        public string hdrStreet03 { get; set; }
        public string hdrCityStateZip { get; set; }
        public string hdrCustBillShip { get; set; }
        public string hdrCustomerID { get; set; }
        public string hdrCustomerName { get; set; }
        public string hdrCustPartID { get; set; }
        public string hdrCustPOID { get; set; }
        public string hdrINT { get; set; }
        public string hdrLocationID { get; set; }
        public string hdrLotID { get; set; }
        public Nullable<System.DateTime> hdrMnfctrdDate { get; set; }
        public string hdrPlantID { get; set; }
        public string hdrProductDesc { get; set; }
        public string hdrProductID { get; set; }
        public string hdrItemID { get; set; }
        public Nullable<double> hdrQuantity { get; set; }
        public string hdrSalesOrder { get; set; }
        public short hdrDtlLine { get; set; }
        public string hdrBOL { get; set; }
        public string hdrShipToID { get; set; }
        public string hdrUOM { get; set; }
        public string hdrContainer { get; set; }
        public string hdrDupontGMC { get; set; }
        public string RetestDate { get; set; }
        public string dupontkey { get; set; }
        public string globalcode { get; set; }
        public string smcode { get; set; }
        public string hazard { get; set; }
        public double im_pack_qty { get; set; }
        public string gl_cmp_key { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
    }
}
