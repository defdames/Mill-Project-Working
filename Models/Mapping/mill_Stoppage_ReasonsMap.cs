using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mill_Stoppage_ReasonsMap : EntityTypeConfiguration<mill_Stoppage_Reasons>
    {
        public mill_Stoppage_ReasonsMap()
        {
            // Primary Key
            this.HasKey(t => t.Stoppage_Reasons_ID);

            // Properties
            this.Property(t => t.Stop_Reason)
                .IsRequired()
                .HasMaxLength(255);

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
            this.ToTable("mill_Stoppage_Reasons");
            this.Property(t => t.Stoppage_Reasons_ID).HasColumnName("Stoppage_Reasons_ID");
            this.Property(t => t.Stop_Reason).HasColumnName("Stop_Reason");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.Created_date).HasColumnName("Created_date");
            this.Property(t => t.Modified_date).HasColumnName("Modified_date");
            this.Property(t => t.Created_by).HasColumnName("Created_by");
            this.Property(t => t.Modified_by).HasColumnName("Modified_by");
        }
    }
}
