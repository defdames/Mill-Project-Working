using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class PlasticMap : EntityTypeConfiguration<Plastic>
    {
        public PlasticMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Competitive_Sample_Name)
                .HasMaxLength(50);

            this.Property(t => t.Source)
                .HasMaxLength(50);

            this.Property(t => t.C_200)
                .HasMaxLength(50);

            this.Property(t => t.C_230)
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

            this.Property(t => t.Carrier_type)
                .HasMaxLength(50);

            this.Property(t => t.Flake_Geometry)
                .HasMaxLength(50);

            this.Property(t => t.Closest_Silberline_Grade)
                .HasMaxLength(50);

            this.Property(t => t.Analyzed_by)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Plastics");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Competitive_Sample_Name).HasColumnName("Competitive Sample Name");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.Non_volitle).HasColumnName("Non-volitle");
            this.Property(t => t.C_200).HasColumnName("+200");
            this.Property(t => t.C_230).HasColumnName("+230");
            this.Property(t => t.C_270).HasColumnName("+270");
            this.Property(t => t.C_325).HasColumnName("+325");
            this.Property(t => t.C_400).HasColumnName("+400");
            this.Property(t => t.C_500).HasColumnName("+500");
            this.Property(t => t.C_635).HasColumnName("+635");
            this.Property(t => t.D_10_).HasColumnName("D(10)");
            this.Property(t => t.D_50_).HasColumnName("D(50)");
            this.Property(t => t.D_90_).HasColumnName("D(90)");
            this.Property(t => t.Carrier_type).HasColumnName("Carrier type");
            this.Property(t => t.Carrier_extraction__).HasColumnName("Carrier extraction %");
            this.Property(t => t.Flake_Geometry).HasColumnName("Flake Geometry");
            this.Property(t => t.Molded_Chip_or_Press_Out).HasColumnName("Molded Chip or Press Out");
            this.Property(t => t.Plastisol).HasColumnName("Plastisol");
            this.Property(t => t.Additional_Remarks).HasColumnName("Additional Remarks");
            this.Property(t => t.Closest_Silberline_Grade).HasColumnName("Closest Silberline Grade");
            this.Property(t => t.Date_completed).HasColumnName("Date completed");
            this.Property(t => t.Analyzed_by).HasColumnName("Analyzed by");
        }
    }
}
