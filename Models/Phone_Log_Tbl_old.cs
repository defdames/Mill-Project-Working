using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Phone_Log_Tbl_old
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public string Silberline_contact { get; set; }
        public string Contact_Name { get; set; }
        public string Contact_Address { get; set; }
        public string Contact_Phone_No { get; set; }
        public string Contact_Company { get; set; }
        public string Market_Segment { get; set; }
        public string Summary { get; set; }
        public Nullable<double> Samples_Requested_ { get; set; }
        public string Application_Notes { get; set; }
        public string Grades_Requested { get; set; }
        public string Quantity_Requested { get; set; }
        public string Literature_Requested { get; set; }
        public string Ship_When { get; set; }
        public string Ship_Via { get; set; }
        public string Fax_Number { get; set; }
        public string Email_Address { get; set; }
    }
}
