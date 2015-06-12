using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class NonTechnical_Summary
    {
        public Nullable<System.DateTime> Date { get; set; }
        public string Agent { get; set; }
        public string Agent_Involved { get; set; }
        public int NTC_Num { get; set; }
        public Nullable<System.DateTime> Estimated_Complete_Date { get; set; }
        public string Customer { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_Code { get; set; }
        public string Country { get; set; }
        public string Telephone_Number { get; set; }
        public string Spoke_To { get; set; }
        public string Nature_of_Complaint { get; set; }
        public string Grade { get; set; }
        public string Lot_Number { get; set; }
        public string Location { get; set; }
        public string Describe_Briefly { get; set; }
        public string Complaint_Taken_By { get; set; }
        public string Written_Response_to_Customer_Required { get; set; }
        public string Root_Cause { get; set; }
        public string Root_Signature { get; set; }
        public Nullable<System.DateTime> Root_Date { get; set; }
        public string Corrective_Action { get; set; }
        public string Corrective_Signature { get; set; }
        public string Corrective_Date { get; set; }
        public string Preventative_Action { get; set; }
        public string Preventative_Signature { get; set; }
        public Nullable<System.DateTime> Preventative_Date { get; set; }
        public string Customer_Contacted_By { get; set; }
        public Nullable<System.DateTime> Contacted_On { get; set; }
        public string Valid { get; set; }
        public Nullable<bool> Closed { get; set; }
        public string Signature { get; set; }
        public string Company { get; set; }
        public string Reason_Category { get; set; }
        public Nullable<System.DateTime> Completed_Date { get; set; }
    }
}
