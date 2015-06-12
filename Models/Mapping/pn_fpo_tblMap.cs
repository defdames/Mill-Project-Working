using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pn_fpo_tblMap : EntityTypeConfiguration<pn_fpo_tbl>
    {
        public pn_fpo_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pn_fpo_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_fpo_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pn_sched_key)
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pn_fpo_remks)
                .IsRequired()
                .HasMaxLength(60);

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

            this.Property(t => t.pn_fpo_refkey)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pn_fpo_refkey2)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pn_fpo_refkey3)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_buyc_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.pn_fpo_authby)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_fpo_batchid)
                .HasMaxLength(15);

            this.Property(t => t.pn_fpo_orderid)
                .HasMaxLength(40);

            this.Property(t => t.pn_fpo_modelid)
                .HasMaxLength(20);

            this.Property(t => t.pn_fpo_ptbatch)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("pn_fpo_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pn_fpo_key).HasColumnName("pn_fpo_key");
            this.Property(t => t.pn_sched_key).HasColumnName("pn_sched_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pn_fpo_reldt).HasColumnName("pn_fpo_reldt");
            this.Property(t => t.pn_fpo_reqdt).HasColumnName("pn_fpo_reqdt");
            this.Property(t => t.pn_fpo_yqty).HasColumnName("pn_fpo_yqty");
            this.Property(t => t.pn_fpo_reqqt).HasColumnName("pn_fpo_reqqt");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.pn_fpo_remks).HasColumnName("pn_fpo_remks");
            this.Property(t => t.pn_fpo_upcnt).HasColumnName("pn_fpo_upcnt");
            this.Property(t => t.pn_grpnum_key).HasColumnName("pn_grpnum_key");
            this.Property(t => t.pn_fpo_target).HasColumnName("pn_fpo_target");
            this.Property(t => t.pn_fpo_subtyp).HasColumnName("pn_fpo_subtyp");
            this.Property(t => t.pn_fpo_origin).HasColumnName("pn_fpo_origin");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.in_wthdr_towhs).HasColumnName("in_wthdr_towhs");
            this.Property(t => t.in_wthdr_frwhs).HasColumnName("in_wthdr_frwhs");
            this.Property(t => t.sf_prcss_key).HasColumnName("sf_prcss_key");
            this.Property(t => t.sf_prcss_ver).HasColumnName("sf_prcss_ver");
            this.Property(t => t.sf_frmla_key).HasColumnName("sf_frmla_key");
            this.Property(t => t.sf_frmla_ver).HasColumnName("sf_frmla_ver");
            this.Property(t => t.pn_fpo_refkey).HasColumnName("pn_fpo_refkey");
            this.Property(t => t.pn_fpo_refkey2).HasColumnName("pn_fpo_refkey2");
            this.Property(t => t.pn_fpo_refkey3).HasColumnName("pn_fpo_refkey3");
            this.Property(t => t.in_buyc_key).HasColumnName("in_buyc_key");
            this.Property(t => t.pn_fpo_bulkqty).HasColumnName("pn_fpo_bulkqty");
            this.Property(t => t.pn_fpo_authby).HasColumnName("pn_fpo_authby");
            this.Property(t => t.pn_fpo_authdt).HasColumnName("pn_fpo_authdt");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.pn_fpo_batchid).HasColumnName("pn_fpo_batchid");
            this.Property(t => t.pn_fpo_schdlf).HasColumnName("pn_fpo_schdlf");
            this.Property(t => t.pn_fpo_reqdttm).HasColumnName("pn_fpo_reqdttm");
            this.Property(t => t.pn_fpo_startdttm).HasColumnName("pn_fpo_startdttm");
            this.Property(t => t.pn_fpo_dtstamp).HasColumnName("pn_fpo_dtstamp");
            this.Property(t => t.pn_fpo_orderid).HasColumnName("pn_fpo_orderid");
            this.Property(t => t.pn_fpo_modelid).HasColumnName("pn_fpo_modelid");
            this.Property(t => t.pn_fpo_pstpver).HasColumnName("pn_fpo_pstpver");
            this.Property(t => t.pn_fpo_matlsubflg).HasColumnName("pn_fpo_matlsubflg");
            this.Property(t => t.pn_fpo_rescsubflg).HasColumnName("pn_fpo_rescsubflg");
            this.Property(t => t.pn_fpo_shift).HasColumnName("pn_fpo_shift");
            this.Property(t => t.pn_fpo_ptbatch).HasColumnName("pn_fpo_ptbatch");
        }
    }
}
