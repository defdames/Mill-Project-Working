using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class so_prod_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_prod_key { get; set; }
        public string so_prod_desc { get; set; }
        public string in_item_key { get; set; }
        public string so_catlg_key { get; set; }
        public int so_prod_cuma { get; set; }
        public int so_prod_cums { get; set; }
        public double so_prod_fcstc { get; set; }
        public double so_prod_rwrkc { get; set; }
        public double so_prod_wslec { get; set; }
        public double so_prod_rstkc { get; set; }
        public string so_pgc_key { get; set; }
        public string so_ppc_key { get; set; }
        public string ar_tax_key { get; set; }
        public string im_pack_key { get; set; }
        public double so_prod_shpwt { get; set; }
        public string so_prod_wtuom { get; set; }
        public string so_prod_uom { get; set; }
        public double so_prod_vol { get; set; }
        public string so_prod_vluom { get; set; }
        public int so_prod_shipf { get; set; }
        public double so_prod_cst { get; set; }
        public short so_prod_stdf { get; set; }
        public short so_prod_kitf { get; set; }
        public short so_prod_taxf { get; set; }
        public short so_prod_packf { get; set; }
        public short so_prod_exptf { get; set; }
        public short so_prod_authf { get; set; }
        public int so_prod_pksze { get; set; }
        public string so_brprd_prcls { get; set; }
        public short so_brprd_mpflag { get; set; }
        public double so_brprd_mnmrg { get; set; }
        public string bm_aprt_key { get; set; }
        public int so_prod_upcnt { get; set; }
        public string en_stats_key { get; set; }
        public Nullable<short> so_prod_ffltm { get; set; }
        public Nullable<short> so_prod_piktm { get; set; }
        public double so_prod_pltqt { get; set; }
        public string en_uom_orderdef { get; set; }
        public string en_uom_pricedef { get; set; }
        public Nullable<double> so_prod_tarewgt { get; set; }
        public string en_uom_tarewgt { get; set; }
        public short so_prod_restrictf { get; set; }
        public string en_uom_analuom { get; set; }
        public string so_cmdtypc_key { get; set; }
        public string gl_cmp_profit { get; set; }
        public string so_brnch_profit { get; set; }
        public int so_prod_mktoordf { get; set; }
        public int so_prod_mktoordqty { get; set; }
        public string so_brand_key { get; set; }
    }
}
