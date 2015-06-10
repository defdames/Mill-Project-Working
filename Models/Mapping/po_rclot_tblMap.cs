using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_rclot_tblMap : EntityTypeConfiguration<po_rclot_tbl>
    {
        public po_rclot_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_recpt_key, t.po_dtl_key, t.in_lot_key, t.in_locn_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_recpt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.po_rclot_cmnts)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.po_rclot_vlot)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("po_rclot_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_recpt_key).HasColumnName("po_recpt_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.po_rclot_qty).HasColumnName("po_rclot_qty");
            this.Property(t => t.po_rclot_stkqt).HasColumnName("po_rclot_stkqt");
            this.Property(t => t.po_rclot_retqt).HasColumnName("po_rclot_retqt");
            this.Property(t => t.po_rclot_cmnts).HasColumnName("po_rclot_cmnts");
            this.Property(t => t.po_rclot_vlot).HasColumnName("po_rclot_vlot");
            this.Property(t => t.po_rclot_frghtcst).HasColumnName("po_rclot_frghtcst");
            this.Property(t => t.po_rclot_matlcst).HasColumnName("po_rclot_matlcst");
            this.Property(t => t.po_rclot_othrcst).HasColumnName("po_rclot_othrcst");
            this.Property(t => t.po_rclot_reconqt).HasColumnName("po_rclot_reconqt");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.po_rclot_flatcst).HasColumnName("po_rclot_flatcst");
            this.Property(t => t.po_rclot_afillqty).HasColumnName("po_rclot_afillqty");
        }
    }
}
