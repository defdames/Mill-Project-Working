using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class basket_material_generation
    {
        public string ItemKey { get; set; }
        public string PackKey { get; set; }
        public string Whse { get; set; }
        public short PdMo { get; set; }
        public short PdYr { get; set; }
        public string Period { get; set; }
        public string ABCCode { get; set; }
        public Nullable<double> QtyGenerated { get; set; }
    }
}
