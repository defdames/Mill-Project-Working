using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Complaint_SummaryMap : EntityTypeConfiguration<Complaint_Summary>
    {
        public Complaint_SummaryMap()
        {
            // Primary Key
            this.HasKey(t => t.TC_Num);

            // Properties
            this.Property(t => t.ID_Agent_Name)
                .HasMaxLength(50);

            this.Property(t => t.ID_Agent_Location)
                .HasMaxLength(50);

            this.Property(t => t.Submitter)
                .HasMaxLength(50);

            this.Property(t => t.Customer_Name)
                .HasMaxLength(50);

            this.Property(t => t.Customer_Rep)
                .HasMaxLength(50);

            this.Property(t => t.Address_Line_1)
                .HasMaxLength(50);

            this.Property(t => t.Address_Line_2)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.Zip)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            this.Property(t => t.Customer_Telephone)
                .HasMaxLength(50);

            this.Property(t => t.Customer_Facsimile)
                .HasMaxLength(50);

            this.Property(t => t.Tech_Serv_Sign_Off)
                .HasMaxLength(50);

            this.Property(t => t.Grede_1_ID)
                .HasMaxLength(50);

            this.Property(t => t.Grade_1_Lot_No)
                .HasMaxLength(50);

            this.Property(t => t.Grade_1_Duplicate_Lot2)
                .HasMaxLength(50);

            this.Property(t => t.Grade_1_Duplicate_Lot3)
                .HasMaxLength(50);

            this.Property(t => t.Original_NV_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Retain_NV_Lot_1_)
                .HasMaxLength(50);

            this.Property(t => t.Stock_NV_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Return_NV_Lot_1_)
                .HasMaxLength(50);

            this.Property(t => t.Original___Leafing)
                .HasMaxLength(50);

            this.Property(t => t.Retain___Leafing)
                .HasMaxLength(50);

            this.Property(t => t.Stock___Leafing)
                .HasMaxLength(50);

            this.Property(t => t.Return___Leafing)
                .HasMaxLength(50);

            this.Property(t => t.Original_D10_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Original_D50_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Original_D90_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Original_200_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Original_325_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Original_400_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Original_500_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Retain_D10_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Retain_D50_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Retain_D90_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Retain_200_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Retain_325_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Retain_400_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Retain_500_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Stock_D10_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Stock_D50_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Stock_D90_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Stock_200_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Stock_325_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Stock_400_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Stock_500_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Return_D10_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Return_D50_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Return_D90_PS_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Return_200_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Return_325_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Return_400_MEsh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Return_500_Mesh_Lot_1)
                .HasMaxLength(50);

            this.Property(t => t.Type_of_Complaint)
                .HasMaxLength(50);

            this.Property(t => t.Reason_for_Complaint)
                .HasMaxLength(50);

            this.Property(t => t.Person_s__Handling_Complaint)
                .HasMaxLength(50);

            this.Property(t => t.Is_Material_in_Spec)
                .HasMaxLength(50);

            this.Property(t => t.QA_Representative)
                .HasMaxLength(50);

            this.Property(t => t.Root_Cause_Determination_Rep)
                .HasMaxLength(50);

            this.Property(t => t.Permanent_CA_Taken)
                .HasMaxLength(50);

            this.Property(t => t.Complaint_Resolved_Sign_Off)
                .HasMaxLength(50);

            this.Property(t => t.Original_NV_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Retain_NV_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Stock_NV_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Return_NV_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Original___Leafing_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Retain___Leafing_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Stock___Leafing_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Return___Leafing_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Original_D10_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Original_D50_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Original_D90_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Original_200_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Original_325_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Original_400_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Original_500_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Retain_D10_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Retain_D50_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Retain_D90_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Retain_200_Mesh__Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Retain_325_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Retain_400_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Retain_500_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Stock_D10_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Stock_D50_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Stock_D90_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Stock_200_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Stock_325_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Stock_400_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Stock_500_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Return_D10_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Return_D50_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Return_D90_PS_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Return_200_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Return_325_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Return_400_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Return_500_Mesh_Lot_2)
                .HasMaxLength(50);

            this.Property(t => t.Original_NV_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Retain_NV_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Stock_NV_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Return_NV_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Original___Leafing_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Retain___Leafing_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Stock___Leafing_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Return___Leafing_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Original_D10_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Original_D50_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Original_D90_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Retain_D10_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Retain_D50_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Retain_D90_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Stock_D10_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Stock_D50_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Stock_D90_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Stock_200_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Stock_325_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Stock_400_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Stock_500_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Original_200_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Original_325_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Original_400_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Original_500_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Retain_200_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Retain_325_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Retain_400_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Retain_500_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Return_D10_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Return_D50_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Return_D90_PS_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Return_200_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Return_325_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Return_400_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Return_500_Mesh_Lot_3)
                .HasMaxLength(50);

            this.Property(t => t.Reg_Mgr_TS_Rep_Sign_Off)
                .HasMaxLength(50);

            this.Property(t => t.Tech_Serv_Rep_Sign_Off)
                .HasMaxLength(50);

            this.Property(t => t.RegMgr_OR_Tec_Serv_Rep_Status_Sign_Off)
                .HasMaxLength(50);

            this.Property(t => t.Current_Year)
                .HasMaxLength(50);

            this.Property(t => t.Dry_Paste_Description)
                .HasMaxLength(50);

            this.Property(t => t.Dry_Paste_Description2)
                .HasMaxLength(50);

            this.Property(t => t.Dry_Paste_Description3)
                .HasMaxLength(50);

            this.Property(t => t.Complaint_Origination)
                .HasMaxLength(50);

            this.Property(t => t.Return_Authorization_Number)
                .HasMaxLength(50);

            this.Property(t => t.Technical_Service_Rep)
                .HasMaxLength(50);

            this.Property(t => t.Market)
                .HasMaxLength(50);

            this.Property(t => t.Valid)
                .HasMaxLength(50);

            this.Property(t => t.Consignment_verified_by)
                .HasMaxLength(50);

            this.Property(t => t.contact_made_by)
                .HasMaxLength(50);

            this.Property(t => t.T_S_Rep)
                .HasMaxLength(50);

            this.Property(t => t.Sales_Zone)
                .HasMaxLength(50);

            this.Property(t => t.Paste_or_Post)
                .HasMaxLength(50);

            this.Property(t => t.DLM25)
                .HasMaxLength(50);

            this.Property(t => t.DLT25)
                .HasMaxLength(50);

            this.Property(t => t.DLM45)
                .HasMaxLength(50);

            this.Property(t => t.DLT45)
                .HasMaxLength(50);

            this.Property(t => t.DLM75)
                .HasMaxLength(50);

            this.Property(t => t.DLT75)
                .HasMaxLength(50);

            this.Property(t => t.DLM110)
                .HasMaxLength(50);

            this.Property(t => t.DLT110)
                .HasMaxLength(50);

            this.Property(t => t.DLM25_2)
                .HasMaxLength(50);

            this.Property(t => t.DLT25_2)
                .HasMaxLength(50);

            this.Property(t => t.DLM45_2)
                .HasMaxLength(50);

            this.Property(t => t.DLT45_2)
                .HasMaxLength(50);

            this.Property(t => t.DLM75_2)
                .HasMaxLength(50);

            this.Property(t => t.DLT75_2)
                .HasMaxLength(50);

            this.Property(t => t.DLM110_2)
                .HasMaxLength(50);

            this.Property(t => t.DLT110_2)
                .HasMaxLength(50);

            this.Property(t => t.DLM25_3)
                .HasMaxLength(50);

            this.Property(t => t.DLT25_3)
                .HasMaxLength(50);

            this.Property(t => t.DLM45_3)
                .HasMaxLength(50);

            this.Property(t => t.DLT45_3)
                .HasMaxLength(50);

            this.Property(t => t.DLM75_3)
                .HasMaxLength(50);

            this.Property(t => t.DLT75_3)
                .HasMaxLength(50);

            this.Property(t => t.DLM110_3)
                .HasMaxLength(50);

            this.Property(t => t.DLT110_3)
                .HasMaxLength(50);

            this.Property(t => t.TDF3_CA_VERIFIED)
                .HasMaxLength(50);

            this.Property(t => t.timestamp_test)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            this.Property(t => t.T_An_dol_amt)
                .HasMaxLength(50);

            this.Property(t => t.P_An_dol_amt)
                .HasMaxLength(50);

            this.Property(t => t.atrisk)
                .HasMaxLength(50);

            this.Property(t => t.claim)
                .HasMaxLength(50);

            this.Property(t => t.Serv_Customer)
                .HasMaxLength(1000);

            this.Property(t => t.Global_Loc)
                .HasMaxLength(1000);

            this.Property(t => t.lot1_uom)
                .HasMaxLength(2);

            this.Property(t => t.lot2_uom)
                .HasMaxLength(2);

            this.Property(t => t.lot3_uom)
                .HasMaxLength(2);

            this.Property(t => t.en_ship_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Complaint Summary");
            this.Property(t => t.Confirm_).HasColumnName("Confirm?");
            this.Property(t => t.Lab_Valid_).HasColumnName("Lab Valid?");
            this.Property(t => t.TC_Num).HasColumnName("TC Num");
            this.Property(t => t.ID_Agent_Name).HasColumnName("ID Agent Name");
            this.Property(t => t.ID_Agent_Location).HasColumnName("ID Agent Location");
            this.Property(t => t.Date_Rec_d).HasColumnName("Date Rec'd");
            this.Property(t => t.Submitter).HasColumnName("Submitter");
            this.Property(t => t.Customer_Name).HasColumnName("Customer Name");
            this.Property(t => t.Customer_Rep).HasColumnName("Customer Rep");
            this.Property(t => t.Address_Line_1).HasColumnName("Address Line 1");
            this.Property(t => t.Address_Line_2).HasColumnName("Address Line 2");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Customer_Telephone).HasColumnName("Customer Telephone");
            this.Property(t => t.Customer_Facsimile).HasColumnName("Customer Facsimile");
            this.Property(t => t.Tech_Serv_Activity).HasColumnName("Tech Serv Activity");
            this.Property(t => t.Tech_Serv_Sign_Off).HasColumnName("Tech Serv Sign-Off");
            this.Property(t => t.Mat_l_Returned_).HasColumnName("Mat'l Returned?");
            this.Property(t => t.Grede_1_ID).HasColumnName("Grede 1 ID");
            this.Property(t => t.Grade_1_Lot_No).HasColumnName("Grade 1 Lot No");
            this.Property(t => t.Grade_1_Duplicate_Lot2).HasColumnName("Grade 1 Duplicate Lot2");
            this.Property(t => t.Grade_1_Duplicate_Lot3).HasColumnName("Grade 1 Duplicate Lot3");
            this.Property(t => t.Grade_1_Description).HasColumnName("Grade 1 Description");
            this.Property(t => t.Grade_1_Interim_Corrective_Action).HasColumnName("Grade 1 Interim Corrective Action");
            this.Property(t => t.Tech_Serv_Act_Date).HasColumnName("Tech Serv Act Date");
            this.Property(t => t.Original_NV_Lot_1).HasColumnName("Original NV Lot 1");
            this.Property(t => t.Retain_NV_Lot_1_).HasColumnName("Retain NV Lot 1%");
            this.Property(t => t.Stock_NV_Lot_1).HasColumnName("Stock NV Lot 1");
            this.Property(t => t.Return_NV_Lot_1_).HasColumnName("Return NV Lot 1%");
            this.Property(t => t.Original___Leafing).HasColumnName("Original % Leafing");
            this.Property(t => t.Retain___Leafing).HasColumnName("Retain % Leafing");
            this.Property(t => t.Stock___Leafing).HasColumnName("Stock % Leafing");
            this.Property(t => t.Return___Leafing).HasColumnName("Return % Leafing");
            this.Property(t => t.Original_D10_PS_Lot_1).HasColumnName("Original D10 PS Lot 1");
            this.Property(t => t.Original_D50_PS_Lot_1).HasColumnName("Original D50 PS Lot 1");
            this.Property(t => t.Original_D90_PS_Lot_1).HasColumnName("Original D90 PS Lot 1");
            this.Property(t => t.Original_200_Mesh_Lot_1).HasColumnName("Original 200 Mesh Lot 1");
            this.Property(t => t.Original_325_Mesh_Lot_1).HasColumnName("Original 325 Mesh Lot 1");
            this.Property(t => t.Original_400_Mesh_Lot_1).HasColumnName("Original 400 Mesh Lot 1");
            this.Property(t => t.Original_500_Mesh_Lot_1).HasColumnName("Original 500 Mesh Lot 1");
            this.Property(t => t.Retain_D10_PS_Lot_1).HasColumnName("Retain D10 PS Lot 1");
            this.Property(t => t.Retain_D50_PS_Lot_1).HasColumnName("Retain D50 PS Lot 1");
            this.Property(t => t.Retain_D90_PS_Lot_1).HasColumnName("Retain D90 PS Lot 1");
            this.Property(t => t.Retain_200_Mesh_Lot_1).HasColumnName("Retain 200 Mesh Lot 1");
            this.Property(t => t.Retain_325_Mesh_Lot_1).HasColumnName("Retain 325 Mesh Lot 1");
            this.Property(t => t.Retain_400_Mesh_Lot_1).HasColumnName("Retain 400 Mesh Lot 1");
            this.Property(t => t.Retain_500_Mesh_Lot_1).HasColumnName("Retain 500 Mesh Lot 1");
            this.Property(t => t.Stock_D10_PS_Lot_1).HasColumnName("Stock D10 PS Lot 1");
            this.Property(t => t.Stock_D50_PS_Lot_1).HasColumnName("Stock D50 PS Lot 1");
            this.Property(t => t.Stock_D90_PS_Lot_1).HasColumnName("Stock D90 PS Lot 1");
            this.Property(t => t.Stock_200_Mesh_Lot_1).HasColumnName("Stock 200 Mesh Lot 1");
            this.Property(t => t.Stock_325_Mesh_Lot_1).HasColumnName("Stock 325 Mesh Lot 1");
            this.Property(t => t.Stock_400_Mesh_Lot_1).HasColumnName("Stock 400 Mesh Lot 1");
            this.Property(t => t.Stock_500_Mesh_Lot_1).HasColumnName("Stock 500 Mesh Lot 1");
            this.Property(t => t.Return_D10_PS_Lot_1).HasColumnName("Return D10 PS Lot 1");
            this.Property(t => t.Return_D50_PS_Lot_1).HasColumnName("Return D50 PS Lot 1");
            this.Property(t => t.Return_D90_PS_Lot_1).HasColumnName("Return D90 PS Lot 1");
            this.Property(t => t.Return_200_Mesh_Lot_1).HasColumnName("Return 200 Mesh Lot 1");
            this.Property(t => t.Return_325_Mesh_Lot_1).HasColumnName("Return 325 Mesh Lot 1");
            this.Property(t => t.Return_400_MEsh_Lot_1).HasColumnName("Return 400 MEsh Lot 1");
            this.Property(t => t.Return_500_Mesh_Lot_1).HasColumnName("Return 500 Mesh Lot 1");
            this.Property(t => t.Test_Result_Comments_Lot_1).HasColumnName("Test Result Comments Lot 1");
            this.Property(t => t.Root_Cause).HasColumnName("Root Cause");
            this.Property(t => t.Permanent_Corrective_Action).HasColumnName("Permanent Corrective Action");
            this.Property(t => t.Type_of_Complaint).HasColumnName("Type of Complaint");
            this.Property(t => t.Reason_for_Complaint).HasColumnName("Reason for Complaint");
            this.Property(t => t.Person_s__Handling_Complaint).HasColumnName("Person(s) Handling Complaint");
            this.Property(t => t.Is_Material_in_Spec).HasColumnName("Is Material in Spec");
            this.Property(t => t.QA_Representative).HasColumnName("QA Representative");
            this.Property(t => t.QA_Rep_Date).HasColumnName("QA Rep Date");
            this.Property(t => t.Root_Cause_Determination_Rep).HasColumnName("Root Cause Determination Rep");
            this.Property(t => t.Root_Cause_Date).HasColumnName("Root Cause Date");
            this.Property(t => t.Permanent_CA_Taken).HasColumnName("Permanent CA Taken");
            this.Property(t => t.Permanent_CA_Date).HasColumnName("Permanent CA Date");
            this.Property(t => t.Customer_Notification).HasColumnName("Customer Notification");
            this.Property(t => t.Complaint_Resolved_Sign_Off).HasColumnName("Complaint Resolved Sign Off");
            this.Property(t => t.Complaint_Resolved_Sign_Off_Date).HasColumnName("Complaint Resolved Sign Off Date");
            this.Property(t => t.Agent_Nos).HasColumnName("Agent Nos");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID2).HasColumnName("ID2");
            this.Property(t => t.Original_NV_Lot_2).HasColumnName("Original NV Lot 2");
            this.Property(t => t.Retain_NV_Lot_2).HasColumnName("Retain NV Lot 2");
            this.Property(t => t.Stock_NV_Lot_2).HasColumnName("Stock NV Lot 2");
            this.Property(t => t.Return_NV_Lot_2).HasColumnName("Return NV Lot 2");
            this.Property(t => t.Original___Leafing_Lot_2).HasColumnName("Original % Leafing Lot 2");
            this.Property(t => t.Retain___Leafing_Lot_2).HasColumnName("Retain % Leafing Lot 2");
            this.Property(t => t.Stock___Leafing_Lot_2).HasColumnName("Stock % Leafing Lot 2");
            this.Property(t => t.Return___Leafing_Lot_2).HasColumnName("Return % Leafing Lot 2");
            this.Property(t => t.Original_D10_PS_Lot_2).HasColumnName("Original D10 PS Lot 2");
            this.Property(t => t.Original_D50_PS_Lot_2).HasColumnName("Original D50 PS Lot 2");
            this.Property(t => t.Original_D90_PS_Lot_2).HasColumnName("Original D90 PS Lot 2");
            this.Property(t => t.Original_200_Mesh_Lot_2).HasColumnName("Original 200 Mesh Lot 2");
            this.Property(t => t.Original_325_Mesh_Lot_2).HasColumnName("Original 325 Mesh Lot 2");
            this.Property(t => t.Original_400_Mesh_Lot_2).HasColumnName("Original 400 Mesh Lot 2");
            this.Property(t => t.Original_500_Mesh_Lot_2).HasColumnName("Original 500 Mesh Lot 2");
            this.Property(t => t.Retain_D10_PS_Lot_2).HasColumnName("Retain D10 PS Lot 2");
            this.Property(t => t.Retain_D50_PS_Lot_2).HasColumnName("Retain D50 PS Lot 2");
            this.Property(t => t.Retain_D90_PS_Lot_2).HasColumnName("Retain D90 PS Lot 2");
            this.Property(t => t.Retain_200_Mesh__Lot_2).HasColumnName("Retain 200 Mesh  Lot 2");
            this.Property(t => t.Retain_325_Mesh_Lot_2).HasColumnName("Retain 325 Mesh Lot 2");
            this.Property(t => t.Retain_400_Mesh_Lot_2).HasColumnName("Retain 400 Mesh Lot 2");
            this.Property(t => t.Retain_500_Mesh_Lot_2).HasColumnName("Retain 500 Mesh Lot 2");
            this.Property(t => t.Stock_D10_PS_Lot_2).HasColumnName("Stock D10 PS Lot 2");
            this.Property(t => t.Stock_D50_PS_Lot_2).HasColumnName("Stock D50 PS Lot 2");
            this.Property(t => t.Stock_D90_PS_Lot_2).HasColumnName("Stock D90 PS Lot 2");
            this.Property(t => t.Stock_200_Mesh_Lot_2).HasColumnName("Stock 200 Mesh Lot 2");
            this.Property(t => t.Stock_325_Mesh_Lot_2).HasColumnName("Stock 325 Mesh Lot 2");
            this.Property(t => t.Stock_400_Mesh_Lot_2).HasColumnName("Stock 400 Mesh Lot 2");
            this.Property(t => t.Stock_500_Mesh_Lot_2).HasColumnName("Stock 500 Mesh Lot 2");
            this.Property(t => t.Return_D10_PS_Lot_2).HasColumnName("Return D10 PS Lot 2");
            this.Property(t => t.Return_D50_PS_Lot_2).HasColumnName("Return D50 PS Lot 2");
            this.Property(t => t.Return_D90_PS_Lot_2).HasColumnName("Return D90 PS Lot 2");
            this.Property(t => t.Return_200_Mesh_Lot_2).HasColumnName("Return 200 Mesh Lot 2");
            this.Property(t => t.Return_325_Mesh_Lot_2).HasColumnName("Return 325 Mesh Lot 2");
            this.Property(t => t.Return_400_Mesh_Lot_2).HasColumnName("Return 400 Mesh Lot 2");
            this.Property(t => t.Return_500_Mesh_Lot_2).HasColumnName("Return 500 Mesh Lot 2");
            this.Property(t => t.Test_Result_Comments_Lot_2).HasColumnName("Test Result Comments Lot 2");
            this.Property(t => t.Original_NV_Lot_3).HasColumnName("Original NV Lot 3");
            this.Property(t => t.Retain_NV_Lot_3).HasColumnName("Retain NV Lot 3");
            this.Property(t => t.Stock_NV_Lot_3).HasColumnName("Stock NV Lot 3");
            this.Property(t => t.Return_NV_Lot_3).HasColumnName("Return NV Lot 3");
            this.Property(t => t.Original___Leafing_Lot_3).HasColumnName("Original % Leafing Lot 3");
            this.Property(t => t.Retain___Leafing_Lot_3).HasColumnName("Retain % Leafing Lot 3");
            this.Property(t => t.Stock___Leafing_Lot_3).HasColumnName("Stock % Leafing Lot 3");
            this.Property(t => t.Return___Leafing_Lot_3).HasColumnName("Return % Leafing Lot 3");
            this.Property(t => t.Original_D10_PS_Lot_3).HasColumnName("Original D10 PS Lot 3");
            this.Property(t => t.Original_D50_PS_Lot_3).HasColumnName("Original D50 PS Lot 3");
            this.Property(t => t.Original_D90_PS_Lot_3).HasColumnName("Original D90 PS Lot 3");
            this.Property(t => t.Retain_D10_PS_Lot_3).HasColumnName("Retain D10 PS Lot 3");
            this.Property(t => t.Retain_D50_PS_Lot_3).HasColumnName("Retain D50 PS Lot 3");
            this.Property(t => t.Retain_D90_PS_Lot_3).HasColumnName("Retain D90 PS Lot 3");
            this.Property(t => t.Stock_D10_PS_Lot_3).HasColumnName("Stock D10 PS Lot 3");
            this.Property(t => t.Stock_D50_PS_Lot_3).HasColumnName("Stock D50 PS Lot 3");
            this.Property(t => t.Stock_D90_PS_Lot_3).HasColumnName("Stock D90 PS Lot 3");
            this.Property(t => t.Stock_200_Mesh_Lot_3).HasColumnName("Stock 200 Mesh Lot 3");
            this.Property(t => t.Stock_325_Mesh_Lot_3).HasColumnName("Stock 325 Mesh Lot 3");
            this.Property(t => t.Stock_400_Mesh_Lot_3).HasColumnName("Stock 400 Mesh Lot 3");
            this.Property(t => t.Stock_500_Mesh_Lot_3).HasColumnName("Stock 500 Mesh Lot 3");
            this.Property(t => t.Original_200_Mesh_Lot_3).HasColumnName("Original 200 Mesh Lot 3");
            this.Property(t => t.Original_325_Mesh_Lot_3).HasColumnName("Original 325 Mesh Lot 3");
            this.Property(t => t.Original_400_Mesh_Lot_3).HasColumnName("Original 400 Mesh Lot 3");
            this.Property(t => t.Original_500_Mesh_Lot_3).HasColumnName("Original 500 Mesh Lot 3");
            this.Property(t => t.Retain_200_Mesh_Lot_3).HasColumnName("Retain 200 Mesh Lot 3");
            this.Property(t => t.Retain_325_Mesh_Lot_3).HasColumnName("Retain 325 Mesh Lot 3");
            this.Property(t => t.Retain_400_Mesh_Lot_3).HasColumnName("Retain 400 Mesh Lot 3");
            this.Property(t => t.Retain_500_Mesh_Lot_3).HasColumnName("Retain 500 Mesh Lot 3");
            this.Property(t => t.Return_D10_PS_Lot_3).HasColumnName("Return D10 PS Lot 3");
            this.Property(t => t.Return_D50_PS_Lot_3).HasColumnName("Return D50 PS Lot 3");
            this.Property(t => t.Return_D90_PS_Lot_3).HasColumnName("Return D90 PS Lot 3");
            this.Property(t => t.Return_200_Mesh_Lot_3).HasColumnName("Return 200 Mesh Lot 3");
            this.Property(t => t.Return_325_Mesh_Lot_3).HasColumnName("Return 325 Mesh Lot 3");
            this.Property(t => t.Return_400_Mesh_Lot_3).HasColumnName("Return 400 Mesh Lot 3");
            this.Property(t => t.Return_500_Mesh_Lot_3).HasColumnName("Return 500 Mesh Lot 3");
            this.Property(t => t.Test_Result_Comments_Lot_3).HasColumnName("Test Result Comments Lot 3");
            this.Property(t => t.Complaint_Resolved_Date).HasColumnName("Complaint Resolved Date");
            this.Property(t => t.Complaint_Resolution_Notification_to_Customer).HasColumnName("Complaint Resolution Notification to Customer");
            this.Property(t => t.Reg_Mgr_TS_Rep_Sign_Off).HasColumnName("Reg Mgr TS Rep Sign Off");
            this.Property(t => t.Tech_Serv_Rep_Sign_Off).HasColumnName("Tech Serv Rep Sign Off");
            this.Property(t => t.RegMgr_OR_Tec_Serv_Rep_Status_Sign_Off).HasColumnName("RegMgr OR Tec Serv Rep Status Sign Off");
            this.Property(t => t.Tech_Serv_Activity_Date_Sign_Off).HasColumnName("Tech Serv Activity Date Sign Off");
            this.Property(t => t.Current_Year).HasColumnName("Current Year");
            this.Property(t => t.Dry_Paste_Description).HasColumnName("Dry Paste Description");
            this.Property(t => t.Dry_Paste_Description2).HasColumnName("Dry Paste Description2");
            this.Property(t => t.Dry_Paste_Description3).HasColumnName("Dry Paste Description3");
            this.Property(t => t.Solvent_Acid_Number).HasColumnName("Solvent Acid Number");
            this.Property(t => t.Solvent_Acid_Number2).HasColumnName("Solvent Acid Number2");
            this.Property(t => t.Solvent_Acid_Number3).HasColumnName("Solvent Acid Number3");
            this.Property(t => t.Packability_Index).HasColumnName("Packability Index");
            this.Property(t => t.Packability_Index2).HasColumnName("Packability Index2");
            this.Property(t => t.Packability_Index3).HasColumnName("Packability Index3");
            this.Property(t => t.Complaint_Origination).HasColumnName("Complaint Origination");
            this.Property(t => t.Tech_Attachment).HasColumnName("Tech Attachment");
            this.Property(t => t.Confirm_Findings_Lot_1_Original).HasColumnName("Confirm Findings Lot 1-Original");
            this.Property(t => t.Confirm_Findings_Lot_1_Retain).HasColumnName("Confirm Findings Lot 1-Retain");
            this.Property(t => t.Confirm_Findings_Lot_1_Stock).HasColumnName("Confirm Findings Lot 1-Stock");
            this.Property(t => t.Confirm_Findings_Lot_1_Return).HasColumnName("Confirm Findings Lot 1-Return");
            this.Property(t => t.Confirm_Findings_Lot_2_Original).HasColumnName("Confirm Findings Lot 2-Original");
            this.Property(t => t.Confirm_Findings_Lot_2_Retain).HasColumnName("Confirm Findings Lot 2-Retain");
            this.Property(t => t.Confirm_Findings_Lot_2_Stock).HasColumnName("Confirm Findings Lot 2-Stock");
            this.Property(t => t.Confirm_Findings_Lot_2_Return).HasColumnName("Confirm Findings Lot 2-Return");
            this.Property(t => t.Confirm_Findings_Lot_3_Original).HasColumnName("Confirm Findings Lot 3-Original");
            this.Property(t => t.Confirm_Findings_Lot_3_Retain).HasColumnName("Confirm Findings Lot 3-Retain");
            this.Property(t => t.Confirm_Findings_Lot_3_Stock).HasColumnName("Confirm Findings Lot 3-Stock");
            this.Property(t => t.Confirm_Findings_Lot_3_Return).HasColumnName("Confirm Findings Lot 3-Return");
            this.Property(t => t.Return_Authorization_Number).HasColumnName("Return Authorization Number");
            this.Property(t => t.Technical_Service_Rep).HasColumnName("Technical Service Rep");
            this.Property(t => t.Market).HasColumnName("Market");
            this.Property(t => t.Material_Placed_on_Hold).HasColumnName("Material Placed on Hold");
            this.Property(t => t.QA_Release_Date).HasColumnName("QA Release Date");
            this.Property(t => t.Valid).HasColumnName("Valid");
            this.Property(t => t.Consignment_verified_by).HasColumnName("Consignment verified by");
            this.Property(t => t.contact_made_by).HasColumnName("contact made by");
            this.Property(t => t.T_S_Rep).HasColumnName("T_S Rep");
            this.Property(t => t.Sales_Zone).HasColumnName("Sales Zone");
            this.Property(t => t.Paste_or_Post).HasColumnName("Paste or Post");
            this.Property(t => t.DLM25).HasColumnName("DLM25");
            this.Property(t => t.DLT25).HasColumnName("DLT25");
            this.Property(t => t.DLM45).HasColumnName("DLM45");
            this.Property(t => t.DLT45).HasColumnName("DLT45");
            this.Property(t => t.DLM75).HasColumnName("DLM75");
            this.Property(t => t.DLT75).HasColumnName("DLT75");
            this.Property(t => t.DLM110).HasColumnName("DLM110");
            this.Property(t => t.DLT110).HasColumnName("DLT110");
            this.Property(t => t.DLM25_2).HasColumnName("DLM25_2");
            this.Property(t => t.DLT25_2).HasColumnName("DLT25_2");
            this.Property(t => t.DLM45_2).HasColumnName("DLM45_2");
            this.Property(t => t.DLT45_2).HasColumnName("DLT45_2");
            this.Property(t => t.DLM75_2).HasColumnName("DLM75_2");
            this.Property(t => t.DLT75_2).HasColumnName("DLT75_2");
            this.Property(t => t.DLM110_2).HasColumnName("DLM110_2");
            this.Property(t => t.DLT110_2).HasColumnName("DLT110_2");
            this.Property(t => t.DLM25_3).HasColumnName("DLM25_3");
            this.Property(t => t.DLT25_3).HasColumnName("DLT25_3");
            this.Property(t => t.DLM45_3).HasColumnName("DLM45_3");
            this.Property(t => t.DLT45_3).HasColumnName("DLT45_3");
            this.Property(t => t.DLM75_3).HasColumnName("DLM75_3");
            this.Property(t => t.DLT75_3).HasColumnName("DLT75_3");
            this.Property(t => t.DLM110_3).HasColumnName("DLM110_3");
            this.Property(t => t.DLT110_3).HasColumnName("DLT110_3");
            this.Property(t => t.TCF3_CAT).HasColumnName("TCF3 CAT");
            this.Property(t => t.TCF3_DATE_CAT).HasColumnName("TCF3 DATE CAT");
            this.Property(t => t.TDF3_CA_VERIFIED).HasColumnName("TDF3 CA VERIFIED");
            this.Property(t => t.TDF3_F_ACTION_TAKEN).HasColumnName("TDF3 F ACTION TAKEN");
            this.Property(t => t.TDF3_F_ACTION_DATE).HasColumnName("TDF3 F ACTION DATE");
            this.Property(t => t.TDF3_F_ACTION_NEEDED).HasColumnName("TDF3 F ACTION NEEDED");
            this.Property(t => t.TDF3_DATE_CA_VERIFIED).HasColumnName("TDF3 DATE CA VERIFIED");
            this.Property(t => t.timestamp_test).HasColumnName("timestamp_test");
            this.Property(t => t.T_An_dol_amt).HasColumnName("T_An_dol_amt");
            this.Property(t => t.P_An_dol_amt).HasColumnName("P_An_dol_amt");
            this.Property(t => t.atrisk).HasColumnName("atrisk");
            this.Property(t => t.claim).HasColumnName("claim");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.Prod_Critical).HasColumnName("Prod_Critical");
            this.Property(t => t.Serv_Customer).HasColumnName("Serv_Customer");
            this.Property(t => t.Cust_Risk).HasColumnName("Cust_Risk");
            this.Property(t => t.Cust_Claim).HasColumnName("Cust_Claim");
            this.Property(t => t.USdollar_Value).HasColumnName("USdollar_Value");
            this.Property(t => t.FinalImpact).HasColumnName("FinalImpact");
            this.Property(t => t.YTD_Sales_Cust).HasColumnName("YTD_Sales_Cust");
            this.Property(t => t.YTD_Fcast_Cust).HasColumnName("YTD_Fcast_Cust");
            this.Property(t => t.YTD_BetWor).HasColumnName("YTD_BetWor");
            this.Property(t => t.Global_Loc).HasColumnName("Global_Loc");
            this.Property(t => t.lot1_qty).HasColumnName("lot1_qty");
            this.Property(t => t.lot1_uom).HasColumnName("lot1_uom");
            this.Property(t => t.lot2_qty).HasColumnName("lot2_qty");
            this.Property(t => t.lot2_uom).HasColumnName("lot2_uom");
            this.Property(t => t.lot3_qty).HasColumnName("lot3_qty");
            this.Property(t => t.lot3_uom).HasColumnName("lot3_uom");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
        }
    }
}
