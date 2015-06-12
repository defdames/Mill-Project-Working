using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Regular_Non_leafing_Grades
    {
        public int ID { get; set; }
        public string Competitive_Sample_Name { get; set; }
        public string Source { get; set; }
        public Nullable<double> Non_volitle { get; set; }
        public string Acid_Resistance { get; set; }
        public string C_200 { get; set; }
        public string C_270 { get; set; }
        public string C_325 { get; set; }
        public string C_400 { get; set; }
        public string C_500 { get; set; }
        public string C_635 { get; set; }
        public Nullable<double> D_10_ { get; set; }
        public Nullable<double> D_50_ { get; set; }
        public Nullable<double> D_90_ { get; set; }
        public string Flake_Geometry { get; set; }
        public string Drawdown_vehicle { get; set; }
        public string Drawdown_description { get; set; }
        public string Sprayout_vehicle { get; set; }
        public Nullable<double> Competitive_15 { get; set; }
        public Nullable<double> Competitive_25 { get; set; }
        public Nullable<double> Competitive_45 { get; set; }
        public Nullable<double> Competitive_75 { get; set; }
        public Nullable<double> Competitive_110 { get; set; }
        public string Counter__1 { get; set; }
        public Nullable<double> Counter__1_15 { get; set; }
        public Nullable<double> Counter__1_25 { get; set; }
        public Nullable<double> Counter__1_45 { get; set; }
        public Nullable<double> Counter__1_75 { get; set; }
        public Nullable<double> Counter__1_110 { get; set; }
        public string Counter__2 { get; set; }
        public Nullable<double> Counter__2_15 { get; set; }
        public Nullable<double> Counter__2_25 { get; set; }
        public Nullable<double> Counter__2_45 { get; set; }
        public Nullable<double> Counter__2_75 { get; set; }
        public Nullable<double> Counter__2_110 { get; set; }
        public string Additional_Remarks { get; set; }
        public string Closest_Silberline_Grade { get; set; }
        public Nullable<System.DateTime> Date_completed { get; set; }
        public string Analyzed_by { get; set; }
    }
}
