using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class global_en_prod_cxrf_tblMap : EntityTypeConfiguration<global_en_prod_cxrf_tbl>
    {
        public global_en_prod_cxrf_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ext_en_prod_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ext_en_prod_key)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_prod_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("global_en_prod_cxrf_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ext_en_prod_key).HasColumnName("ext_en_prod_key");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.golive).HasColumnName("golive");
        }
    }
}
