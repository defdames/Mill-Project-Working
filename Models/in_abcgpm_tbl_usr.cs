using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class in_abcgpm_tbl_usr
    {
        public string ItemKey { get; set; }
        public string ABCode { get; set; }
        public double ItemCost { get; set; }
        public double QOH { get; set; }
        public double Value { get; set; }
        public double Forecast { get; set; }
        public double Dollars { get; set; }
        public double Pounds { get; set; }
        public double Cost { get; set; }
        public double GPM { get; set; }
        public int BeginMo { get; set; }
        public int BeginYr { get; set; }
        public int EndMo { get; set; }
        public int EndYr { get; set; }
    }
}
