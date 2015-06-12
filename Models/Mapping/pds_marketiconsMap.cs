using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pds_marketiconsMap : EntityTypeConfiguration<pds_marketicons>
    {
        public pds_marketiconsMap()
        {
            // Primary Key
            this.HasKey(t => t.market);

            // Properties
            this.Property(t => t.market)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.icon)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("pds_marketicons");
            this.Property(t => t.market).HasColumnName("market");
            this.Property(t => t.icon).HasColumnName("icon");
        }
    }
}
