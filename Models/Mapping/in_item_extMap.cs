using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_item_extMap : EntityTypeConfiguration<in_item_ext>
    {
        public in_item_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_item_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.health)
                .HasMaxLength(6);

            this.Property(t => t.iflammability)
                .HasMaxLength(6);

            this.Property(t => t.reaction)
                .HasMaxLength(6);

            this.Property(t => t.xref_item_name)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("in_item_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.health).HasColumnName("health");
            this.Property(t => t.iflammability).HasColumnName("iflammability");
            this.Property(t => t.reaction).HasColumnName("reaction");
            this.Property(t => t.xref_item_name).HasColumnName("xref_item_name");
            this.Property(t => t.in_item_upcnt).HasColumnName("in_item_upcnt");
        }
    }
}
