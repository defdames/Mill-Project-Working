using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class coa04Map : EntityTypeConfiguration<coa04>
    {
        public coa04Map()
        {
            // Primary Key
            this.HasKey(t => new { t.so_ship_dmdid, t.in_whs_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.so_ship_dmdid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_load_key)
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("coa04");
            this.Property(t => t.so_ship_dmdid).HasColumnName("so_ship_dmdid");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_load_key).HasColumnName("so_load_key");
        }
    }
}
