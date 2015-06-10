using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mill_Sys_Mills_ComboMap : EntityTypeConfiguration<mill_Sys_Mills_Combo>
    {
        public mill_Sys_Mills_ComboMap()
        {
            // Primary Key
            this.HasKey(t => t.Sys_Mills_Combo_ID);

            // Properties
            this.Property(t => t.System)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Mill_ID)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Active)
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
            this.ToTable("mill_Sys_Mills_Combo");
            this.Property(t => t.Sys_Mills_Combo_ID).HasColumnName("Sys_Mills_Combo_ID");
            this.Property(t => t.System).HasColumnName("System");
            this.Property(t => t.Mill_ID).HasColumnName("Mill_ID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.Created_date).HasColumnName("Created_date");
            this.Property(t => t.Modified_date).HasColumnName("Modified_date");
            this.Property(t => t.Created_by).HasColumnName("Created_by");
            this.Property(t => t.Modified_by).HasColumnName("Modified_by");
        }
    }
}
