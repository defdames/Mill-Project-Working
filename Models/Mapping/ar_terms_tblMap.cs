using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_terms_tblMap : EntityTypeConfiguration<ar_terms_tbl>
    {
        public ar_terms_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ar_terms_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_terms_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("ar_terms_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
            this.Property(t => t.ar_terms_dspct).HasColumnName("ar_terms_dspct");
            this.Property(t => t.ar_terms_dyavl).HasColumnName("ar_terms_dyavl");
            this.Property(t => t.ar_terms_dyntd).HasColumnName("ar_terms_dyntd");
            this.Property(t => t.ar_terms_desc).HasColumnName("ar_terms_desc");
            this.Property(t => t.ar_terms_upcnt).HasColumnName("ar_terms_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.ar_terms_chgdt).HasColumnName("ar_terms_chgdt");
            this.Property(t => t.ar_terms_crtdt).HasColumnName("ar_terms_crtdt");
            this.Property(t => t.ar_terms_opt).HasColumnName("ar_terms_opt");
            this.Property(t => t.ar_terms_dued).HasColumnName("ar_terms_dued");
            this.Property(t => t.ar_terms_eom).HasColumnName("ar_terms_eom");
            this.Property(t => t.ar_terms_limd).HasColumnName("ar_terms_limd");
            this.Property(t => t.ar_terms_eomdt).HasColumnName("ar_terms_eomdt");
            this.Property(t => t.ar_terms_graced).HasColumnName("ar_terms_graced");
        }
    }
}
