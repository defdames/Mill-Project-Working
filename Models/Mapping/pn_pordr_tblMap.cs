using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pn_pordr_tblMap : EntityTypeConfiguration<pn_pordr_tbl>
    {
        public pn_pordr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pn_sched_key, t.in_item_key, t.pn_entty_sourc, t.pn_pordr_reqdt, t.pn_pordr_seq });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_sched_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pn_entty_sourc)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_pordr_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pn_actnm_key)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_fpo_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pn_pordr_plnt)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_wthdr_towhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_wthdr_frwhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_prcss_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_frmla_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("pn_pordr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pn_sched_key).HasColumnName("pn_sched_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pn_entty_sourc).HasColumnName("pn_entty_sourc");
            this.Property(t => t.pn_pordr_reqdt).HasColumnName("pn_pordr_reqdt");
            this.Property(t => t.pn_pordr_seq).HasColumnName("pn_pordr_seq");
            this.Property(t => t.pn_pordr_reldt).HasColumnName("pn_pordr_reldt");
            this.Property(t => t.pn_pordr_ordqt).HasColumnName("pn_pordr_ordqt");
            this.Property(t => t.pn_actnm_key).HasColumnName("pn_actnm_key");
            this.Property(t => t.pn_fpo_key).HasColumnName("pn_fpo_key");
            this.Property(t => t.pn_pordr_plnt).HasColumnName("pn_pordr_plnt");
            this.Property(t => t.pn_pordr_yqty).HasColumnName("pn_pordr_yqty");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.in_wthdr_towhs).HasColumnName("in_wthdr_towhs");
            this.Property(t => t.in_wthdr_frwhs).HasColumnName("in_wthdr_frwhs");
            this.Property(t => t.sf_prcss_key).HasColumnName("sf_prcss_key");
            this.Property(t => t.sf_prcss_ver).HasColumnName("sf_prcss_ver");
            this.Property(t => t.sf_frmla_key).HasColumnName("sf_frmla_key");
            this.Property(t => t.sf_frmla_ver).HasColumnName("sf_frmla_ver");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.pn_pordr_bulkqty).HasColumnName("pn_pordr_bulkqty");
            this.Property(t => t.pn_pordr_target).HasColumnName("pn_pordr_target");
            this.Property(t => t.pn_pordr_upcnt).HasColumnName("pn_pordr_upcnt");
        }
    }
}
