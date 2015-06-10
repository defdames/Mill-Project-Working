using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lab_summary_sheet_tableMap : EntityTypeConfiguration<lab_summary_sheet_table>
    {
        public lab_summary_sheet_tableMap()
        {
            // Primary Key
            this.HasKey(t => t.column);

            // Properties
            this.Property(t => t.column)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("lab_summary_sheet_table");
            this.Property(t => t.column).HasColumnName("column");
        }
    }
}
