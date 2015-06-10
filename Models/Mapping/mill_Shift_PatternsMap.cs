using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mill_Shift_PatternsMap : EntityTypeConfiguration<mill_Shift_Patterns>
    {
        public mill_Shift_PatternsMap()
        {
            // Primary Key
            this.HasKey(t => t.Shift_Patterns_ID);

            // Properties
            this.Property(t => t.Shift_ID)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Shift_Active)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Shift_Hours_Cross_Days)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Created_by)
                .HasMaxLength(255);

            this.Property(t => t.Modified_by)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("mill_Shift_Patterns");
            this.Property(t => t.Shift_Patterns_ID).HasColumnName("Shift_Patterns_ID");
            this.Property(t => t.Shift_ID).HasColumnName("Shift_ID");
            this.Property(t => t.Shift_Length_Hours).HasColumnName("Shift_Length_Hours");
            this.Property(t => t.Shift_Start_Time).HasColumnName("Shift_Start_Time");
            this.Property(t => t.Shift_Stop_Time).HasColumnName("Shift_Stop_Time");
            this.Property(t => t.Shift_Active).HasColumnName("Shift_Active");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Shift_Hours_Cross_Days).HasColumnName("Shift_Hours_Cross_Days");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.Created_date).HasColumnName("Created_date");
            this.Property(t => t.Modified_date).HasColumnName("Modified_date");
            this.Property(t => t.Created_by).HasColumnName("Created_by");
            this.Property(t => t.Modified_by).HasColumnName("Modified_by");
        }
    }
}
