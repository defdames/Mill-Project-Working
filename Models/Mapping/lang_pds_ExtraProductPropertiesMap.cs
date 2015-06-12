using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lang_pds_ExtraProductPropertiesMap : EntityTypeConfiguration<lang_pds_ExtraProductProperties>
    {
        public lang_pds_ExtraProductPropertiesMap()
        {
            // Primary Key
            this.HasKey(t => t.Item);

            // Properties
            this.Property(t => t.Item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Grade)
                .HasMaxLength(255);

            this.Property(t => t.NonVolatileByVolume)
                .HasMaxLength(50);

            this.Property(t => t.SpecificGravity1)
                .HasMaxLength(50);

            this.Property(t => t.Solvent)
                .HasMaxLength(255);

            this.Property(t => t.FederalSpecification)
                .HasMaxLength(30);

            this.Property(t => t.ASTMSpecification)
                .HasMaxLength(30);

            this.Property(t => t.Composition1)
                .HasMaxLength(250);

            this.Property(t => t.Composition2)
                .HasMaxLength(50);

            this.Property(t => t.Carrier)
                .HasMaxLength(50);

            this.Property(t => t.PercentCarrier)
                .HasMaxLength(50);

            this.Property(t => t.ResinBinder)
                .HasMaxLength(50);

            this.Property(t => t.FlashPoint1)
                .HasMaxLength(50);

            this.Property(t => t.AluminumFlakeContent)
                .HasMaxLength(50);

            this.Property(t => t.StearicAcidContent)
                .HasMaxLength(50);

            this.Property(t => t.WaterCoverage)
                .HasMaxLength(50);

            this.Property(t => t.FattyAcidContent)
                .HasMaxLength(50);

            this.Property(t => t.MoistureContent)
                .HasMaxLength(50);

            this.Property(t => t.ParticleSize)
                .HasMaxLength(50);

            this.Property(t => t.ScreenAnalysis)
                .HasMaxLength(255);

            this.Property(t => t.LeafingValue)
                .HasMaxLength(50);

            this.Property(t => t.NonVolatileByWeight)
                .HasMaxLength(50);

            this.Property(t => t.MSDS)
                .HasMaxLength(50);

            this.Property(t => t.MedianFlakeSize)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("lang_pds_ExtraProductProperties");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.NonVolatileByVolume).HasColumnName("NonVolatileByVolume");
            this.Property(t => t.SpecificGravity1).HasColumnName("SpecificGravity1");
            this.Property(t => t.Solvent).HasColumnName("Solvent");
            this.Property(t => t.FederalSpecification).HasColumnName("FederalSpecification");
            this.Property(t => t.ASTMSpecification).HasColumnName("ASTMSpecification");
            this.Property(t => t.Composition1).HasColumnName("Composition1");
            this.Property(t => t.Composition2).HasColumnName("Composition2");
            this.Property(t => t.Carrier).HasColumnName("Carrier");
            this.Property(t => t.PercentCarrier).HasColumnName("PercentCarrier");
            this.Property(t => t.ResinBinder).HasColumnName("ResinBinder");
            this.Property(t => t.FlashPoint1).HasColumnName("FlashPoint1");
            this.Property(t => t.AluminumFlakeContent).HasColumnName("AluminumFlakeContent");
            this.Property(t => t.StearicAcidContent).HasColumnName("StearicAcidContent");
            this.Property(t => t.WaterCoverage).HasColumnName("WaterCoverage");
            this.Property(t => t.FattyAcidContent).HasColumnName("FattyAcidContent");
            this.Property(t => t.MoistureContent).HasColumnName("MoistureContent");
            this.Property(t => t.ParticleSize).HasColumnName("ParticleSize");
            this.Property(t => t.ScreenAnalysis).HasColumnName("ScreenAnalysis");
            this.Property(t => t.LeafingValue).HasColumnName("LeafingValue");
            this.Property(t => t.NonVolatileByWeight).HasColumnName("NonVolatileByWeight");
            this.Property(t => t.MSDS).HasColumnName("MSDS");
            this.Property(t => t.MedianFlakeSize).HasColumnName("MedianFlakeSize");
            this.Property(t => t.WeightVolumePounds).HasColumnName("WeightVolumePounds");
            this.Property(t => t.WeightVolumeKilos).HasColumnName("WeightVolumeKilos");
            this.Property(t => t.BulkingGallonsPounds).HasColumnName("BulkingGallonsPounds");
        }
    }
}
