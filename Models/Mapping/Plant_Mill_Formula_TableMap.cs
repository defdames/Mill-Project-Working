using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Plant_Mill_Formula_TableMap : EntityTypeConfiguration<Plant_Mill_Formula_Table>
    {
        public Plant_Mill_Formula_TableMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.Plant_ID)
                .HasMaxLength(50);

            this.Property(t => t.System)
                .HasMaxLength(50);

            this.Property(t => t.No_of_Mills)
                .HasMaxLength(50);

            this.Property(t => t.Feed_Type)
                .HasMaxLength(50);

            this.Property(t => t.Oleic)
                .HasMaxLength(50);

            this.Property(t => t.Stearic)
                .HasMaxLength(50);

            this.Property(t => t.Lauric)
                .HasMaxLength(50);

            this.Property(t => t.Initial_Varsol_Added)
                .HasMaxLength(50);

            this.Property(t => t.Slurry_Height)
                .HasMaxLength(50);

            this.Property(t => t.Probe_At)
                .HasMaxLength(50);

            this.Property(t => t.Media_Type)
                .HasMaxLength(50);

            this.Property(t => t.Run_Hrs)
                .HasMaxLength(50);

            this.Property(t => t.Scalper_)
                .HasMaxLength(15);

            this.Property(t => t.Scalper_Mesh)
                .HasMaxLength(15);

            this.Property(t => t.C1st_Pass_)
                .HasMaxLength(15);

            this.Property(t => t.C1st_Pass_Mesh)
                .HasMaxLength(15);

            this.Property(t => t.C2nd_Pass_)
                .HasMaxLength(15);

            this.Property(t => t.C2nd_Pass_Mesh)
                .HasMaxLength(15);

            this.Property(t => t.Check_)
                .HasMaxLength(15);

            this.Property(t => t.Check_Mesh)
                .HasMaxLength(15);

            this.Property(t => t.Std_Production)
                .HasMaxLength(15);

            this.Property(t => t.SpecialT_Code)
                .HasMaxLength(50);

            this.Property(t => t.Dry_Mix_Time)
                .HasMaxLength(50);

            this.Property(t => t.Finished_Mix_Time)
                .HasMaxLength(50);

            this.Property(t => t.Used_to_Make)
                .HasMaxLength(50);

            this.Property(t => t.Drain_Method)
                .HasMaxLength(50);

            this.Property(t => t.Media_Lot)
                .HasMaxLength(50);

            this.Property(t => t.Ball_Height)
                .HasMaxLength(50);

            this.Property(t => t.Mill_Number)
                .HasMaxLength(50);

            this.Property(t => t.Probe_Height)
                .HasMaxLength(50);

            this.Property(t => t.Date)
                .HasMaxLength(15);

            this.Property(t => t.Ingredient_Lot)
                .HasMaxLength(50);

            this.Property(t => t.Adogen)
                .HasMaxLength(50);

            this.Property(t => t.Revision__)
                .HasMaxLength(15);

            this.Property(t => t.Load_ID)
                .HasMaxLength(15);

            this.Property(t => t.SecondFeedType)
                .HasMaxLength(50);

            this.Property(t => t.ThirdFeedType)
                .HasMaxLength(50);

            this.Property(t => t.IngType)
                .HasMaxLength(50);

            this.Property(t => t.StearicGrade)
                .HasMaxLength(50);

            this.Property(t => t.OleicGrade)
                .HasMaxLength(50);

            this.Property(t => t.AdogenGrade)
                .HasMaxLength(50);

            this.Property(t => t.VarsolType)
                .HasMaxLength(50);

            this.Property(t => t.Verifying)
                .HasMaxLength(50);

            this.Property(t => t.MillAirAt)
                .HasMaxLength(50);

            this.Property(t => t.ADD_VARSOL)
                .HasMaxLength(50);

            this.Property(t => t.VarsolTo)
                .HasMaxLength(50);

            this.Property(t => t.MILL_CHECK)
                .HasMaxLength(50);

            this.Property(t => t.LauricGrade)
                .HasMaxLength(50);

            this.Property(t => t.Lube1)
                .HasMaxLength(50);

            this.Property(t => t.L1WT)
                .HasMaxLength(50);

            this.Property(t => t.Lube2)
                .HasMaxLength(50);

            this.Property(t => t.L2WT)
                .HasMaxLength(50);

            this.Property(t => t.Kaydol)
                .HasMaxLength(50);

            this.Property(t => t.IsMaster)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Plant Mill Formula Table");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Plant_ID).HasColumnName("Plant ID");
            this.Property(t => t.System).HasColumnName("System");
            this.Property(t => t.No_of_Mills).HasColumnName("No_of Mills");
            this.Property(t => t.Feed_Type).HasColumnName("Feed Type");
            this.Property(t => t.Feed_Amt).HasColumnName("Feed Amt");
            this.Property(t => t.Feed_NV).HasColumnName("Feed NV");
            this.Property(t => t.Oleic).HasColumnName("Oleic");
            this.Property(t => t.Stearic).HasColumnName("Stearic");
            this.Property(t => t.Lauric).HasColumnName("Lauric");
            this.Property(t => t.Initial_Varsol_Added).HasColumnName("Initial Varsol Added");
            this.Property(t => t.Slurry_Height).HasColumnName("Slurry Height");
            this.Property(t => t.Probe_At).HasColumnName("Probe At");
            this.Property(t => t.Mill_NV).HasColumnName("Mill NV");
            this.Property(t => t.Media_Weight).HasColumnName("Media Weight");
            this.Property(t => t.Media_Type).HasColumnName("Media Type");
            this.Property(t => t.Mill_RPM).HasColumnName("Mill RPM");
            this.Property(t => t.Run_Hrs).HasColumnName("Run Hrs");
            this.Property(t => t.Mill_Drain_Dil).HasColumnName("Mill Drain Dil");
            this.Property(t => t.Screen_Percent).HasColumnName("Screen Percent");
            this.Property(t => t.Gal_to_Screens).HasColumnName("Gal to Screens");
            this.Property(t => t.Scalper_).HasColumnName("Scalper#");
            this.Property(t => t.Scalper_Mesh).HasColumnName("Scalper Mesh");
            this.Property(t => t.C1st_Pass_).HasColumnName("1st Pass#");
            this.Property(t => t.C1st_Pass_Mesh).HasColumnName("1st Pass Mesh");
            this.Property(t => t.C2nd_Pass_).HasColumnName("2nd Pass#");
            this.Property(t => t.C2nd_Pass_Mesh).HasColumnName("2nd Pass Mesh");
            this.Property(t => t.Check_).HasColumnName("Check#");
            this.Property(t => t.Check_Mesh).HasColumnName("Check Mesh");
            this.Property(t => t.C_Yield).HasColumnName("%Yield");
            this.Property(t => t.Std_Production).HasColumnName("Std Production");
            this.Property(t => t.SpecialT_Code).HasColumnName("SpecialT Code");
            this.Property(t => t.Dry_Mix_Time).HasColumnName("Dry Mix Time");
            this.Property(t => t.Finished_Mix_Time).HasColumnName("Finished Mix Time");
            this.Property(t => t.Finished__).HasColumnName("Finished %");
            this.Property(t => t.Used_to_Make).HasColumnName("Used to Make");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.Drain_Method).HasColumnName("Drain Method");
            this.Property(t => t.Media_Lot).HasColumnName("Media Lot");
            this.Property(t => t.Ball_Height).HasColumnName("Ball Height");
            this.Property(t => t.Mill_Number).HasColumnName("Mill Number");
            this.Property(t => t.Varsol).HasColumnName("Varsol");
            this.Property(t => t.Probe_Height).HasColumnName("Probe Height");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Ingredient_Lot).HasColumnName("Ingredient Lot");
            this.Property(t => t.Adogen).HasColumnName("Adogen");
            this.Property(t => t.Revision__).HasColumnName("Revision #");
            this.Property(t => t.Load_ID).HasColumnName("Load ID");
            this.Property(t => t.SecondFeedType).HasColumnName("SecondFeedType");
            this.Property(t => t.SecondFeedAmt).HasColumnName("SecondFeedAmt");
            this.Property(t => t.ThirdFeedType).HasColumnName("ThirdFeedType");
            this.Property(t => t.IngType).HasColumnName("IngType");
            this.Property(t => t.StearicGrade).HasColumnName("StearicGrade");
            this.Property(t => t.OleicGrade).HasColumnName("OleicGrade");
            this.Property(t => t.AdogenGrade).HasColumnName("AdogenGrade");
            this.Property(t => t.VarsolType).HasColumnName("VarsolType");
            this.Property(t => t.Verifying).HasColumnName("Verifying");
            this.Property(t => t.MillAirAt).HasColumnName("MillAirAt");
            this.Property(t => t.ADD_VARSOL).HasColumnName("ADD_VARSOL");
            this.Property(t => t.VarsolTo).HasColumnName("VarsolTo");
            this.Property(t => t.MILL_CHECK).HasColumnName("MILL_CHECK");
            this.Property(t => t.LauricGrade).HasColumnName("LauricGrade");
            this.Property(t => t.Lube1).HasColumnName("Lube1");
            this.Property(t => t.L1WT).HasColumnName("L1WT");
            this.Property(t => t.Lube2).HasColumnName("Lube2");
            this.Property(t => t.L2WT).HasColumnName("L2WT");
            this.Property(t => t.Kaydol).HasColumnName("Kaydol");
            this.Property(t => t.IsMaster).HasColumnName("IsMaster");
        }
    }
}
