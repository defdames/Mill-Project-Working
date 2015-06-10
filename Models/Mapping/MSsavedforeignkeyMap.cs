using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class MSsavedforeignkeyMap : EntityTypeConfiguration<MSsavedforeignkey>
    {
        public MSsavedforeignkeyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.program_name, t.constraint_name, t.parent_schema, t.parent_name, t.referenced_object_schema, t.referenced_object_name, t.is_disabled, t.is_not_for_replication, t.is_not_trusted, t.delete_referential_action, t.update_referential_action, t.timestamp });

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

            this.Property(t => t.parent_name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.referenced_object_schema)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.referenced_object_name)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("MSsavedforeignkeys");
            this.Property(t => t.program_name).HasColumnName("program_name");
            this.Property(t => t.constraint_name).HasColumnName("constraint_name");
            this.Property(t => t.parent_schema).HasColumnName("parent_schema");
            this.Property(t => t.parent_name).HasColumnName("parent_name");
            this.Property(t => t.referenced_object_schema).HasColumnName("referenced_object_schema");
            this.Property(t => t.referenced_object_name).HasColumnName("referenced_object_name");
            this.Property(t => t.is_disabled).HasColumnName("is_disabled");
            this.Property(t => t.is_not_for_replication).HasColumnName("is_not_for_replication");
            this.Property(t => t.is_not_trusted).HasColumnName("is_not_trusted");
            this.Property(t => t.delete_referential_action).HasColumnName("delete_referential_action");
            this.Property(t => t.update_referential_action).HasColumnName("update_referential_action");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
        }
    }
}
