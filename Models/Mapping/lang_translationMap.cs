using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lang_translationMap : EntityTypeConfiguration<lang_translation>
    {
        public lang_translationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.language, t.original_text });

            // Properties
            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.original_text)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.transalation_text)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("lang_translation");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.original_text).HasColumnName("original_text");
            this.Property(t => t.transalation_text).HasColumnName("transalation_text");
        }
    }
}
