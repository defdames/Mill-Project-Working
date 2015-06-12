using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pds_region_mainMap : EntityTypeConfiguration<pds_region_main>
    {
        public pds_region_mainMap()
        {
            // Primary Key
            this.HasKey(t => new { t.region, t.item, t.en_prod_desc });

            // Properties
            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_prod_desc)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("pds_region_main");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
        }
    }
}
