using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_msctr_tblMap : EntityTypeConfiguration<in_msctr_tbl>
    {
        public in_msctr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_msctr_key, t.in_item_key, t.im_pack_key, t.in_locn_key, t.in_lot_key, t.in_msctr_seq });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_msctr_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_msctr_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_msctr_enttp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_msctr_entid)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_msctr_ordtp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_msctr_cmpid)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_msctr_ordid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.in_msctr_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.in_msctr_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ap_resn_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("in_msctr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_msctr_key).HasColumnName("in_msctr_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_msctr_qty).HasColumnName("in_msctr_qty");
            this.Property(t => t.in_msctr_type).HasColumnName("in_msctr_type");
            this.Property(t => t.in_msctr_date).HasColumnName("in_msctr_date");
            this.Property(t => t.sa_frame_id).HasColumnName("sa_frame_id");
            this.Property(t => t.in_msctr_enttp).HasColumnName("in_msctr_enttp");
            this.Property(t => t.in_msctr_entid).HasColumnName("in_msctr_entid");
            this.Property(t => t.in_msctr_ordtp).HasColumnName("in_msctr_ordtp");
            this.Property(t => t.in_msctr_cmpid).HasColumnName("in_msctr_cmpid");
            this.Property(t => t.in_msctr_ordid).HasColumnName("in_msctr_ordid");
            this.Property(t => t.in_msctr_crtdt).HasColumnName("in_msctr_crtdt");
            this.Property(t => t.in_msctr_chgdt).HasColumnName("in_msctr_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_msctr_remk).HasColumnName("in_msctr_remk");
            this.Property(t => t.in_msctr_seq).HasColumnName("in_msctr_seq");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.in_msctr_upcnt).HasColumnName("in_msctr_upcnt");
        }
    }
}
