using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class FcInformationTableMap : EntityTypeConfiguration<FcInformationTable>
    {
        public FcInformationTableMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Date, t.Press, t.ItemID });

            // Properties
            this.Property(t => t.Press)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Lot)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.System)
                .HasMaxLength(50);

            this.Property(t => t.Compressor)
                .HasMaxLength(50);

            this.Property(t => t.Air_Time)
                .HasMaxLength(50);

            this.Property(t => t.No_of_Mills)
                .HasMaxLength(50);

            this.Property(t => t.Total_Run_Hours)
                .HasMaxLength(50);

            this.Property(t => t.Press_Wash_Gallons)
                .HasMaxLength(50);

            this.Property(t => t.Press_Wash_Solvent)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FcInformationTable");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Press).HasColumnName("Press");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Lot).HasColumnName("Lot");
            this.Property(t => t.Prod_No).HasColumnName("Prod No");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.System).HasColumnName("System");
            this.Property(t => t.Compressor).HasColumnName("Compressor");
            this.Property(t => t.Air_Time).HasColumnName("Air Time");
            this.Property(t => t.No_of_Mills).HasColumnName("No of Mills");
            this.Property(t => t.Total_Run_Hours).HasColumnName("Total Run Hours");
            this.Property(t => t.C1_).HasColumnName("1)");
            this.Property(t => t.C2_).HasColumnName("2)");
            this.Property(t => t.C3_).HasColumnName("3)");
            this.Property(t => t.C4_).HasColumnName("4)");
            this.Property(t => t.C5_).HasColumnName("5)");
            this.Property(t => t.C6_).HasColumnName("6)");
            this.Property(t => t.C7_).HasColumnName("7)");
            this.Property(t => t.C8_).HasColumnName("8)");
            this.Property(t => t.C9_).HasColumnName("9)");
            this.Property(t => t.C10_).HasColumnName("10)");
            this.Property(t => t.C11_).HasColumnName("11)");
            this.Property(t => t.C12_).HasColumnName("12)");
            this.Property(t => t.C13_).HasColumnName("13)");
            this.Property(t => t.C14_).HasColumnName("14)");
            this.Property(t => t.C15_).HasColumnName("15)");
            this.Property(t => t.C16_).HasColumnName("16)");
            this.Property(t => t.C17_).HasColumnName("17)");
            this.Property(t => t.C18_).HasColumnName("18)");
            this.Property(t => t.C19_).HasColumnName("19)");
            this.Property(t => t.C20_).HasColumnName("20)");
            this.Property(t => t.C21_).HasColumnName("21)");
            this.Property(t => t.C22_).HasColumnName("22)");
            this.Property(t => t.C23_).HasColumnName("23)");
            this.Property(t => t.C24_).HasColumnName("24)");
            this.Property(t => t.Press_Wash_Gallons).HasColumnName("Press Wash Gallons");
            this.Property(t => t.Press_Wash_Solvent).HasColumnName("Press Wash Solvent");
            this.Property(t => t.SOF_Before).HasColumnName("SOF Before");
            this.Property(t => t.SOF_After).HasColumnName("SOF After");
            this.Property(t => t.TotalWt).HasColumnName("TotalWt");
        }
    }
}
