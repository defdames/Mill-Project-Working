using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class suggestion
    {
        public Nullable<System.DateTime> Date { get; set; }
        public int Sug_Num { get; set; }
        public string Customer { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_Code { get; set; }
        public string Country { get; set; }
        public string Telephone_Number { get; set; }
        public string Spoke_To { get; set; }
        public string Nature_of_Suggestion { get; set; }
        public string Grade { get; set; }
        public string Affected_Department { get; set; }
        public string Describe_Briefly { get; set; }
        public string Suggestion_Taken_By { get; set; }
        public string Written_Response_to_Customer_Required { get; set; }
        public Nullable<bool> Closed { get; set; }
        public Nullable<System.DateTime> Completed_Date { get; set; }
        public string Silberline_Company { get; set; }
    }
}
