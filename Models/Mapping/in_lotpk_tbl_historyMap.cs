using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_lotpk_tbl_historyMap : EntityTypeConfiguration<in_lotpk_tbl_history>
    {
        public in_lotpk_tbl_historyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_perod_id, t.gl_perod_year, t.in_whs_key, t.in_locn_key, t.in_item_key, t.in_lot_key, t.im_pack_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_perod_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("in_lotpk_tbl_history");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_lot_cycdt).HasColumnName("in_lot_cycdt");
            this.Property(t => t.in_lot_lctqt).HasColumnName("in_lot_lctqt");
            this.Property(t => t.in_lot_lcycn).HasColumnName("in_lot_lcycn");
            this.Property(t => t.in_cycno_key).HasColumnName("in_cycno_key");
            this.Property(t => t.in_lot_qoh).HasColumnName("in_lot_qoh");
            this.Property(t => t.in_lotpk_issdt).HasColumnName("in_lotpk_issdt");
            this.Property(t => t.in_lotpk_recdt).HasColumnName("in_lotpk_recdt");
            this.Property(t => t.in_lotpk_lcst).HasColumnName("in_lotpk_lcst");
            this.Property(t => t.in_lotpk_upcnt).HasColumnName("in_lotpk_upcnt");
            this.Property(t => t.in_lotpk_sysdt).HasColumnName("in_lotpk_sysdt");
            this.Property(t => t.in_lotpk_pkrsv).HasColumnName("in_lotpk_pkrsv");
        }
    }
}
