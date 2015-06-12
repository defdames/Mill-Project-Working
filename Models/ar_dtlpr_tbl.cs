using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class ar_dtlpr_tbl
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public int ar_dtlprnm_key { get; set; }
        public double ar_dtlpr_etotbillc { get; set; }
        public double ar_dtlpr_ettbillcf { get; set; }
        public double ar_dtlpr_basec { get; set; }
        public double ar_dtlpr_basecf { get; set; }
        public Nullable<double> ar_dtlpr_eeltaxcf { get; set; }
        public Nullable<double> ar_dtlpr_eeldsccf { get; set; }
        public Nullable<double> ar_dtlpr_eelcomcf { get; set; }
        public Nullable<double> ar_dtlpr_eudlvdcf { get; set; }
        public Nullable<double> ar_dtlpr_eudlvdacf { get; set; }
        public Nullable<double> ar_dtlpr_edlvdcf { get; set; }
        public Nullable<double> ar_dtlpr_edlvdacf { get; set; }
        public double ar_dtlpr_ebasec { get; set; }
        public double ar_dtlpr_ebasecf { get; set; }
        public double ar_dtlpr_ebasecp { get; set; }
        public Nullable<double> ar_dtlpr_eaccrcf { get; set; }
        public Nullable<double> ar_dtlpr_tax1c { get; set; }
        public Nullable<double> ar_dtlpr_tax1cf { get; set; }
        public Nullable<double> ar_dtlpr_tax2c { get; set; }
        public Nullable<double> ar_dtlpr_tax2cf { get; set; }
        public Nullable<double> ar_dtlpr_tax3c { get; set; }
        public Nullable<double> ar_dtlpr_tax3cf { get; set; }
        public Nullable<double> ar_dtlpr_tax4c { get; set; }
        public Nullable<double> ar_dtlpr_tax4cf { get; set; }
        public Nullable<double> ar_dtlpr_tax5c { get; set; }
        public Nullable<double> ar_dtlpr_tax5cf { get; set; }
        public string ar_tax_key { get; set; }
        public double ar_dtlpr_adjbasecf { get; set; }
        public double ar_dtlpr_eadbasecf { get; set; }
        public int ar_dtlpr_upcnt { get; set; }
        public short ar_dtlpr_extactf { get; set; }
        public short ar_dtlpr_eprcactf { get; set; }
        public short ar_dtlpr_efrtactf { get; set; }
        public string gl_vatcd_key { get; set; }
        public double gl_vatrate_pct { get; set; }
        public double ar_dtlpr_vatc { get; set; }
        public double ar_dtlpr_vatcf { get; set; }
        public Nullable<double> ar_dtlpr_quoteprcf { get; set; }
        public string en_uom_analuom { get; set; }
        public Nullable<double> ar_dtlpr_analqty { get; set; }
        public string gl_crncy_trfpr { get; set; }
        public Nullable<double> ar_dtlpr_trfbasecs { get; set; }
        public Nullable<double> ar_dtlpr_trfebascs { get; set; }
        public Nullable<double> ar_dtlpr_trfetotcs { get; set; }
        public Nullable<double> ar_dtlpr_trftax1cs { get; set; }
        public Nullable<double> ar_dtlpr_trftax2cs { get; set; }
        public Nullable<double> ar_dtlpr_trftax3cs { get; set; }
        public Nullable<double> ar_dtlpr_trftax4cs { get; set; }
        public Nullable<double> ar_dtlpr_trftax5cs { get; set; }
        public Nullable<double> ar_dtlpr_trfvatcs { get; set; }
        public string ar_tax_trfpr { get; set; }
        public string gl_vatcd_artrfpr { get; set; }
        public string gl_vatcd_aptrfpr { get; set; }
        public string ar_dtlpr_trfexsus { get; set; }
        public Nullable<double> ar_dtlpr_icbasecf { get; set; }
        public Nullable<double> ar_dtlpr_eicbasecf { get; set; }
        public Nullable<double> ar_dtlpr_expaccrcf { get; set; }
    }
}
