using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Employee
    {
        public string Plant { get; set; }
        public string Employee_Name { get; set; }
        public string Active_or_Inactive { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string MI { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Cell_Phone { get; set; }
        public string Status { get; set; }
        public System.DateTime Start_Date { get; set; }
        public Nullable<System.DateTime> Dept_Date { get; set; }
        public string Classification { get; set; }
        public string Dept { get; set; }
        public string Shift { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string Comments { get; set; }
        public double Clock { get; set; }
        public string Layoff_Date { get; set; }
        public string Non_Emp_Date { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public Nullable<System.DateTime> Plant_Date { get; set; }
        public string Number1 { get; set; }
        public string Union_ { get; set; }
        public string Prev_Yr_Left { get; set; }
        public string Entitlement { get; set; }
        public string Vac_Days_Used { get; set; }
        public string Vac_Days_Avail { get; set; }
        public string Vac_Remaining { get; set; }
        public string Shoe_Remarks { get; set; }
        public string Shoe_Style { get; set; }
        public string Shoe_Size { get; set; }
        public string Filter_Field { get; set; }
        public Nullable<double> Seniority { get; set; }
        public string Hourly_Salaried { get; set; }
        public string originalplant { get; set; }
        public string originaldept { get; set; }
        public Nullable<System.DateTime> currentdeptdate { get; set; }
    }
}
