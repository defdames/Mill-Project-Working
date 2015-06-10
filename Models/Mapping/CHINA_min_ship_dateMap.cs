using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_min_ship_dateMap : EntityTypeConfiguration<CHINA_min_ship_date>
    {
        public CHINA_min_ship_dateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_hdr_key, t.so_dtl_shpws });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_shpws)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("CHINA_min_ship_date");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_shpws).HasColumnName("so_dtl_shpws");
            this.Property(t => t.ShipDate).HasColumnName("ShipDate");
        }
    }
}
