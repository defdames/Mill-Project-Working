using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class TSR
    {
        public int TSR_Number { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Request_Complete_ { get; set; }
        public string Submitter { get; set; }
        public string Agent { get; set; }
        public string Regional_Manager { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public string Address1 { get; set; }
        public string Country { get; set; }
        public string Customer_Contact { get; set; }
        public string Phone { get; set; }
        public string fax { get; set; }
        public Nullable<System.DateTime> Requested_Completion_Date { get; set; }
        public string Grade_Number { get; set; }
        public Nullable<bool> Competitive_Analysis { get; set; }
        public Nullable<bool> Product_Modification { get; set; }
        public Nullable<bool> New_Product { get; set; }
        public Nullable<bool> New_Customer { get; set; }
        public Nullable<bool> Performance_Assistance { get; set; }
        public Nullable<bool> Application_Assistance { get; set; }
        public Nullable<bool> Formulation_Assistance { get; set; }
        public Nullable<bool> Sales_Aids { get; set; }
        public Nullable<bool> Master_Standard { get; set; }
        public Nullable<bool> Experimental_Request { get; set; }
        public Nullable<bool> Panels_Chips { get; set; }
        public Nullable<bool> Others { get; set; }
        public string Describe_Objective { get; set; }
        public string Request_from_Tech_Service { get; set; }
        public string Discussed_with { get; set; }
        public Nullable<int> MSDS { get; set; }
        public string Vehical_Type { get; set; }
        public string Product_End_Use { get; set; }
        public string Market { get; set; }
        public string Tech_Service_Assigned { get; set; }
        public Nullable<System.DateTime> Date_Tech_Service_Assigned { get; set; }
        public string Request_Fully_Complete { get; set; }
        public Nullable<System.DateTime> Date_Request_Fully_Complete { get; set; }
        public Nullable<int> Customer_Tech_Comlaint_Form_Filed { get; set; }
        public string Number { get; set; }
        public string Respond_To { get; set; }
        public string Comments { get; set; }
        public Nullable<bool> hold { get; set; }
        public Nullable<System.DateTime> hold_date { get; set; }
        public Nullable<System.DateTime> reopen_date { get; set; }
        public string reason { get; set; }
        public string vehicle { get; set; }
        public Nullable<bool> complaints { get; set; }
        public Nullable<bool> production_support { get; set; }
        public string potential_market_size__lb_ { get; set; }
        public string price_ceiling_target { get; set; }
    }
}
