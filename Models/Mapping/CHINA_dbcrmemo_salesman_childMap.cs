using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_dbcrmemo_salesman_childMap : EntityTypeConfiguration<CHINA_dbcrmemo_salesman_child>
    {
        public CHINA_dbcrmemo_salesman_childMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_dbcrm_key, t.so_salsm_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.ar_dbcrm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_dbcrmemo_salesman_child");
            this.Property(t => t.ar_dbcrm_key).HasColumnName("ar_dbcrm_key");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
