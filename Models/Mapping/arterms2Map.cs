using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class arterms2Map : EntityTypeConfiguration<arterms2>
    {
        public arterms2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_entity_key, t.highbal });

            // Properties
            this.Property(t => t.ar_entity_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("arterms2");
            this.Property(t => t.ar_entity_key).HasColumnName("ar_entity_key");
            this.Property(t => t.highbal).HasColumnName("highbal");
        }
    }
}
