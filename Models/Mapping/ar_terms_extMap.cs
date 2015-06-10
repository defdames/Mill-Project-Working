using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_terms_extMap : EntityTypeConfiguration<ar_terms_ext>
    {
        public ar_terms_extMap()
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

            this.Property(t => t.trans_type)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ar_terms_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
            this.Property(t => t.trans_type).HasColumnName("trans_type");
            this.Property(t => t.ar_terms_upcnt).HasColumnName("ar_terms_upcnt");
        }
    }
}
