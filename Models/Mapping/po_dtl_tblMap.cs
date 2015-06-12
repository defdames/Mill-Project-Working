using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_dtl_tblMap : EntityTypeConfiguration<po_dtl_tbl>
    {
        public po_dtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_hdr_key, t.po_dtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pa_proj_key)
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.po_dtl_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pa_atvty_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_work_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sf_req_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_vxrf_vpart)
                .HasMaxLength(30);

            this.Property(t => t.in_vmfg_mpno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ap_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_carr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_service_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_dtl_confm)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_dtl_cnfvia)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_contr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_dtl_cmmts)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ar_tax_key)
                .HasMaxLength(10);

            this.Property(t => t.en_vcpcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_dtl_delwhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_blkth_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_1099_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_pruom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.po_dtl_persn)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_fob_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cstcnt_key)
                .HasMaxLength(10);

            this.Property(t => t.po_dtl_persnemail)
                .HasMaxLength(60);

            this.Property(t => t.en_frgt_key)
                .HasMaxLength(10);

            this.Property(t => t.po_template_key)
                .HasMaxLength(20);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("po_dtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.pa_proj_key).HasColumnName("pa_proj_key");
            this.Property(t => t.pa_proj_effdt).HasColumnName("pa_proj_effdt");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_desc).HasColumnName("in_desc");
            this.Property(t => t.po_dtl_uom).HasColumnName("po_dtl_uom");
            this.Property(t => t.pa_atvty_key).HasColumnName("pa_atvty_key");
            this.Property(t => t.sf_work_key).HasColumnName("sf_work_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.po_dtl_clsdt).HasColumnName("po_dtl_clsdt");
            this.Property(t => t.po_dtl_entdt).HasColumnName("po_dtl_entdt");
            this.Property(t => t.po_dtl_prmdt).HasColumnName("po_dtl_prmdt");
            this.Property(t => t.po_dtl_reqdt).HasColumnName("po_dtl_reqdt");
            this.Property(t => t.po_dtl_ordqt).HasColumnName("po_dtl_ordqt");
            this.Property(t => t.po_dtl_dueqt).HasColumnName("po_dtl_dueqt");
            this.Property(t => t.po_dtl_quotc).HasColumnName("po_dtl_quotc");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.po_dtl_dbtqt).HasColumnName("po_dtl_dbtqt");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.po_dtl_hldqt).HasColumnName("po_dtl_hldqt");
            this.Property(t => t.sf_req_key).HasColumnName("sf_req_key");
            this.Property(t => t.in_vxrf_vpart).HasColumnName("in_vxrf_vpart");
            this.Property(t => t.in_vmfg_mpno).HasColumnName("in_vmfg_mpno");
            this.Property(t => t.po_dtl_stats).HasColumnName("po_dtl_stats");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.po_dtl_type).HasColumnName("po_dtl_type");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.po_dtl_chgdt).HasColumnName("po_dtl_chgdt");
            this.Property(t => t.po_dtl_crtdt).HasColumnName("po_dtl_crtdt");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.po_dtl_confm).HasColumnName("po_dtl_confm");
            this.Property(t => t.po_dtl_cnfdt).HasColumnName("po_dtl_cnfdt");
            this.Property(t => t.po_dtl_cnfvia).HasColumnName("po_dtl_cnfvia");
            this.Property(t => t.po_dtl_csgflg).HasColumnName("po_dtl_csgflg");
            this.Property(t => t.en_contr_key).HasColumnName("en_contr_key");
            this.Property(t => t.po_dtl_hldcd).HasColumnName("po_dtl_hldcd");
            this.Property(t => t.po_dtl_dyely).HasColumnName("po_dtl_dyely");
            this.Property(t => t.po_dtl_prcosf).HasColumnName("po_dtl_prcosf");
            this.Property(t => t.po_dtl_prcoln).HasColumnName("po_dtl_prcoln");
            this.Property(t => t.po_dtl_pshpf).HasColumnName("po_dtl_pshpf");
            this.Property(t => t.po_dtl_prtpkf).HasColumnName("po_dtl_prtpkf");
            this.Property(t => t.po_dtl_prtfl).HasColumnName("po_dtl_prtfl");
            this.Property(t => t.po_dtl_prtdt).HasColumnName("po_dtl_prtdt");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.po_dtl_cmmts).HasColumnName("po_dtl_cmmts");
            this.Property(t => t.po_dtl_taxf).HasColumnName("po_dtl_taxf");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.en_vcpcd_key).HasColumnName("en_vcpcd_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.po_dtl_upcnt).HasColumnName("po_dtl_upcnt");
            this.Property(t => t.ap_delfm_adkey).HasColumnName("ap_delfm_adkey");
            this.Property(t => t.po_dtl_tolst).HasColumnName("po_dtl_tolst");
            this.Property(t => t.po_dtl_cpapf).HasColumnName("po_dtl_cpapf");
            this.Property(t => t.po_dtl_manprc).HasColumnName("po_dtl_manprc");
            this.Property(t => t.po_dtl_delwhs).HasColumnName("po_dtl_delwhs");
            this.Property(t => t.po_blkth_key).HasColumnName("po_blkth_key");
            this.Property(t => t.po_blktd_key).HasColumnName("po_blktd_key");
            this.Property(t => t.po_dtl_specf).HasColumnName("po_dtl_specf");
            this.Property(t => t.en_vend_1099f).HasColumnName("en_vend_1099f");
            this.Property(t => t.en_1099_key).HasColumnName("en_1099_key");
            this.Property(t => t.im_adres_whs).HasColumnName("im_adres_whs");
            this.Property(t => t.po_dtl_prqty).HasColumnName("po_dtl_prqty");
            this.Property(t => t.en_uom_pruom).HasColumnName("en_uom_pruom");
            this.Property(t => t.po_dtl_slsusef).HasColumnName("po_dtl_slsusef");
            this.Property(t => t.po_dtl_persn).HasColumnName("po_dtl_persn");
            this.Property(t => t.po_dtl_quotcf).HasColumnName("po_dtl_quotcf");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.po_dtl_vatc).HasColumnName("po_dtl_vatc");
            this.Property(t => t.po_dtl_vatcf).HasColumnName("po_dtl_vatcf");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.so_dtl_sales).HasColumnName("so_dtl_sales");
            this.Property(t => t.po_dtl_apprstatus).HasColumnName("po_dtl_apprstatus");
            this.Property(t => t.en_cstcnt_key).HasColumnName("en_cstcnt_key");
            this.Property(t => t.po_dtl_persnemail).HasColumnName("po_dtl_persnemail");
            this.Property(t => t.po_dtl_priceexpf).HasColumnName("po_dtl_priceexpf");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.po_template_key).HasColumnName("po_template_key");
            this.Property(t => t.po_dtl_frtf).HasColumnName("po_dtl_frtf");
            this.Property(t => t.ap_invdtl_invqt).HasColumnName("ap_invdtl_invqt");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
        }
    }
}
