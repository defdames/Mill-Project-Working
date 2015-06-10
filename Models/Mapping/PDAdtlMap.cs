using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class PDAdtlMap : EntityTypeConfiguration<PDAdtl>
    {
        public PDAdtlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RequestNo, t.ProductID });

            // Properties
            this.Property(t => t.RequestNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.entity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ApprovedBy)
                .HasMaxLength(50);

            this.Property(t => t.DeclinedBy)
                .HasMaxLength(50);

            this.Property(t => t.ProductID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Competitor)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompetitiveProduct)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FreightSupport)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BreakPallet)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FreightAllowance)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Repack)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MinimumInvoice)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StdPack)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AltPack)
                .HasMaxLength(50);

            this.Property(t => t.EstimatedAnnualVolume)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PDAdtl");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.entity).HasColumnName("entity");
            this.Property(t => t.ApprovedBy).HasColumnName("ApprovedBy");
            this.Property(t => t.DeclinedBy).HasColumnName("DeclinedBy");
            this.Property(t => t.ApprovedDate).HasColumnName("ApprovedDate");
            this.Property(t => t.DeclinedDate).HasColumnName("DeclinedDate");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ListPrice).HasColumnName("ListPrice");
            this.Property(t => t.CurrentPrice).HasColumnName("CurrentPrice");
            this.Property(t => t.NewRequested_Price).HasColumnName("NewRequested Price");
            this.Property(t => t.MinimumOrder_Quantity).HasColumnName("MinimumOrder Quantity");
            this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
            this.Property(t => t.ExpirationDate).HasColumnName("ExpirationDate");
            this.Property(t => t.Competitor).HasColumnName("Competitor");
            this.Property(t => t.CompetitiveProduct).HasColumnName("CompetitiveProduct");
            this.Property(t => t.CompetitivePrice).HasColumnName("CompetitivePrice");
            this.Property(t => t.AdditionalInformation).HasColumnName("AdditionalInformation");
            this.Property(t => t.FreightSupport).HasColumnName("FreightSupport");
            this.Property(t => t.BreakPallet).HasColumnName("BreakPallet");
            this.Property(t => t.FreightAllowance).HasColumnName("FreightAllowance");
            this.Property(t => t.Repack).HasColumnName("Repack");
            this.Property(t => t.MinimumInvoice).HasColumnName("MinimumInvoice");
            this.Property(t => t.StdPack).HasColumnName("StdPack");
            this.Property(t => t.AltPack).HasColumnName("AltPack");
            this.Property(t => t.EstimatedAnnualVolume).HasColumnName("EstimatedAnnualVolume");
        }
    }
}
