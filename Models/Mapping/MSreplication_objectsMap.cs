using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class MSreplication_objectsMap : EntityTypeConfiguration<MSreplication_objects>
    {
        public MSreplication_objectsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.object_name, t.object_type });

            // Properties
            this.Property(t => t.publisher)
                .HasMaxLength(128);

            this.Property(t => t.publisher_db)
                .HasMaxLength(128);

            this.Property(t => t.publication)
                .HasMaxLength(128);

            this.Property(t => t.object_name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.object_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.article)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("MSreplication_objects");
            this.Property(t => t.publisher).HasColumnName("publisher");
            this.Property(t => t.publisher_db).HasColumnName("publisher_db");
            this.Property(t => t.publication).HasColumnName("publication");
            this.Property(t => t.object_name).HasColumnName("object_name");
            this.Property(t => t.object_type).HasColumnName("object_type");
            this.Property(t => t.article).HasColumnName("article");
        }
    }
}
