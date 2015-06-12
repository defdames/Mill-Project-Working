using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class rebates_for_channelpartners3_tbl
    {
        public System.DateTime tran_date_key { get; set; }
        public string HdrKey { get; set; }
        public int DtlKey { get; set; }
        public string ShipName { get; set; }
        public string ShipTo { get; set; }
        public string ProdDesc { get; set; }
        public string Product { get; set; }
        public string Class { get; set; }
        public double dollars { get; set; }
        public Nullable<double> pounds { get; set; }
        public string lot { get; set; }
        public Nullable<double> lotpounds { get; set; }
        public string en_cust_key { get; set; }
        public string so_hdr_key { get; set; }
        public string en_whs_key { get; set; }
        public string gl_cmp_key { get; set; }
        public decimal pda_newrequestedprice { get; set; }
        public Nullable<System.DateTime> pda_effective { get; set; }
        public Nullable<System.DateTime> pda_expiration { get; set; }
        public double soldto_channel_partner_units { get; set; }
        public double soldto_channel_partner_dollars { get; set; }
        public string soldto_channel_partner_uom { get; set; }
        public string inv_item { get; set; }
        public string pda_item { get; set; }
        public string channel_partner_code { get; set; }
        public string en_cust_name { get; set; }
        public string channel_partner_invoice { get; set; }
        public System.DateTime channel_partner_invoice_date { get; set; }
        public string channel_partner_soldto_customer { get; set; }
        public string channel_partner_detail_sales_lot { get; set; }
        public double channel_discount { get; set; }
        public double Silberline_Net_Price_Per_Unit { get; set; }
        public Nullable<double> smc_base { get; set; }
        public string repack { get; set; }
    }
}
