using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class days_supply_wip_daily_pictureMap : EntityTypeConfiguration<days_supply_wip_daily_picture>
    {
        public days_supply_wip_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Company, t.Item, t.DollarsSoldLC, t.PoundsSoldLC, t.CostValue });

            // Properties
            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Item)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("days_supply_wip_daily_picture");
            this.Property(t => t.yearcapture).HasColumnName("yearcapture");
            this.Property(t => t.weekcapture).HasColumnName("weekcapture");
            this.Property(t => t.monthcapture).HasColumnName("monthcapture");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.DollarsSoldLC).HasColumnName("DollarsSoldLC");
            this.Property(t => t.EndInvVol).HasColumnName("EndInvVol");
            this.Property(t => t.EndInvVal).HasColumnName("EndInvVal");
            this.Property(t => t.PoundsSoldLC).HasColumnName("PoundsSoldLC");
            this.Property(t => t.KGSSoldLC).HasColumnName("KGSSoldLC");
            this.Property(t => t.CostValue).HasColumnName("CostValue");
            this.Property(t => t.DaysSupplyVolume).HasColumnName("DaysSupplyVolume");
            this.Property(t => t.DaysSupplyValue).HasColumnName("DaysSupplyValue");
        }
    }
}
