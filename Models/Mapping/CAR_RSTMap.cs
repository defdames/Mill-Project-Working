using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CAR_RSTMap : EntityTypeConfiguration<CAR_RST>
    {
        public CAR_RSTMap()
        {
            // Primary Key
            this.HasKey(t => t.Car_No);

            // Properties
            this.Property(t => t.Issued_By)
                .HasMaxLength(255);

            this.Property(t => t.Status)
                .HasMaxLength(255);

            this.Property(t => t.Closed_out_by)
                .HasMaxLength(255);

            this.Property(t => t.Grade_Name)
                .HasMaxLength(255);

            this.Property(t => t.Lot_Number)
                .HasMaxLength(255);

            this.Property(t => t.System_Used)
                .HasMaxLength(255);

            this.Property(t => t.Plant_Location)
                .HasMaxLength(255);

            this.Property(t => t.Corrective_and_Preventive_Action)
                .HasMaxLength(5000);

            this.Property(t => t.Field14)
                .HasMaxLength(255);

            this.Property(t => t.Moisture)
                .HasMaxLength(50);

            this.Property(t => t.Non_Volatile)
                .HasMaxLength(50);

            this.Property(t => t.Malvern)
                .HasMaxLength(50);

            this.Property(t => t.Screen_200)
                .HasMaxLength(50);

            this.Property(t => t.Screen_325)
                .HasMaxLength(50);

            this.Property(t => t.Screen_400)
                .HasMaxLength(50);

            this.Property(t => t.Screen_500)
                .HasMaxLength(50);

            this.Property(t => t.dept_area_process)
                .HasMaxLength(50);

            this.Property(t => t.CA_responsible)
                .HasMaxLength(50);

            this.Property(t => t.verification_timeframe)
                .HasMaxLength(50);

            this.Property(t => t.reason_for_activities)
                .HasMaxLength(50);

            this.Property(t => t.Intended_Product_2B_Made)
                .HasMaxLength(30);

            this.Property(t => t.Further_Action)
                .HasMaxLength(30);

            this.Property(t => t.Type_of_Verification)
                .HasMaxLength(50);

            this.Property(t => t.Sr_Manager_Review)
                .HasMaxLength(50);

            this.Property(t => t.Secondary_Cause_of_Blend)
                .HasMaxLength(255);

            this.Property(t => t.Tertiary_Cause_of_Blend)
                .HasMaxLength(255);

            this.Property(t => t.Corrective___Preventive_Action_2)
                .HasMaxLength(5000);

            this.Property(t => t.Corrective___Preventive_Action_3)
                .HasMaxLength(5000);

            this.Property(t => t.Corrective___Preventive_Action_4)
                .HasMaxLength(5000);

            this.Property(t => t.Closed_Out_By_2)
                .HasMaxLength(50);

            this.Property(t => t.Closed_Out_By_3)
                .HasMaxLength(50);

            this.Property(t => t.Closed_Out_By_4)
                .HasMaxLength(50);

            this.Property(t => t.verification_timeframe2)
                .HasMaxLength(50);

            this.Property(t => t.verification_timeframe3)
                .HasMaxLength(50);

            this.Property(t => t.verification_timeframe4)
                .HasMaxLength(50);

            this.Property(t => t.CA_Responsible_2)
                .HasMaxLength(50);

            this.Property(t => t.CA_Responsible_3)
                .HasMaxLength(50);

            this.Property(t => t.CA_Responsible_4)
                .HasMaxLength(50);

            this.Property(t => t.CA_Verifier)
                .HasMaxLength(50);

            this.Property(t => t.CA_Verifier2)
                .HasMaxLength(50);

            this.Property(t => t.CA_Verifier3)
                .HasMaxLength(50);

            this.Property(t => t.CA_Verifier4)
                .HasMaxLength(50);

            this.Property(t => t.Further_Action_Required)
                .HasMaxLength(50);

            this.Property(t => t.Further_Action_Required2)
                .HasMaxLength(50);

            this.Property(t => t.Further_Action_Required3)
                .HasMaxLength(50);

            this.Property(t => t.Further_Action_Required4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CAR_RST");
            this.Property(t => t.Issued_By).HasColumnName("Issued By");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Closed_out_by).HasColumnName("Closed out by");
            this.Property(t => t.Closed_out_Date).HasColumnName("Closed out Date");
            this.Property(t => t.Grade_Name).HasColumnName("Grade Name");
            this.Property(t => t.Lot_Number).HasColumnName("Lot Number");
            this.Property(t => t.System_Used).HasColumnName("System Used");
            this.Property(t => t.Amount_Generated).HasColumnName("Amount Generated");
            this.Property(t => t.Plant_Location).HasColumnName("Plant Location");
            this.Property(t => t.Description_of_Problem).HasColumnName("Description of Problem");
            this.Property(t => t.Probable_Cause).HasColumnName("Probable Cause");
            this.Property(t => t.Corrective_and_Preventive_Action).HasColumnName("Corrective and Preventive Action");
            this.Property(t => t.Field14).HasColumnName("Field14");
            this.Property(t => t.C_P_Date).HasColumnName("C@P Date");
            this.Property(t => t.Date_Iniated).HasColumnName("Date Iniated");
            this.Property(t => t.C______).HasColumnName("??????");
            this.Property(t => t.Moisture).HasColumnName("Moisture");
            this.Property(t => t.Non_Volatile).HasColumnName("Non Volatile");
            this.Property(t => t.Malvern).HasColumnName("Malvern");
            this.Property(t => t.Screen_200).HasColumnName("Screen 200");
            this.Property(t => t.Screen_325).HasColumnName("Screen 325");
            this.Property(t => t.Screen_400).HasColumnName("Screen 400");
            this.Property(t => t.Screen_500).HasColumnName("Screen 500");
            this.Property(t => t.Field18).HasColumnName("Field18");
            this.Property(t => t.Car_No).HasColumnName("Car No");
            this.Property(t => t.dept_area_process).HasColumnName("dept_area_process");
            this.Property(t => t.team_members).HasColumnName("team_members");
            this.Property(t => t.investigation_findings_activity).HasColumnName("investigation_findings_activity");
            this.Property(t => t.CA_responsible).HasColumnName("CA_responsible");
            this.Property(t => t.C1Y).HasColumnName("1Y");
            this.Property(t => t.C2Y).HasColumnName("2Y");
            this.Property(t => t.C3Y).HasColumnName("3Y");
            this.Property(t => t.C4Y).HasColumnName("4Y");
            this.Property(t => t.C5Y).HasColumnName("5Y");
            this.Property(t => t.verification_timeframe).HasColumnName("verification_timeframe");
            this.Property(t => t.CA_verify_date).HasColumnName("CA_verify_date");
            this.Property(t => t.reason_for_activities).HasColumnName("reason_for_activities");
            this.Property(t => t.Intended_Product_2B_Made).HasColumnName("Intended Product 2B Made");
            this.Property(t => t.Verifiers_Findings).HasColumnName("Verifiers Findings");
            this.Property(t => t.Further_Action).HasColumnName("Further Action");
            this.Property(t => t.FA_Compliance_Date).HasColumnName("FA Compliance Date");
            this.Property(t => t.Type_of_Verification).HasColumnName("Type of Verification");
            this.Property(t => t.Sr_Manager_Review).HasColumnName("Sr Manager Review");
            this.Property(t => t.Secondary_Cause_of_Blend).HasColumnName("Secondary Cause of Blend");
            this.Property(t => t.Tertiary_Cause_of_Blend).HasColumnName("Tertiary Cause of Blend");
            this.Property(t => t.Corrective___Preventive_Action_2).HasColumnName("Corrective & Preventive Action 2");
            this.Property(t => t.Corrective___Preventive_Action_3).HasColumnName("Corrective & Preventive Action 3");
            this.Property(t => t.Corrective___Preventive_Action_4).HasColumnName("Corrective & Preventive Action 4");
            this.Property(t => t.C_P_Date_2).HasColumnName("C@P Date 2");
            this.Property(t => t.C_P_Date_3).HasColumnName("C@P Date 3");
            this.Property(t => t.C_P_Date_4).HasColumnName("C@P Date 4");
            this.Property(t => t.Closed_Out_By_2).HasColumnName("Closed Out By 2");
            this.Property(t => t.Closed_Out_By_3).HasColumnName("Closed Out By 3");
            this.Property(t => t.Closed_Out_By_4).HasColumnName("Closed Out By 4");
            this.Property(t => t.Closed_Out_Date_2).HasColumnName("Closed Out Date 2");
            this.Property(t => t.Closed_Out_Date_3).HasColumnName("Closed Out Date 3");
            this.Property(t => t.Closed_Out_Date_4).HasColumnName("Closed Out Date 4");
            this.Property(t => t.CA_Verify_Date_2).HasColumnName("CA_Verify Date 2");
            this.Property(t => t.CA_Verify_Date_3).HasColumnName("CA_Verify Date 3");
            this.Property(t => t.CA_Verify_Date_4).HasColumnName("CA_Verify Date 4");
            this.Property(t => t.verification_timeframe2).HasColumnName("verification_timeframe2");
            this.Property(t => t.verification_timeframe3).HasColumnName("verification_timeframe3");
            this.Property(t => t.verification_timeframe4).HasColumnName("verification_timeframe4");
            this.Property(t => t.CA_Responsible_2).HasColumnName("CA_Responsible 2");
            this.Property(t => t.CA_Responsible_3).HasColumnName("CA_Responsible 3");
            this.Property(t => t.CA_Responsible_4).HasColumnName("CA_Responsible 4");
            this.Property(t => t.CA_Verifier).HasColumnName("CA_Verifier");
            this.Property(t => t.CA_Verifier2).HasColumnName("CA_Verifier2");
            this.Property(t => t.CA_Verifier3).HasColumnName("CA_Verifier3");
            this.Property(t => t.CA_Verifier4).HasColumnName("CA_Verifier4");
            this.Property(t => t.Further_Action_Required).HasColumnName("Further Action Required");
            this.Property(t => t.Further_Action_Required2).HasColumnName("Further Action Required2");
            this.Property(t => t.Further_Action_Required3).HasColumnName("Further Action Required3");
            this.Property(t => t.Further_Action_Required4).HasColumnName("Further Action Required4");
            this.Property(t => t.FA_Compliance_Date2).HasColumnName("FA Compliance Date2");
            this.Property(t => t.FA_Compliance_Date3).HasColumnName("FA Compliance Date3");
            this.Property(t => t.FA_Compliance_Date4).HasColumnName("FA Compliance Date4");
            this.Property(t => t.Verifiers_Findings2).HasColumnName("Verifiers Findings2");
            this.Property(t => t.Verifiers_Findings3).HasColumnName("Verifiers Findings3");
            this.Property(t => t.Verifiers_Findings4).HasColumnName("Verifiers Findings4");
        }
    }
}
