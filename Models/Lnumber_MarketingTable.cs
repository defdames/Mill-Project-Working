using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Lnumber_MarketingTable
    {
        public int Key { get; set; }
        public string Market_Class_Code { get; set; }
        public string Trade_Name { get; set; }
        public Nullable<System.DateTime> Trade_Name_Date { get; set; }
        public Nullable<System.DateTime> Original_Price_Date { get; set; }
        public Nullable<decimal> Drum_Original_Price { get; set; }
        public Nullable<decimal> Truck_Original_Price { get; set; }
        public Nullable<System.DateTime> Current_Price_Date { get; set; }
        public Nullable<decimal> Drum_Current_Price { get; set; }
        public Nullable<decimal> Truck_Current_Price { get; set; }
        public string Standard_Pack { get; set; }
        public Nullable<float> Discontinued { get; set; }
        public Nullable<System.DateTime> Discontinued_Date { get; set; }
        public string Sales_Marketing_Comments { get; set; }
        public string source { get; set; }
    }
}
