using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_20140905_dayssupplyshipMap : EntityTypeConfiguration<tmp_20140905_dayssupplyship>
    {
        public tmp_20140905_dayssupplyshipMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Company, t.Item, t.top_customer_name, t.DollarsSoldLC, t.DollarsSold3MTH, t.PoundsSoldLC, t.PoundsSold3MTH, t.CostValue, t.CostValue3MTH });

            // Properties
            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.shipkey)
                .HasMaxLength(500);

            this.Property(t => t.top_customer_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.PoundsSoldLC)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PoundsSold3MTH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tmp_20140905_dayssupplyship");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.shipkey).HasColumnName("shipkey");
            this.Property(t => t.top_customer_name).HasColumnName("top_customer_name");
            this.Property(t => t.DollarsSoldLC).HasColumnName("DollarsSoldLC");
            this.Property(t => t.DollarsSold3MTH).HasColumnName("DollarsSold3MTH");
            this.Property(t => t.EndInvVol).HasColumnName("EndInvVol");
            this.Property(t => t.EndInvVal).HasColumnName("EndInvVal");
            this.Property(t => t.PoundsSoldLC).HasColumnName("PoundsSoldLC");
            this.Property(t => t.KGSSoldLC).HasColumnName("KGSSoldLC");
            this.Property(t => t.PoundsSold3MTH).HasColumnName("PoundsSold3MTH");
            this.Property(t => t.KGSSold3MTH).HasColumnName("KGSSold3MTH");
            this.Property(t => t.CostValue).HasColumnName("CostValue");
            this.Property(t => t.CostValue3MTH).HasColumnName("CostValue3MTH");
            this.Property(t => t.DaysSupplyVolume).HasColumnName("DaysSupplyVolume");
            this.Property(t => t.DaysSupplyValue).HasColumnName("DaysSupplyValue");
            this.Property(t => t.DaysSupplyVolume3Month).HasColumnName("DaysSupplyVolume3Month");
            this.Property(t => t.DaysSupplyValue3Month).HasColumnName("DaysSupplyValue3Month");
        }
    }
}
