using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class MSsavedforeignkeyextendedpropertyMap : EntityTypeConfiguration<MSsavedforeignkeyextendedproperty>
    {
        public MSsavedforeignkeyextendedpropertyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.program_name, t.constraint_name, t.parent_schema, t.property_name, t.timestamp });

            // Properties
            this.Property(t => t.program_name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.constraint_name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.parent_schema)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.property_name)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("MSsavedforeignkeyextendedproperties");
            this.Property(t => t.program_name).HasColumnName("program_name");
            this.Property(t => t.constraint_name).HasColumnName("constraint_name");
            this.Property(t => t.parent_schema).HasColumnName("parent_schema");
            this.Property(t => t.property_name).HasColumnName("property_name");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
        }
    }
}
