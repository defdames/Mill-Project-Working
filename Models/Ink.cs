using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Ink
    {
        public int ID { get; set; }
        public string Competitive_Sample_Name { get; set; }
        public string Source { get; set; }
        public Nullable<double> Non_volitle { get; set; }
        public string Type_Leafing_NonLeafing { get; set; }
        public string C_200 { get; set; }
        public string C_270 { get; set; }
        public string C_325 { get; set; }
        public string C_400 { get; set; }
        public string C_500 { get; set; }
        public string C_635 { get; set; }
        public Nullable<double> D_10_ { get; set; }
        public Nullable<double> D_50_ { get; set; }
        public Nullable<double> D_90_ { get; set; }
        public Nullable<double> Leafing_Value { get; set; }
        public string Carrier_Solvent { get; set; }
        public Nullable<double> Lube__ { get; set; }
        public string Flake_Geometry { get; set; }
        public string Ink_Vehicle { get; set; }
        public string Drawdown_RK_Prints_description { get; set; }
        public string Additional_Remarks { get; set; }
        public string Closest_Silberline_Grade { get; set; }
        public Nullable<System.DateTime> Date_completed { get; set; }
        public string Analyzed_by { get; set; }
    }
}
