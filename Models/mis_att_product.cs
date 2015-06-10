using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_att_product
    {
        public string Product { get; set; }
        public string ProductDesc { get; set; }
        public string Item { get; set; }
        public string PackKey { get; set; }
        public string Catalog { get; set; }
        public string ProdGrp { get; set; }
        public string ProductStatus { get; set; }
        public string LNum { get; set; }
        public string LNum_CreateDt { get; set; }
        public string Market { get; set; }
        public string SLLStatus { get; set; }
        public Nullable<decimal> QOHLBS_SM { get; set; }
        public Nullable<decimal> QOHKGS_SM { get; set; }
        public Nullable<decimal> InvValue_SM { get; set; }
        public Nullable<decimal> DaysOnHand_SM { get; set; }
        public Nullable<decimal> QOHLBS_SX { get; set; }
        public Nullable<decimal> QOHKGS_SX { get; set; }
        public Nullable<decimal> InvValue_SX { get; set; }
        public Nullable<decimal> DaysOnHand_SX { get; set; }
        public Nullable<decimal> QOHLBS_SL { get; set; }
        public Nullable<decimal> QOHKGS_SL { get; set; }
        public Nullable<decimal> InvValue_SL { get; set; }
        public Nullable<decimal> DaysOnHand_SL { get; set; }
        public Nullable<decimal> QOHLBS_SA { get; set; }
        public Nullable<decimal> QOHKGS_SA { get; set; }
        public Nullable<decimal> InvValue_SA { get; set; }
        public Nullable<decimal> DaysOnHand_SA { get; set; }
        public Nullable<decimal> QOHLBS_SS { get; set; }
        public Nullable<decimal> QOHKGS_SS { get; set; }
        public Nullable<decimal> InvValue_SS { get; set; }
        public Nullable<decimal> DaysOnHand_SS { get; set; }
    }
}
