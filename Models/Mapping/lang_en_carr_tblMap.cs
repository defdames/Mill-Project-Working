using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lang_en_carr_tblMap : EntityTypeConfiguration<lang_en_carr_tbl>
    {
        public lang_en_carr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_carr_key, t.language });

            // Properties
            this.Property(t => t.en_carr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_carr_desc)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("lang_en_carr_tbl");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.en_carr_desc).HasColumnName("en_carr_desc");
        }
    }
}
