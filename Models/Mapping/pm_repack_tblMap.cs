using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_repack_tblMap : EntityTypeConfiguration<pm_repack_tbl>
    {
        public pm_repack_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.in_item_key, t.pm_repack_typ, t.im_pack_key, t.pm_tpack_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pm_repack_typ)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pm_tpack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.im_pack_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_pack_fl)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pm_tpack_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pm_tpack_rout)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pm_repack_astplid)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("pm_repack_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pm_repack_typ).HasColumnName("pm_repack_typ");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.pm_tpack_key).HasColumnName("pm_tpack_key");
            this.Property(t => t.im_pack_qty).HasColumnName("im_pack_qty");
            this.Property(t => t.im_pack_uom).HasColumnName("im_pack_uom");
            this.Property(t => t.im_pack_yldfac).HasColumnName("im_pack_yldfac");
            this.Property(t => t.pn_pack_fl).HasColumnName("pn_pack_fl");
            this.Property(t => t.pn_pack_seq).HasColumnName("pn_pack_seq");
            this.Property(t => t.pm_tpack_qty).HasColumnName("pm_tpack_qty");
            this.Property(t => t.pm_tpack_uom).HasColumnName("pm_tpack_uom");
            this.Property(t => t.pm_tpack_rout).HasColumnName("pm_tpack_rout");
            this.Property(t => t.pm_repack_advschf).HasColumnName("pm_repack_advschf");
            this.Property(t => t.pm_repack_pstpver).HasColumnName("pm_repack_pstpver");
            this.Property(t => t.pm_repack_astplid).HasColumnName("pm_repack_astplid");
            this.Property(t => t.pm_repack_upcnt).HasColumnName("pm_repack_upcnt");
        }
    }
}
