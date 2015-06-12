using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_cstjn_tblMap : EntityTypeConfiguration<en_cstjn_tbl>
    {
        public en_cstjn_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_cust_key, t.en_bill_key, t.en_ship_key });

            // Properties
            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_cstjn_tbl");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.en_bill_key).HasColumnName("en_bill_key");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_cstjn_chgdt).HasColumnName("en_cstjn_chgdt");
            this.Property(t => t.en_cstjn_upcnt).HasColumnName("en_cstjn_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_cstjn_crtdt).HasColumnName("en_cstjn_crtdt");
        }
    }
}
