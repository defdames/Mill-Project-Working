using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class cpm_mapping_company_intercoMap : EntityTypeConfiguration<cpm_mapping_company_interco>
    {
        public cpm_mapping_company_intercoMap()
        {
            // Primary Key
            this.HasKey(t => t.gl_cmp_key);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.cpm_gl_cmp_key)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("cpm_mapping_company_interco");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.cpm_gl_cmp_key).HasColumnName("cpm_gl_cmp_key");
        }
    }
}
