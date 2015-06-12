using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class SysOpSheet
    {
        public int ID { get; set; }
        public string Item_ID { get; set; }
        public string Plant { get; set; }
        public string System { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string MillsUsed { get; set; }
        public string MillAirflow { get; set; }
        public string ScalperMesh { get; set; }
        public string ChargeVar { get; set; }
        public string DrainType { get; set; }
        public string DilutionSolvent { get; set; }
        public string MillDilutionGals { get; set; }
        public string FinalDilutionSolvent { get; set; }
        public string DilutionSetPoint { get; set; }
        public string FinalDilutionGals { get; set; }
        public string DrainLightMinutes { get; set; }
        public string ScalperScreens { get; set; }
        public string FirstPass { get; set; }
        public string FirstPassMesh { get; set; }
        public string FirstPassSolvent { get; set; }
        public string FirstPassFlow { get; set; }
        public string SecondPass { get; set; }
        public string SecondPassMesh { get; set; }
        public string SecondPassSolvent { get; set; }
        public string SecondPassFlow { get; set; }
        public string CheckScreenMesh { get; set; }
        public string CheckScreenFlow { get; set; }
        public string NumbersOfScreens { get; set; }
        public string Comments { get; set; }
        public string CheckScreens { get; set; }
        public string PressesUsed { get; set; }
        public string PressWash { get; set; }
        public string AirTime { get; set; }
        public string Press1Wash { get; set; }
        public string Press2Wash { get; set; }
        public string Press3Wash { get; set; }
        public string Press4Wash { get; set; }
        public string Press6Wash { get; set; }
        public string Press11Wash { get; set; }
        public string Press12Wash { get; set; }
        public string Press13Wash { get; set; }
        public string Press14Wash { get; set; }
        public string Press15Wash { get; set; }
        public string Press16Wash { get; set; }
        public string Revision { get; set; }
        public string CentrifugeSetting { get; set; }
        public string BMNV { get; set; }
        public string VarsolTo { get; set; }
        public string RPMs { get; set; }
        public string Remarks { get; set; }
        public string Press5Wash { get; set; }
        public string Press7Wash { get; set; }
        public string Press8Wash { get; set; }
        public string Press9Wash { get; set; }
        public string Press10Wash { get; set; }
        public string Press17Wash { get; set; }
        public string Press18Wash { get; set; }
        public string TotalFlow { get; set; }
        public string Varsol_Valve_PID1 { get; set; }
        public string Varsol_Valve_PID2 { get; set; }
        public string Varsol_Valve_PID3 { get; set; }
        public string Varsol_Valve_Output_MIN { get; set; }
        public string Varsol_Valve_Output_MAX { get; set; }
        public string Material_Valve_PID1 { get; set; }
        public string Material_Valve_PID2 { get; set; }
        public string Material_Valve_PID3 { get; set; }
        public string Material_Valve_Output_MIN { get; set; }
        public string Material_Valve_Output_MAX { get; set; }
        public Nullable<bool> Agitator { get; set; }
        public Nullable<bool> Slurry_Pump { get; set; }
        public Nullable<bool> Mag_Tank_Pump { get; set; }
        public Nullable<bool> Lobe_Pump { get; set; }
        public Nullable<bool> Dilution_Pump { get; set; }
        public Nullable<bool> Centrifuge { get; set; }
        public Nullable<bool> Cent_Feed_Pump { get; set; }
        public Nullable<bool> Cent_Ret_Pump { get; set; }
        public Nullable<bool> C1st_pass_Trails_Pump { get; set; }
        public Nullable<bool> Chk_Screen_Feed_Pump { get; set; }
    }
}
