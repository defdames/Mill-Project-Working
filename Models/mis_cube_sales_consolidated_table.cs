using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_sales_consolidated_table
    {
        public string datesold { get; set; }
        public string product { get; set; }
        public string shipkey { get; set; }
        public string company { get; set; }
        public string packkey { get; set; }
        public Nullable<double> dollarssoldlc { get; set; }
        public Nullable<double> poundssoldlc { get; set; }
        public string agent { get; set; }
        public string item { get; set; }
        public string itmclass { get; set; }
        public Nullable<double> costvalue { get; set; }
        public Nullable<double> kgs { get; set; }
        public Nullable<double> globalcost { get; set; }
        public Nullable<double> GlobalMatlValue { get; set; }
        public Nullable<double> GlobalDirectLabor { get; set; }
        public Nullable<double> GlobalVariableCost { get; set; }
        public string manufacturingloc { get; set; }
        public string Country { get; set; }
        public string soldto { get; set; }
        public string whseacct { get; set; }
        public string citystate { get; set; }
        public string shipname { get; set; }
        public string domforsam { get; set; }
        public string ship_whse { get; set; }
        public string act_fcst { get; set; }
        public Nullable<int> matlvalue { get; set; }
        public Nullable<int> rsrcvalue { get; set; }
    }
}
