using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_cycnt_tblMap : EntityTypeConfiguration<in_cycnt_tbl>
    {
        public in_cycnt_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_cycnt_key, t.in_cycnt_seqno });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_cycnt_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_cycnt_seqno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_cyccd_key)
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .HasMaxLength(6);

            this.Property(t => t.in_lot_key)
                .HasMaxLength(25);

            this.Property(t => t.in_locn_key)
                .HasMaxLength(10);

            this.Property(t => t.in_cycnt_resn)
                .HasMaxLength(10);

            this.Property(t => t.in_cycnt_remk)
                .HasMaxLength(30);

            this.Property(t => t.in_cycnt_user)
                .HasMaxLength(8);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("in_cycnt_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_cycnt_key).HasColumnName("in_cycnt_key");
            this.Property(t => t.in_cycnt_seqno).HasColumnName("in_cycnt_seqno");
            this.Property(t => t.in_cyccd_key).HasColumnName("in_cyccd_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.in_cycnt_qoh).HasColumnName("in_cycnt_qoh");
            this.Property(t => t.in_cycnt_qohdt).HasColumnName("in_cycnt_qohdt");
            this.Property(t => t.in_cycnt_cntqt).HasColumnName("in_cycnt_cntqt");
            this.Property(t => t.in_cycnt_cntdt).HasColumnName("in_cycnt_cntdt");
            this.Property(t => t.in_cycnt_varqt).HasColumnName("in_cycnt_varqt");
            this.Property(t => t.in_cycnt_vardol).HasColumnName("in_cycnt_vardol");
            this.Property(t => t.in_cycnt_error).HasColumnName("in_cycnt_error");
            this.Property(t => t.in_cycnt_resn).HasColumnName("in_cycnt_resn");
            this.Property(t => t.in_cycnt_remk).HasColumnName("in_cycnt_remk");
            this.Property(t => t.in_cycnt_user).HasColumnName("in_cycnt_user");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_cycnt_chgdt).HasColumnName("in_cycnt_chgdt");
            this.Property(t => t.in_cycnt_crtdt).HasColumnName("in_cycnt_crtdt");
            this.Property(t => t.in_cycnt_upcnt).HasColumnName("in_cycnt_upcnt");
            this.Property(t => t.in_cycnt_aqoh).HasColumnName("in_cycnt_aqoh");
            this.Property(t => t.in_cycnt_acntqt).HasColumnName("in_cycnt_acntqt");
            this.Property(t => t.in_cycnt_acntdt).HasColumnName("in_cycnt_acntdt");
            this.Property(t => t.in_cycnt_avarqt).HasColumnName("in_cycnt_avarqt");
            this.Property(t => t.in_cycnt_rolloverf).HasColumnName("in_cycnt_rolloverf");
        }
    }
}
