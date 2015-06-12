using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class po_dtl_ext
    {
        public string gl_cmp_key { get; set; }
        public string so_brnch_key { get; set; }
        public string po_hdr_key { get; set; }
        public short po_dtl_key { get; set; }
        public Nullable<System.DateTime> ltd_exp_disp_date { get; set; }
        public string ltd_job_number { get; set; }
        public string project_number { get; set; }
        public string xen_prod_key { get; set; }
        public string requisition_number { get; set; }
        public Nullable<double> fullprice { get; set; }
        public int po_dtl_upcnt { get; set; }
        public Nullable<System.DateTime> po_dtl_shsdt { get; set; }
    }
}
