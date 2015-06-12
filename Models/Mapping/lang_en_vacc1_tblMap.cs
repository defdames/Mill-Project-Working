using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lang_en_vacc1_tblMap : EntityTypeConfiguration<lang_en_vacc1_tbl>
    {
        public lang_en_vacc1_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.en_vacc1_value, t.language });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_vacc1_value)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_vacc1_desc)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("lang_en_vacc1_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_vacc1_value).HasColumnName("en_vacc1_value");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.en_vacc1_desc).HasColumnName("en_vacc1_desc");
        }
    }
}
