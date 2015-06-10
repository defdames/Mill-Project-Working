using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_shpitm_extMap : EntityTypeConfiguration<so_shpitm_ext>
    {
        public so_shpitm_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_ship_entity, t.so_ship_key, t.so_ship_ordtp, t.so_shpitm_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_ship_entity)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_ship_ordtp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.so_shpitm_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.so_ship_dmdent)
                .HasMaxLength(4);

            this.Property(t => t.so_shpitm_bolpack)
                .HasMaxLength(30);

            this.Property(t => t.dl_remarks)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("so_shpitm_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_ship_entity).HasColumnName("so_ship_entity");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.so_ship_ordtp).HasColumnName("so_ship_ordtp");
            this.Property(t => t.so_shpitm_key).HasColumnName("so_shpitm_key");
            this.Property(t => t.so_ship_dmdent).HasColumnName("so_ship_dmdent");
            this.Property(t => t.so_shp_nopacks).HasColumnName("so_shp_nopacks");
            this.Property(t => t.bulk_net_wgt).HasColumnName("bulk_net_wgt");
            this.Property(t => t.actual_line_wgt).HasColumnName("actual_line_wgt");
            this.Property(t => t.so_shpitm_bolpack).HasColumnName("so_shpitm_bolpack");
            this.Property(t => t.actual_cubic_meters).HasColumnName("actual_cubic_meters");
            this.Property(t => t.no_pallets).HasColumnName("no_pallets");
            this.Property(t => t.dl_remarks).HasColumnName("dl_remarks");
            this.Property(t => t.so_shpitm_upcnt).HasColumnName("so_shpitm_upcnt");
        }
    }
}
