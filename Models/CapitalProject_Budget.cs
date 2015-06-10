using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class CapitalProject_Budget
    {
        public int id { get; set; }
        public string CapitalProjNum { get; set; }
        public string AccountCode { get; set; }
        public Nullable<decimal> ApprovedCost { get; set; }
        public Nullable<decimal> EstAdditionalCost { get; set; }
    }
}
