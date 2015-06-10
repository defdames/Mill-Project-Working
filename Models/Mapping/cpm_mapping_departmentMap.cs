using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class cpm_mapping_departmentMap : EntityTypeConfiguration<cpm_mapping_department>
    {
        public cpm_mapping_departmentMap()
        {
            // Primary Key
            this.HasKey(t => t.adage_dept);

            // Properties
            this.Property(t => t.adage_dept)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.cpm_dept)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("cpm_mapping_department");
            this.Property(t => t.adage_dept).HasColumnName("adage_dept");
            this.Property(t => t.cpm_dept).HasColumnName("cpm_dept");
        }
    }
}
