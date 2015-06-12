using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_ptwhs_tblMap : EntityTypeConfiguration<sf_ptwhs_tbl>
    {
        public sf_ptwhs_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.in_whs_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_ptwhs_inspl)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("sf_ptwhs_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.sf_ptwhs_inspl).HasColumnName("sf_ptwhs_inspl");
            this.Property(t => t.sf_ptwhs_upcnt).HasColumnName("sf_ptwhs_upcnt");
        }
    }
}
