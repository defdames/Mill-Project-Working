using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Competition_datumMap : EntityTypeConfiguration<Competition_datum>
    {
        public Competition_datumMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Sample_Grade)
                .HasMaxLength(50);

            this.Property(t => t.Source)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.Screen_analysis_1)
                .HasMaxLength(50);

            this.Property(t => t.Screen_analysis_2)
                .HasMaxLength(50);

            this.Property(t => t.Screen_analysis_3)
                .HasMaxLength(50);

            this.Property(t => t.Screen_analysis_4)
                .HasMaxLength(50);

            this.Property(t => t.Screen_analysis_5)
                .HasMaxLength(50);

            this.Property(t => t.Screen_analysis_6)
                .HasMaxLength(50);

            this.Property(t => t.Market_Segment)
                .HasMaxLength(50);

            this.Property(t => t.Leafing_Non_leafing)
                .HasMaxLength(50);

            this.Property(t => t.Flake_Geometry)
                .HasMaxLength(50);

            this.Property(t => t.Acid_Resistant)
                .HasMaxLength(50);

            this.Property(t => t.Solvent_Water)
                .HasMaxLength(50);

            this.Property(t => t.Solvent_Type)
                .HasMaxLength(50);

            this.Property(t => t.Color)
                .HasMaxLength(50);

            this.Property(t => t.Degradation)
                .HasMaxLength(50);

            this.Property(t => t.Surface_Treated)
                .HasMaxLength(50);

            this.Property(t => t.Urea_Varnish)
                .HasMaxLength(250);

            this.Property(t => t.Sprayouts)
                .HasMaxLength(250);

            this.Property(t => t.Closest_Match)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Competition Data");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Sample_Grade).HasColumnName("Sample/Grade");
            this.Property(t => t.Date_Completed).HasColumnName("Date Completed");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.NV_).HasColumnName("NV%");
            this.Property(t => t.Screen_analysis_1).HasColumnName("Screen analysis-1");
            this.Property(t => t.Screen_analysis_2).HasColumnName("Screen analysis-2");
            this.Property(t => t.Screen_analysis_3).HasColumnName("Screen analysis-3");
            this.Property(t => t.Screen_analysis_4).HasColumnName("Screen analysis-4");
            this.Property(t => t.Screen_analysis_5).HasColumnName("Screen analysis-5");
            this.Property(t => t.Screen_analysis_6).HasColumnName("Screen analysis-6");
            this.Property(t => t.D50_value).HasColumnName("D50 value");
            this.Property(t => t.Market_Segment).HasColumnName("Market Segment");
            this.Property(t => t.Leafing_Non_leafing).HasColumnName("Leafing/Non-leafing");
            this.Property(t => t.Leafing_Value).HasColumnName("Leafing Value");
            this.Property(t => t.Flake_Geometry).HasColumnName("Flake Geometry");
            this.Property(t => t.Acid_Resistant).HasColumnName("Acid Resistant");
            this.Property(t => t.Solvent_Water).HasColumnName("Solvent/Water");
            this.Property(t => t.Solvent_Type).HasColumnName("Solvent Type");
            this.Property(t => t.Color).HasColumnName("Color");
            this.Property(t => t.Degradation).HasColumnName("Degradation");
            this.Property(t => t.Surface_Treated).HasColumnName("Surface Treated");
            this.Property(t => t.Urea_Varnish).HasColumnName("Urea/Varnish");
            this.Property(t => t.Sprayouts).HasColumnName("Sprayouts");
            this.Property(t => t.Closest_Match).HasColumnName("Closest Match");
        }
    }
}
