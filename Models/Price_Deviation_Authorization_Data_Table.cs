using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Price_Deviation_Authorization_Data_Table
    {
        public int Request_No { get; set; }
        public string Requested_By { get; set; }
        public Nullable<System.DateTime> Request_Date { get; set; }
        public string Approved_By { get; set; }
        public string Declined_By { get; set; }
        public Nullable<System.DateTime> Approved_Date { get; set; }
        public Nullable<System.DateTime> Declined_Date { get; set; }
        public string Market { get; set; }
        public string Product_Code { get; set; }
        public string UOM { get; set; }
        public string Currency { get; set; }
        public string Rebate_Program { get; set; }
        public decimal List_Price { get; set; }
        public decimal Current_Price { get; set; }
        public decimal New_Requested_Price { get; set; }
        public int Minimum_Order_Quantity { get; set; }
        public string Payment_Terms { get; set; }
        public System.DateTime Effective_Date { get; set; }
        public System.DateTime Expiration_Date { get; set; }
        public string Freight_Terms { get; set; }
        public string Competitor { get; set; }
        public string Competitive_Product { get; set; }
        public decimal Competitive_Price { get; set; }
        public string Customer_Name { get; set; }
        public string Ship_To_City { get; set; }
        public string Bill_To_City { get; set; }
        public string Ship_To_State { get; set; }
        public string Bill_To_State { get; set; }
        public string Multi_National { get; set; }
        public string Zone { get; set; }
        public string Channel_Partner { get; set; }
        public string Channel_Partner_Name { get; set; }
        public string Commision { get; set; }
        public double Commission_Percent { get; set; }
        public string Additional_Information { get; set; }
        public string Contact_Name { get; set; }
        public string Contact_Title { get; set; }
        public string Freight_Support { get; set; }
        public string Customer_Ship_To_Country { get; set; }
        public string Customer_Bill_To_Country { get; set; }
        public string CustPhone { get; set; }
        public string CustEmail { get; set; }
        public string Entity { get; set; }
        public string Break_Pallet { get; set; }
        public string Freight_Allowance { get; set; }
        public string Repack { get; set; }
    }
}
