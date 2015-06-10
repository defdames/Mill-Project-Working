using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class expense_budget_SL
    {
        public string employee_name { get; set; }
        public string expense_name { get; set; }
        public string expense_type { get; set; }
        public double expense_amount { get; set; }
        public string expense_year { get; set; }
        public string expense_quarter { get; set; }
        public string approved { get; set; }
    }
}
