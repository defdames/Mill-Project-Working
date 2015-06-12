using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Confidentiality_Table
    {
        public int AgreeID { get; set; }
        public string Silberline_Entity { get; set; }
        public Nullable<System.DateTime> Execution_Date { get; set; }
        public string Term_of_Agreement { get; set; }
        public Nullable<System.DateTime> Expiration_Date { get; set; }
        public string Purpose { get; set; }
        public string Company_Name { get; set; }
        public string Company_Address { get; set; }
        public string Disclosee { get; set; }
        public string Disclosee_Title { get; set; }
        public string Type_of_Agreement { get; set; }
        public string Silberline_Rep { get; set; }
        public string Special_Notes { get; set; }
        public string Agreement_Status { get; set; }
    }
}
