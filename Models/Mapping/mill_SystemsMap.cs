using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mill_SystemsMap : EntityTypeConfiguration<mill_Systems>
    {
        public mill_SystemsMap()
        {
            // Primary Key
            this.HasKey(t => t.Systems_ID);

            // Properties
            this.Property(t => t.System_Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Active)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Force_Mill_Test_Data_Entry)
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
            this.ToTable("mill_Systems");
            this.Property(t => t.Systems_ID).HasColumnName("Systems_ID");
            this.Property(t => t.System_Name).HasColumnName("System_Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Force_Mill_Test_Data_Entry).HasColumnName("Force_Mill_Test_Data_Entry");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.Created_date).HasColumnName("Created_date");
            this.Property(t => t.Modified_date).HasColumnName("Modified_date");
            this.Property(t => t.Created_by).HasColumnName("Created_by");
            this.Property(t => t.Modified_by).HasColumnName("Modified_by");
        }
    }
}
