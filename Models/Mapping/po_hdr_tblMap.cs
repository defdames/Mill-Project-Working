using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_hdr_tblMap : EntityTypeConfiguration<po_hdr_tbl>
    {
        public po_hdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_hdr_key });

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

            this.Property(t => t.pa_proj_key)
                .HasMaxLength(10);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_buyc)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_hdr_via)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_hdr_confm)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ar_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.po_hdr_remks)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_carr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_service_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_resn_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_hdr_cnfvia)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pa_atvty_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ap_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_fob_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_trnsport_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_sales)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_sales)
                .HasMaxLength(4);

            this.Property(t => t.po_hdr_exsus)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_hdr_sales)
                .HasMaxLength(10);

            this.Property(t => t.po_template_key)
                .HasMaxLength(20);

            this.Property(t => t.po_hdr_copyfrom)
                .HasMaxLength(10);

            this.Property(t => t.en_frgt_key)
                .HasMaxLength(10);

            this.Property(t => t.en_cstcnt_key)
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.sa_created_by)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("po_hdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.pa_proj_effdt).HasColumnName("pa_proj_effdt");
            this.Property(t => t.pa_proj_key).HasColumnName("pa_proj_key");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.in_buyc).HasColumnName("in_buyc");
            this.Property(t => t.po_hdr_typ).HasColumnName("po_hdr_typ");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.po_hdr_clsdt).HasColumnName("po_hdr_clsdt");
            this.Property(t => t.po_hdr_orddt).HasColumnName("po_hdr_orddt");
            this.Property(t => t.po_hdr_prmdt).HasColumnName("po_hdr_prmdt");
            this.Property(t => t.po_hdr_prtdt).HasColumnName("po_hdr_prtdt");
            this.Property(t => t.po_hdr_reqdt).HasColumnName("po_hdr_reqdt");
            this.Property(t => t.po_hdr_revdt).HasColumnName("po_hdr_revdt");
            this.Property(t => t.po_hdr_via).HasColumnName("po_hdr_via");
            this.Property(t => t.po_hdr_confm).HasColumnName("po_hdr_confm");
            this.Property(t => t.po_hdr_taxf).HasColumnName("po_hdr_taxf");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
            this.Property(t => t.po_hdr_remks).HasColumnName("po_hdr_remks");
            this.Property(t => t.po_hdr_revno).HasColumnName("po_hdr_revno");
            this.Property(t => t.po_hdr_hldcd).HasColumnName("po_hdr_hldcd");
            this.Property(t => t.po_hdr_stats).HasColumnName("po_hdr_stats");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.po_hdr_rate).HasColumnName("po_hdr_rate");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.po_hdr_upcnt).HasColumnName("po_hdr_upcnt");
            this.Property(t => t.po_hdr_prtfl).HasColumnName("po_hdr_prtfl");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.po_hdr_chgdt).HasColumnName("po_hdr_chgdt");
            this.Property(t => t.po_hdr_crtdt).HasColumnName("po_hdr_crtdt");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.po_hdr_cnfdt).HasColumnName("po_hdr_cnfdt");
            this.Property(t => t.po_hdr_dyely).HasColumnName("po_hdr_dyely");
            this.Property(t => t.po_resn_key).HasColumnName("po_resn_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.po_hdr_cnfvia).HasColumnName("po_hdr_cnfvia");
            this.Property(t => t.pa_atvty_key).HasColumnName("pa_atvty_key");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.ap_remt_adkey).HasColumnName("ap_remt_adkey");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.ap_delfm_adkey).HasColumnName("ap_delfm_adkey");
            this.Property(t => t.po_hdr_reldt).HasColumnName("po_hdr_reldt");
            this.Property(t => t.im_adres_vend).HasColumnName("im_adres_vend");
            this.Property(t => t.im_adres_whs).HasColumnName("im_adres_whs");
            this.Property(t => t.po_hdr_sendf).HasColumnName("po_hdr_sendf");
            this.Property(t => t.po_hdr_ordstatdt).HasColumnName("po_hdr_ordstatdt");
            this.Property(t => t.po_hdr_origto3).HasColumnName("po_hdr_origto3");
            this.Property(t => t.po_hdr_tobase).HasColumnName("po_hdr_tobase");
            this.Property(t => t.po_hdr_asofdt).HasColumnName("po_hdr_asofdt");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.po_hdr_type).HasColumnName("po_hdr_type");
            this.Property(t => t.po_hdr_declp).HasColumnName("po_hdr_declp");
            this.Property(t => t.po_hdr_incl).HasColumnName("po_hdr_incl");
            this.Property(t => t.po_hdr_eustatf).HasColumnName("po_hdr_eustatf");
            this.Property(t => t.po_hdr_eustatdt).HasColumnName("po_hdr_eustatdt");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
            this.Property(t => t.en_trnsport_key).HasColumnName("en_trnsport_key");
            this.Property(t => t.gl_cmp_sales).HasColumnName("gl_cmp_sales");
            this.Property(t => t.so_brnch_sales).HasColumnName("so_brnch_sales");
            this.Property(t => t.po_hdr_exsus).HasColumnName("po_hdr_exsus");
            this.Property(t => t.po_hdr_copyf).HasColumnName("po_hdr_copyf");
            this.Property(t => t.po_hdr_autovchf).HasColumnName("po_hdr_autovchf");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.so_hdr_sales).HasColumnName("so_hdr_sales");
            this.Property(t => t.po_template_key).HasColumnName("po_template_key");
            this.Property(t => t.po_hdr_copyfrom).HasColumnName("po_hdr_copyfrom");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.po_hdr_frtf).HasColumnName("po_hdr_frtf");
            this.Property(t => t.en_cstcnt_key).HasColumnName("en_cstcnt_key");
            this.Property(t => t.po_hdr_sendasnf).HasColumnName("po_hdr_sendasnf");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.po_hdr_fixedratef).HasColumnName("po_hdr_fixedratef");
            this.Property(t => t.po_hdr_shipfullf).HasColumnName("po_hdr_shipfullf");
            this.Property(t => t.po_hdr_ovrminlmtf).HasColumnName("po_hdr_ovrminlmtf");
            this.Property(t => t.sa_created_by).HasColumnName("sa_created_by");

            // Relationships
            this.HasRequired(t => t.sa_user_tbl)
                .WithMany(t => t.po_hdr_tbl)
                .HasForeignKey(d => d.sa_created_by);

        }
    }
}
