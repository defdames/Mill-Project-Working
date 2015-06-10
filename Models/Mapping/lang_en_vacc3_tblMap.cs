using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lang_en_vacc3_tblMap : EntityTypeConfiguration<lang_en_vacc3_tbl>
    {
        public lang_en_vacc3_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.en_vacc3_value, t.language });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_vacc3_value)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_vacc3_desc)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("lang_en_vacc3_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_vacc3_value).HasColumnName("en_vacc3_value");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.en_vacc3_desc).HasColumnName("en_vacc3_desc");
        }
    }
}
