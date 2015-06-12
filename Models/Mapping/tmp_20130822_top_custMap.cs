using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_20130822_top_custMap : EntityTypeConfiguration<tmp_20130822_top_cust>
    {
        public tmp_20130822_top_custMap()
        {
            // Primary Key
            this.HasKey(t => new { t.region, t.en_ship_key, t.en_ship_name });

            // Properties
            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.top_customer_name)
                .HasMaxLength(20);

            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.shipname)
                .HasMaxLength(20);

            this.Property(t => t.en_ship_name)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("tmp_20130822_top_cust");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.top_customer_name).HasColumnName("top_customer_name");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.shipname).HasColumnName("shipname");
            this.Property(t => t.en_ship_name).HasColumnName("en_ship_name");
            this.Property(t => t.length).HasColumnName("length");
        }
    }
}
