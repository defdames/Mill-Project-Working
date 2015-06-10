using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Competition_datum
    {
        public int ID { get; set; }
        public string Sample_Grade { get; set; }
        public Nullable<System.DateTime> Date_Completed { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public Nullable<int> NV_ { get; set; }
        public string Screen_analysis_1 { get; set; }
        public string Screen_analysis_2 { get; set; }
        public string Screen_analysis_3 { get; set; }
        public string Screen_analysis_4 { get; set; }
        public string Screen_analysis_5 { get; set; }
        public string Screen_analysis_6 { get; set; }
        public Nullable<int> D50_value { get; set; }
        public string Market_Segment { get; set; }
        public string Leafing_Non_leafing { get; set; }
        public Nullable<int> Leafing_Value { get; set; }
        public string Flake_Geometry { get; set; }
        public string Acid_Resistant { get; set; }
        public string Solvent_Water { get; set; }
        public string Solvent_Type { get; set; }
        public string Color { get; set; }
        public string Degradation { get; set; }
        public string Surface_Treated { get; set; }
        public string Urea_Varnish { get; set; }
        public string Sprayouts { get; set; }
        public string Closest_Match { get; set; }
    }
}
