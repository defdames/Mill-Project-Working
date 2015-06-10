using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class car_blend_notification
    {
        public int Car_No { get; set; }
        public string Grade_Name { get; set; }
        public string Lot_Number { get; set; }
        public string Plant { get; set; }
        public Nullable<int> numofdays { get; set; }
    }
}
