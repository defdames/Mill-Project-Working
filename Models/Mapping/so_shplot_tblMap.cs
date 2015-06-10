using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_shplot_tblMap : EntityTypeConfiguration<so_shplot_tbl>
    {
        public so_shplot_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_ship_entity, t.so_ship_key, t.so_ship_ordtp, t.so_shpitm_key, t.so_shiplot_key });

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

            this.Property(t => t.so_shiplot_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_dmd)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_ship_dmdent)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("so_shplot_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_ship_entity).HasColumnName("so_ship_entity");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.so_ship_ordtp).HasColumnName("so_ship_ordtp");
            this.Property(t => t.so_shpitm_key).HasColumnName("so_shpitm_key");
            this.Property(t => t.so_shiplot_key).HasColumnName("so_shiplot_key");
            this.Property(t => t.so_shiplot_qty).HasColumnName("so_shiplot_qty");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.gl_cmp_dmd).HasColumnName("gl_cmp_dmd");
            this.Property(t => t.so_ship_dmdent).HasColumnName("so_ship_dmdent");
            this.Property(t => t.in_pick_key).HasColumnName("in_pick_key");
            this.Property(t => t.so_shiplot_pot).HasColumnName("so_shiplot_pot");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.so_shplot_recqt).HasColumnName("so_shplot_recqt");
            this.Property(t => t.so_shplot_drctf).HasColumnName("so_shplot_drctf");
            this.Property(t => t.so_shiplot_upcnt).HasColumnName("so_shiplot_upcnt");
        }
    }
}
