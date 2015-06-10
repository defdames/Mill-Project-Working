using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_terms_tblMap : EntityTypeConfiguration<en_terms_tbl>
    {
        public en_terms_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_terms_key);

            // Properties
            this.Property(t => t.en_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_terms_desc)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("en_terms_tbl");
            this.Property(t => t.en_terms_key).HasColumnName("en_terms_key");
            this.Property(t => t.en_terms_upcnt).HasColumnName("en_terms_upcnt");
            this.Property(t => t.en_terms_dspct).HasColumnName("en_terms_dspct");
            this.Property(t => t.en_terms_dyavl).HasColumnName("en_terms_dyavl");
            this.Property(t => t.en_terms_dyntd).HasColumnName("en_terms_dyntd");
            this.Property(t => t.en_terms_desc).HasColumnName("en_terms_desc");
            this.Property(t => t.en_terms_opt).HasColumnName("en_terms_opt");
            this.Property(t => t.en_terms_dued).HasColumnName("en_terms_dued");
            this.Property(t => t.en_terms_eom).HasColumnName("en_terms_eom");
            this.Property(t => t.en_terms_limd).HasColumnName("en_terms_limd");
            this.Property(t => t.en_terms_eomdt).HasColumnName("en_terms_eomdt");
            this.Property(t => t.en_terms_graced).HasColumnName("en_terms_graced");
        }
    }
}
