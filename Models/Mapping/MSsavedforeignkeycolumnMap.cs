using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class MSsavedforeignkeycolumnMap : EntityTypeConfiguration<MSsavedforeignkeycolumn>
    {
        public MSsavedforeignkeycolumnMap()
        {
            // Primary Key
            this.HasKey(t => new { t.program_name, t.constraint_name, t.parent_schema, t.constraint_column_id, t.referencing_column_name, t.referenced_column_name, t.timestamp });

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

            this.Property(t => t.constraint_column_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.referencing_column_name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.referenced_column_name)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("MSsavedforeignkeycolumns");
            this.Property(t => t.program_name).HasColumnName("program_name");
            this.Property(t => t.constraint_name).HasColumnName("constraint_name");
            this.Property(t => t.parent_schema).HasColumnName("parent_schema");
            this.Property(t => t.constraint_column_id).HasColumnName("constraint_column_id");
            this.Property(t => t.referencing_column_name).HasColumnName("referencing_column_name");
            this.Property(t => t.referenced_column_name).HasColumnName("referenced_column_name");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
        }
    }
}
