using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Plastic
    {
        public int ID { get; set; }
        public string Competitive_Sample_Name { get; set; }
        public string Source { get; set; }
        public Nullable<double> Non_volitle { get; set; }
        public string C_200 { get; set; }
        public string C_230 { get; set; }
        public string C_270 { get; set; }
        public string C_325 { get; set; }
        public string C_400 { get; set; }
        public string C_500 { get; set; }
        public string C_635 { get; set; }
        public Nullable<double> D_10_ { get; set; }
        public Nullable<double> D_50_ { get; set; }
        public Nullable<double> D_90_ { get; set; }
        public string Carrier_type { get; set; }
        public Nullable<double> Carrier_extraction__ { get; set; }
        public string Flake_Geometry { get; set; }
        public string Molded_Chip_or_Press_Out { get; set; }
        public string Plastisol { get; set; }
        public string Additional_Remarks { get; set; }
        public string Closest_Silberline_Grade { get; set; }
        public Nullable<System.DateTime> Date_completed { get; set; }
        public string Analyzed_by { get; set; }
    }
}
