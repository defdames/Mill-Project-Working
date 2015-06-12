using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_dbcrm_tbl
    {
        public string gl_cmp_key { get; set; }
        public string in_brnch_key { get; set; }
        public string ar_dbcrm_type { get; set; }
        public string ar_dbcrm_key { get; set; }
        public short ar_dbcrdtl_key { get; set; }
        public int ar_ivdtl_key { get; set; }
        public string so_prod_key { get; set; }
        public short so_dtl_key { get; set; }
        public double ar_dbcrm_cramt { get; set; }
        public string ar_dbcrm_remk { get; set; }
        public double ar_dbcrm_rchgc { get; set; }
        public double ar_dbcrm_cramtf { get; set; }
        public double ar_dbcrm_rchgcf { get; set; }
        public string ar_dbcrm_reascd { get; set; }
        public double ar_dbcrm_qty { get; set; }
        public string ar_dbcrm_sltyp { get; set; }
        public Nullable<short> ar_dbcrm_adjfl { get; set; }
        public short ar_dbcrm_updlimit { get; set; }
        public double ar_dbcrm_pot { get; set; }
        public int ar_dtlprnm_key { get; set; }
        public string ar_dbcrm_prcuom { get; set; }
        public string ar_dbcrm_desc { get; set; }
        public int ar_dbcrm_upcnt { get; set; }
        public double ar_dbcrm_grnomwt { get; set; }
        public Nullable<double> ar_dbcrm_gractwt { get; set; }
        public string en_uom_wtuom { get; set; }
        public Nullable<double> ar_dbcrm_afill { get; set; }
        public string en_uom_afill { get; set; }
        public double ar_dbcrm_skuqty { get; set; }
        public string ar_dbcrm_skuuom { get; set; }
        public int im_localgrp_key { get; set; }
        public string gl_vatcd_key { get; set; }
        public double gl_vatrate_pct { get; set; }
        public double ar_dbcrm_vatc { get; set; }
        public double ar_dbcrm_vatcf { get; set; }
        public short ar_dbcrm_disitmf { get; set; }
        public Nullable<System.DateTime> so_ship_date { get; set; }
        public string gl_cmp_profit { get; set; }
        public string so_brnch_profit { get; set; }
        public string gl_cmp_ship { get; set; }
        public string so_brnch_ship { get; set; }
        public Nullable<int> so_shpitm_intinv { get; set; }
        public short ar_dbcrm_revint { get; set; }
        public string so_enduse_key { get; set; }
        public string gl_cmp_assoc { get; set; }
        public string so_brnch_assoc { get; set; }
        public string ar_dbcrm_typeassoc { get; set; }
        public string ar_dbcrm_assoc { get; set; }
        public Nullable<short> ar_dbcrdtl_assoc { get; set; }
        public string ar_ship_key { get; set; }
        public Nullable<double> ar_dbcrm_altqty { get; set; }
        public string en_uom_alternate { get; set; }
        public string so_brand_key { get; set; }
        public string gl_misc_key { get; set; }
    }
}
