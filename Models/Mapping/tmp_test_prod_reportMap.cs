using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_test_prod_reportMap : EntityTypeConfiguration<tmp_test_prod_report>
    {
        public tmp_test_prod_reportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pm_shop_key, t.sf_plant_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.pm_shop_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("tmp_test_prod_report");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ingred_qty).HasColumnName("ingred_qty");
        }
    }
}
