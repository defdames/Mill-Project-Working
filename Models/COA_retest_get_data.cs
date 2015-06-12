using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class COA_retest_get_data
    {
        public string en_item_key { get; set; }
        public string en_lot_key { get; set; }
        public string en_qcmst_key { get; set; }
        public Nullable<double> en_lotqc_value { get; set; }
        public string en_lotqc_reslt { get; set; }
        public Nullable<System.DateTime> en_lotqc_tstdt { get; set; }
    }
}
