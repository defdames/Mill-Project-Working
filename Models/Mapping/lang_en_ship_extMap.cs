using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lang_en_ship_extMap : EntityTypeConfiguration<lang_en_ship_ext>
    {
        public lang_en_ship_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_ship_key, t.language });

            // Properties
            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.aextended_ship_name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("lang_en_ship_ext");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.aextended_ship_name).HasColumnName("aextended_ship_name");
        }
    }
}
