using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_cstjn_tblMap : EntityTypeConfiguration<ar_cstjn_tbl>
    {
        public ar_cstjn_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.en_cust_key, t.ar_bill_key, t.ar_ship_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("ar_cstjn_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.ar_stats_key).HasColumnName("ar_stats_key");
            this.Property(t => t.ar_cstjn_chgdt).HasColumnName("ar_cstjn_chgdt");
            this.Property(t => t.ar_cstjn_upcnt).HasColumnName("ar_cstjn_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.ar_cstjn_crtdt).HasColumnName("ar_cstjn_crtdt");
        }
    }
}
