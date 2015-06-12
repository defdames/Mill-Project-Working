using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class en_lotqc_tbl
    {
        public string en_item_key { get; set; }
        public string en_lot_key { get; set; }
        public string en_qcmst_key { get; set; }
        public int en_lotqc_seqno { get; set; }
        public Nullable<double> en_lotqc_value { get; set; }
        public string en_lotqc_reslt { get; set; }
        public string en_lotqc_tstby { get; set; }
        public Nullable<System.DateTime> en_lotqc_tstdt { get; set; }
        public Nullable<short> en_lotqc_stats { get; set; }
        public string en_lotqc_text { get; set; }
        public int en_lotqc_upcnt { get; set; }
        public string im_pack_key { get; set; }
        public System.DateTime en_itqct_effdt { get; set; }
        public string en_sppck_key { get; set; }
        public string qc_sample_key { get; set; }
        public string qc_disp_key { get; set; }
        public string en_lotqc_dispnotes { get; set; }
        public Nullable<double> en_lotqc_ovalue { get; set; }
        public string en_lotqc_oresult { get; set; }
        public int en_lotqc_mnmxop { get; set; }
    }
}
