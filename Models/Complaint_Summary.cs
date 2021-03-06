using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class Complaint_Summary
    {
        public Nullable<bool> Confirm_ { get; set; }
        public Nullable<bool> Lab_Valid_ { get; set; }
        public int TC_Num { get; set; }
        public string ID_Agent_Name { get; set; }
        public string ID_Agent_Location { get; set; }
        public Nullable<System.DateTime> Date_Rec_d { get; set; }
        public string Submitter { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Rep { get; set; }
        public string Address_Line_1 { get; set; }
        public string Address_Line_2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Customer_Telephone { get; set; }
        public string Customer_Facsimile { get; set; }
        public string Tech_Serv_Activity { get; set; }
        public string Tech_Serv_Sign_Off { get; set; }
        public Nullable<bool> Mat_l_Returned_ { get; set; }
        public string Grede_1_ID { get; set; }
        public string Grade_1_Lot_No { get; set; }
        public string Grade_1_Duplicate_Lot2 { get; set; }
        public string Grade_1_Duplicate_Lot3 { get; set; }
        public string Grade_1_Description { get; set; }
        public string Grade_1_Interim_Corrective_Action { get; set; }
        public string Tech_Serv_Act_Date { get; set; }
        public string Original_NV_Lot_1 { get; set; }
        public string Retain_NV_Lot_1_ { get; set; }
        public string Stock_NV_Lot_1 { get; set; }
        public string Return_NV_Lot_1_ { get; set; }
        public string Original___Leafing { get; set; }
        public string Retain___Leafing { get; set; }
        public string Stock___Leafing { get; set; }
        public string Return___Leafing { get; set; }
        public string Original_D10_PS_Lot_1 { get; set; }
        public string Original_D50_PS_Lot_1 { get; set; }
        public string Original_D90_PS_Lot_1 { get; set; }
        public string Original_200_Mesh_Lot_1 { get; set; }
        public string Original_325_Mesh_Lot_1 { get; set; }
        public string Original_400_Mesh_Lot_1 { get; set; }
        public string Original_500_Mesh_Lot_1 { get; set; }
        public string Retain_D10_PS_Lot_1 { get; set; }
        public string Retain_D50_PS_Lot_1 { get; set; }
        public string Retain_D90_PS_Lot_1 { get; set; }
        public string Retain_200_Mesh_Lot_1 { get; set; }
        public string Retain_325_Mesh_Lot_1 { get; set; }
        public string Retain_400_Mesh_Lot_1 { get; set; }
        public string Retain_500_Mesh_Lot_1 { get; set; }
        public string Stock_D10_PS_Lot_1 { get; set; }
        public string Stock_D50_PS_Lot_1 { get; set; }
        public string Stock_D90_PS_Lot_1 { get; set; }
        public string Stock_200_Mesh_Lot_1 { get; set; }
        public string Stock_325_Mesh_Lot_1 { get; set; }
        public string Stock_400_Mesh_Lot_1 { get; set; }
        public string Stock_500_Mesh_Lot_1 { get; set; }
        public string Return_D10_PS_Lot_1 { get; set; }
        public string Return_D50_PS_Lot_1 { get; set; }
        public string Return_D90_PS_Lot_1 { get; set; }
        public string Return_200_Mesh_Lot_1 { get; set; }
        public string Return_325_Mesh_Lot_1 { get; set; }
        public string Return_400_MEsh_Lot_1 { get; set; }
        public string Return_500_Mesh_Lot_1 { get; set; }
        public string Test_Result_Comments_Lot_1 { get; set; }
        public string Root_Cause { get; set; }
        public string Permanent_Corrective_Action { get; set; }
        public string Type_of_Complaint { get; set; }
        public string Reason_for_Complaint { get; set; }
        public string Person_s__Handling_Complaint { get; set; }
        public string Is_Material_in_Spec { get; set; }
        public string QA_Representative { get; set; }
        public Nullable<System.DateTime> QA_Rep_Date { get; set; }
        public string Root_Cause_Determination_Rep { get; set; }
        public Nullable<System.DateTime> Root_Cause_Date { get; set; }
        public string Permanent_CA_Taken { get; set; }
        public Nullable<System.DateTime> Permanent_CA_Date { get; set; }
        public Nullable<bool> Customer_Notification { get; set; }
        public string Complaint_Resolved_Sign_Off { get; set; }
        public Nullable<System.DateTime> Complaint_Resolved_Sign_Off_Date { get; set; }
        public Nullable<int> Agent_Nos { get; set; }
        public Nullable<int> ID { get; set; }
        public Nullable<int> ID2 { get; set; }
        public string Original_NV_Lot_2 { get; set; }
        public string Retain_NV_Lot_2 { get; set; }
        public string Stock_NV_Lot_2 { get; set; }
        public string Return_NV_Lot_2 { get; set; }
        public string Original___Leafing_Lot_2 { get; set; }
        public string Retain___Leafing_Lot_2 { get; set; }
        public string Stock___Leafing_Lot_2 { get; set; }
        public string Return___Leafing_Lot_2 { get; set; }
        public string Original_D10_PS_Lot_2 { get; set; }
        public string Original_D50_PS_Lot_2 { get; set; }
        public string Original_D90_PS_Lot_2 { get; set; }
        public string Original_200_Mesh_Lot_2 { get; set; }
        public string Original_325_Mesh_Lot_2 { get; set; }
        public string Original_400_Mesh_Lot_2 { get; set; }
        public string Original_500_Mesh_Lot_2 { get; set; }
        public string Retain_D10_PS_Lot_2 { get; set; }
        public string Retain_D50_PS_Lot_2 { get; set; }
        public string Retain_D90_PS_Lot_2 { get; set; }
        public string Retain_200_Mesh__Lot_2 { get; set; }
        public string Retain_325_Mesh_Lot_2 { get; set; }
        public string Retain_400_Mesh_Lot_2 { get; set; }
        public string Retain_500_Mesh_Lot_2 { get; set; }
        public string Stock_D10_PS_Lot_2 { get; set; }
        public string Stock_D50_PS_Lot_2 { get; set; }
        public string Stock_D90_PS_Lot_2 { get; set; }
        public string Stock_200_Mesh_Lot_2 { get; set; }
        public string Stock_325_Mesh_Lot_2 { get; set; }
        public string Stock_400_Mesh_Lot_2 { get; set; }
        public string Stock_500_Mesh_Lot_2 { get; set; }
        public string Return_D10_PS_Lot_2 { get; set; }
        public string Return_D50_PS_Lot_2 { get; set; }
        public string Return_D90_PS_Lot_2 { get; set; }
        public string Return_200_Mesh_Lot_2 { get; set; }
        public string Return_325_Mesh_Lot_2 { get; set; }
        public string Return_400_Mesh_Lot_2 { get; set; }
        public string Return_500_Mesh_Lot_2 { get; set; }
        public string Test_Result_Comments_Lot_2 { get; set; }
        public string Original_NV_Lot_3 { get; set; }
        public string Retain_NV_Lot_3 { get; set; }
        public string Stock_NV_Lot_3 { get; set; }
        public string Return_NV_Lot_3 { get; set; }
        public string Original___Leafing_Lot_3 { get; set; }
        public string Retain___Leafing_Lot_3 { get; set; }
        public string Stock___Leafing_Lot_3 { get; set; }
        public string Return___Leafing_Lot_3 { get; set; }
        public string Original_D10_PS_Lot_3 { get; set; }
        public string Original_D50_PS_Lot_3 { get; set; }
        public string Original_D90_PS_Lot_3 { get; set; }
        public string Retain_D10_PS_Lot_3 { get; set; }
        public string Retain_D50_PS_Lot_3 { get; set; }
        public string Retain_D90_PS_Lot_3 { get; set; }
        public string Stock_D10_PS_Lot_3 { get; set; }
        public string Stock_D50_PS_Lot_3 { get; set; }
        public string Stock_D90_PS_Lot_3 { get; set; }
        public string Stock_200_Mesh_Lot_3 { get; set; }
        public string Stock_325_Mesh_Lot_3 { get; set; }
        public string Stock_400_Mesh_Lot_3 { get; set; }
        public string Stock_500_Mesh_Lot_3 { get; set; }
        public string Original_200_Mesh_Lot_3 { get; set; }
        public string Original_325_Mesh_Lot_3 { get; set; }
        public string Original_400_Mesh_Lot_3 { get; set; }
        public string Original_500_Mesh_Lot_3 { get; set; }
        public string Retain_200_Mesh_Lot_3 { get; set; }
        public string Retain_325_Mesh_Lot_3 { get; set; }
        public string Retain_400_Mesh_Lot_3 { get; set; }
        public string Retain_500_Mesh_Lot_3 { get; set; }
        public string Return_D10_PS_Lot_3 { get; set; }
        public string Return_D50_PS_Lot_3 { get; set; }
        public string Return_D90_PS_Lot_3 { get; set; }
        public string Return_200_Mesh_Lot_3 { get; set; }
        public string Return_325_Mesh_Lot_3 { get; set; }
        public string Return_400_Mesh_Lot_3 { get; set; }
        public string Return_500_Mesh_Lot_3 { get; set; }
        public string Test_Result_Comments_Lot_3 { get; set; }
        public Nullable<bool> Complaint_Resolved_Date { get; set; }
        public Nullable<bool> Complaint_Resolution_Notification_to_Customer { get; set; }
        public string Reg_Mgr_TS_Rep_Sign_Off { get; set; }
        public string Tech_Serv_Rep_Sign_Off { get; set; }
        public string RegMgr_OR_Tec_Serv_Rep_Status_Sign_Off { get; set; }
        public Nullable<System.DateTime> Tech_Serv_Activity_Date_Sign_Off { get; set; }
        public string Current_Year { get; set; }
        public string Dry_Paste_Description { get; set; }
        public string Dry_Paste_Description2 { get; set; }
        public string Dry_Paste_Description3 { get; set; }
        public Nullable<int> Solvent_Acid_Number { get; set; }
        public Nullable<int> Solvent_Acid_Number2 { get; set; }
        public Nullable<int> Solvent_Acid_Number3 { get; set; }
        public Nullable<int> Packability_Index { get; set; }
        public Nullable<int> Packability_Index2 { get; set; }
        public Nullable<int> Packability_Index3 { get; set; }
        public string Complaint_Origination { get; set; }
        public byte[] Tech_Attachment { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_1_Original { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_1_Retain { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_1_Stock { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_1_Return { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_2_Original { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_2_Retain { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_2_Stock { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_2_Return { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_3_Original { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_3_Retain { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_3_Stock { get; set; }
        public Nullable<bool> Confirm_Findings_Lot_3_Return { get; set; }
        public string Return_Authorization_Number { get; set; }
        public string Technical_Service_Rep { get; set; }
        public string Market { get; set; }
        public Nullable<bool> Material_Placed_on_Hold { get; set; }
        public Nullable<System.DateTime> QA_Release_Date { get; set; }
        public string Valid { get; set; }
        public string Consignment_verified_by { get; set; }
        public string contact_made_by { get; set; }
        public string T_S_Rep { get; set; }
        public string Sales_Zone { get; set; }
        public string Paste_or_Post { get; set; }
        public string DLM25 { get; set; }
        public string DLT25 { get; set; }
        public string DLM45 { get; set; }
        public string DLT45 { get; set; }
        public string DLM75 { get; set; }
        public string DLT75 { get; set; }
        public string DLM110 { get; set; }
        public string DLT110 { get; set; }
        public string DLM25_2 { get; set; }
        public string DLT25_2 { get; set; }
        public string DLM45_2 { get; set; }
        public string DLT45_2 { get; set; }
        public string DLM75_2 { get; set; }
        public string DLT75_2 { get; set; }
        public string DLM110_2 { get; set; }
        public string DLT110_2 { get; set; }
        public string DLM25_3 { get; set; }
        public string DLT25_3 { get; set; }
        public string DLM45_3 { get; set; }
        public string DLT45_3 { get; set; }
        public string DLM75_3 { get; set; }
        public string DLT75_3 { get; set; }
        public string DLM110_3 { get; set; }
        public string DLT110_3 { get; set; }
        public string TCF3_CAT { get; set; }
        public Nullable<System.DateTime> TCF3_DATE_CAT { get; set; }
        public string TDF3_CA_VERIFIED { get; set; }
        public string TDF3_F_ACTION_TAKEN { get; set; }
        public Nullable<System.DateTime> TDF3_F_ACTION_DATE { get; set; }
        public Nullable<bool> TDF3_F_ACTION_NEEDED { get; set; }
        public Nullable<System.DateTime> TDF3_DATE_CA_VERIFIED { get; set; }
        public byte[] timestamp_test { get; set; }
        public string T_An_dol_amt { get; set; }
        public string P_An_dol_amt { get; set; }
        public string atrisk { get; set; }
        public string claim { get; set; }
        public string comments { get; set; }
        public Nullable<bool> Prod_Critical { get; set; }
        public string Serv_Customer { get; set; }
        public Nullable<bool> Cust_Risk { get; set; }
        public Nullable<bool> Cust_Claim { get; set; }
        public Nullable<double> USdollar_Value { get; set; }
        public Nullable<double> FinalImpact { get; set; }
        public Nullable<double> YTD_Sales_Cust { get; set; }
        public Nullable<double> YTD_Fcast_Cust { get; set; }
        public Nullable<double> YTD_BetWor { get; set; }
        public string Global_Loc { get; set; }
        public Nullable<double> lot1_qty { get; set; }
        public string lot1_uom { get; set; }
        public Nullable<double> lot2_qty { get; set; }
        public string lot2_uom { get; set; }
        public Nullable<double> lot3_qty { get; set; }
        public string lot3_uom { get; set; }
        public string en_ship_key { get; set; }
    }
}
