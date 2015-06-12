using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Regular_Non_leafing_GradesMap : EntityTypeConfiguration<Regular_Non_leafing_Grades>
    {
        public Regular_Non_leafing_GradesMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Competitive_Sample_Name)
                .HasMaxLength(50);

            this.Property(t => t.Source)
                .HasMaxLength(50);

            this.Property(t => t.Acid_Resistance)
                .HasMaxLength(50);

            this.Property(t => t.C_200)
                .HasMaxLength(50);

            this.Property(t => t.C_270)
                .HasMaxLength(50);

            this.Property(t => t.C_325)
                .HasMaxLength(50);

            this.Property(t => t.C_400)
                .HasMaxLength(50);

            this.Property(t => t.C_500)
                .HasMaxLength(50);

            this.Property(t => t.C_635)
                .HasMaxLength(50);

            this.Property(t => t.Flake_Geometry)
                .HasMaxLength(50);

            this.Property(t => t.Drawdown_vehicle)
                .HasMaxLength(50);

            this.Property(t => t.Sprayout_vehicle)
                .HasMaxLength(50);

            this.Property(t => t.Counter__1)
                .HasMaxLength(50);

            this.Property(t => t.Counter__2)
                .HasMaxLength(50);

            this.Property(t => t.Closest_Silberline_Grade)
                .HasMaxLength(50);

            this.Property(t => t.Analyzed_by)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Regular Non-leafing Grades");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Competitive_Sample_Name).HasColumnName("Competitive Sample Name");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.Non_volitle).HasColumnName("Non-volitle");
            this.Property(t => t.Acid_Resistance).HasColumnName("Acid Resistance");
            this.Property(t => t.C_200).HasColumnName("+200");
            this.Property(t => t.C_270).HasColumnName("+270");
            this.Property(t => t.C_325).HasColumnName("+325");
            this.Property(t => t.C_400).HasColumnName("+400");
            this.Property(t => t.C_500).HasColumnName("+500");
            this.Property(t => t.C_635).HasColumnName("+635");
            this.Property(t => t.D_10_).HasColumnName("D(10)");
            this.Property(t => t.D_50_).HasColumnName("D(50)");
            this.Property(t => t.D_90_).HasColumnName("D(90)");
            this.Property(t => t.Flake_Geometry).HasColumnName("Flake Geometry");
            this.Property(t => t.Drawdown_vehicle).HasColumnName("Drawdown vehicle");
            this.Property(t => t.Drawdown_description).HasColumnName("Drawdown description");
            this.Property(t => t.Sprayout_vehicle).HasColumnName("Sprayout vehicle");
            this.Property(t => t.Competitive_15).HasColumnName("Competitive 15");
            this.Property(t => t.Competitive_25).HasColumnName("Competitive 25");
            this.Property(t => t.Competitive_45).HasColumnName("Competitive 45");
            this.Property(t => t.Competitive_75).HasColumnName("Competitive 75");
            this.Property(t => t.Competitive_110).HasColumnName("Competitive 110");
            this.Property(t => t.Counter__1).HasColumnName("Counter #1");
            this.Property(t => t.Counter__1_15).HasColumnName("Counter #1 15");
            this.Property(t => t.Counter__1_25).HasColumnName("Counter #1 25");
            this.Property(t => t.Counter__1_45).HasColumnName("Counter #1 45");
            this.Property(t => t.Counter__1_75).HasColumnName("Counter #1 75");
            this.Property(t => t.Counter__1_110).HasColumnName("Counter #1 110");
            this.Property(t => t.Counter__2).HasColumnName("Counter #2");
            this.Property(t => t.Counter__2_15).HasColumnName("Counter #2 15");
            this.Property(t => t.Counter__2_25).HasColumnName("Counter #2 25");
            this.Property(t => t.Counter__2_45).HasColumnName("Counter #2 45");
            this.Property(t => t.Counter__2_75).HasColumnName("Counter #2 75");
            this.Property(t => t.Counter__2_110).HasColumnName("Counter #2 110");
            this.Property(t => t.Additional_Remarks).HasColumnName("Additional Remarks");
            this.Property(t => t.Closest_Silberline_Grade).HasColumnName("Closest Silberline Grade");
            this.Property(t => t.Date_completed).HasColumnName("Date completed");
            this.Property(t => t.Analyzed_by).HasColumnName("Analyzed by");
        }
    }
}
