using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_20141118_lang_frenchMap : EntityTypeConfiguration<tmp_20141118_lang_french>
    {
        public tmp_20141118_lang_frenchMap()
        {
            // Primary Key
            this.HasKey(t => new { t.original_text, t.language, t.transalation_text });

            // Properties
            this.Property(t => t.original_text)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.transalation_text)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tmp_20141118_lang_french");
            this.Property(t => t.original_text).HasColumnName("original_text");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.transalation_text).HasColumnName("transalation_text");
        }
    }
}
