using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_cntry_tblMap : EntityTypeConfiguration<en_cntry_tbl>
    {
        public en_cntry_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_cntry_key);

            // Properties
            this.Property(t => t.en_cntry_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_cntry_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_cntry_iso2)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_cntry_iso3)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_cntry_isoa3)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_cntry_int2)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_cntry_int3)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_cntry_chkd)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_vatcd_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_cntry_tbl");
            this.Property(t => t.en_cntry_key).HasColumnName("en_cntry_key");
            this.Property(t => t.en_cntry_desc).HasColumnName("en_cntry_desc");
            this.Property(t => t.en_cntry_iso2).HasColumnName("en_cntry_iso2");
            this.Property(t => t.en_cntry_iso3).HasColumnName("en_cntry_iso3");
            this.Property(t => t.en_cntry_isoa3).HasColumnName("en_cntry_isoa3");
            this.Property(t => t.en_cntry_int2).HasColumnName("en_cntry_int2");
            this.Property(t => t.en_cntry_int3).HasColumnName("en_cntry_int3");
            this.Property(t => t.en_cntry_euf).HasColumnName("en_cntry_euf");
            this.Property(t => t.en_cntry_chkd).HasColumnName("en_cntry_chkd");
            this.Property(t => t.en_cntry_tax).HasColumnName("en_cntry_tax");
            this.Property(t => t.en_cntry_vatc).HasColumnName("en_cntry_vatc");
            this.Property(t => t.en_cntry_crtdt).HasColumnName("en_cntry_crtdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_cntry_chgdt).HasColumnName("en_cntry_chgdt");
            this.Property(t => t.en_cntry_upcnt).HasColumnName("en_cntry_upcnt");
            this.Property(t => t.en_vatcd_key).HasColumnName("en_vatcd_key");
            this.Property(t => t.en_cntry_eueffdt).HasColumnName("en_cntry_eueffdt");
            this.Property(t => t.en_cntry_stateoptf).HasColumnName("en_cntry_stateoptf");
            this.Property(t => t.en_cntry_postalcodeoptf).HasColumnName("en_cntry_postalcodeoptf");
        }
    }
}
