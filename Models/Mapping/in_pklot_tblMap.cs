using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_pklot_tblMap : EntityTypeConfiguration<in_pklot_tbl>
    {
        public in_pklot_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_pick_key, t.in_pkpeg_key, t.in_lot_key, t.in_locn_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_pick_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_pkpeg_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_pklot_typ)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_pklot_entty)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_pklot_doc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_demand)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("in_pklot_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_pick_key).HasColumnName("in_pick_key");
            this.Property(t => t.in_pkpeg_key).HasColumnName("in_pkpeg_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_pklot_pikqt).HasColumnName("in_pklot_pikqt");
            this.Property(t => t.in_pklot_pikpk).HasColumnName("in_pklot_pikpk");
            this.Property(t => t.in_pklot_shpqt).HasColumnName("in_pklot_shpqt");
            this.Property(t => t.in_pklot_shppk).HasColumnName("in_pklot_shppk");
            this.Property(t => t.in_pklot_reqqt).HasColumnName("in_pklot_reqqt");
            this.Property(t => t.in_pklot_reqpk).HasColumnName("in_pklot_reqpk");
            this.Property(t => t.in_pklot_loadqt).HasColumnName("in_pklot_loadqt");
            this.Property(t => t.in_pklot_loadpk).HasColumnName("in_pklot_loadpk");
            this.Property(t => t.in_pklot_typ).HasColumnName("in_pklot_typ");
            this.Property(t => t.in_pklot_entty).HasColumnName("in_pklot_entty");
            this.Property(t => t.in_pklot_doc).HasColumnName("in_pklot_doc");
            this.Property(t => t.in_pklot_line).HasColumnName("in_pklot_line");
            this.Property(t => t.gl_cmp_demand).HasColumnName("gl_cmp_demand");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_pklot_chgdt).HasColumnName("in_pklot_chgdt");
            this.Property(t => t.in_pklot_crtdt).HasColumnName("in_pklot_crtdt");
            this.Property(t => t.in_pklot_strmlnpc).HasColumnName("in_pklot_strmlnpc");
            this.Property(t => t.in_pklot_upcnt).HasColumnName("in_pklot_upcnt");
        }
    }
}
