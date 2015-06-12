using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Plant_Mill_Formula_Table
    {
        public int ID { get; set; }
        public string ItemID { get; set; }
        public string Plant_ID { get; set; }
        public string System { get; set; }
        public string No_of_Mills { get; set; }
        public string Feed_Type { get; set; }
        public Nullable<double> Feed_Amt { get; set; }
        public Nullable<double> Feed_NV { get; set; }
        public string Oleic { get; set; }
        public string Stearic { get; set; }
        public string Lauric { get; set; }
        public string Initial_Varsol_Added { get; set; }
        public string Slurry_Height { get; set; }
        public string Probe_At { get; set; }
        public Nullable<double> Mill_NV { get; set; }
        public Nullable<double> Media_Weight { get; set; }
        public string Media_Type { get; set; }
        public Nullable<double> Mill_RPM { get; set; }
        public string Run_Hrs { get; set; }
        public Nullable<double> Mill_Drain_Dil { get; set; }
        public Nullable<double> Screen_Percent { get; set; }
        public Nullable<double> Gal_to_Screens { get; set; }
        public string Scalper_ { get; set; }
        public string Scalper_Mesh { get; set; }
        public string C1st_Pass_ { get; set; }
        public string C1st_Pass_Mesh { get; set; }
        public string C2nd_Pass_ { get; set; }
        public string C2nd_Pass_Mesh { get; set; }
        public string Check_ { get; set; }
        public string Check_Mesh { get; set; }
        public Nullable<double> C_Yield { get; set; }
        public string Std_Production { get; set; }
        public string SpecialT_Code { get; set; }
        public string Dry_Mix_Time { get; set; }
        public string Finished_Mix_Time { get; set; }
        public Nullable<double> Finished__ { get; set; }
        public string Used_to_Make { get; set; }
        public string Comments { get; set; }
        public string Drain_Method { get; set; }
        public string Media_Lot { get; set; }
        public string Ball_Height { get; set; }
        public string Mill_Number { get; set; }
        public Nullable<double> Varsol { get; set; }
        public string Probe_Height { get; set; }
        public string Remarks { get; set; }
        public string Date { get; set; }
        public string Ingredient_Lot { get; set; }
        public string Adogen { get; set; }
        public string Revision__ { get; set; }
        public string Load_ID { get; set; }
        public string SecondFeedType { get; set; }
        public Nullable<double> SecondFeedAmt { get; set; }
        public string ThirdFeedType { get; set; }
        public string IngType { get; set; }
        public string StearicGrade { get; set; }
        public string OleicGrade { get; set; }
        public string AdogenGrade { get; set; }
        public string VarsolType { get; set; }
        public string Verifying { get; set; }
        public string MillAirAt { get; set; }
        public string ADD_VARSOL { get; set; }
        public string VarsolTo { get; set; }
        public string MILL_CHECK { get; set; }
        public string LauricGrade { get; set; }
        public string Lube1 { get; set; }
        public string L1WT { get; set; }
        public string Lube2 { get; set; }
        public string L2WT { get; set; }
        public string Kaydol { get; set; }
        public string IsMaster { get; set; }
    }
}
