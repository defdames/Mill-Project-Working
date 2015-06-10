using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_dtl_tblMap : EntityTypeConfiguration<so_dtl_tbl>
    {
        public so_dtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_hdr_key, t.so_dtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_adtxt)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.in_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.in_prod_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pa_proj_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_work_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_remks)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.so_dtl_stats)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_dtl_cprtn)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.in_pgc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_cpono)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.so_dtl_porelease)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_lngrp)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.so_dtl_shpws)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_resn_code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_sltyp)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_cpshf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.so_dtl_fobds)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_pruom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_dtl_auom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_created_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sa_modified_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.en_service_key)
                .HasMaxLength(10);

            this.Property(t => t.en_carr_key)
                .HasMaxLength(10);

            this.Property(t => t.en_loadpf_key)
                .HasMaxLength(10);

            this.Property(t => t.en_frgt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_expno)
                .HasMaxLength(25);

            this.Property(t => t.so_temphdr_key)
                .HasMaxLength(20);

            this.Property(t => t.so_dtl_storeid)
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_deptno)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_profit)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_profit)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_ship)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_ship)
                .HasMaxLength(4);

            this.Property(t => t.so_dtl_shfvatregno)
                .HasMaxLength(20);

            this.Property(t => t.so_dtl_shtvatregno)
                .HasMaxLength(20);

            this.Property(t => t.so_dtl_exsus)
                .HasMaxLength(20);

            this.Property(t => t.sf_plant_key)
                .HasMaxLength(4);

            this.Property(t => t.so_enduse_key)
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_icsono)
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_invrsvid)
                .HasMaxLength(255);

            this.Property(t => t.so_dtl_prty)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("so_dtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.ar_ship_adkey).HasColumnName("ar_ship_adkey");
            this.Property(t => t.ar_ship_adtxt).HasColumnName("ar_ship_adtxt");
            this.Property(t => t.in_prod_key).HasColumnName("in_prod_key");
            this.Property(t => t.in_prod_desc).HasColumnName("in_prod_desc");
            this.Property(t => t.in_prod_uom).HasColumnName("in_prod_uom");
            this.Property(t => t.pa_proj_key).HasColumnName("pa_proj_key");
            this.Property(t => t.sf_work_key).HasColumnName("sf_work_key");
            this.Property(t => t.so_dtl_remks).HasColumnName("so_dtl_remks");
            this.Property(t => t.so_dtl_entdt).HasColumnName("so_dtl_entdt");
            this.Property(t => t.so_dtl_clsdt).HasColumnName("so_dtl_clsdt");
            this.Property(t => t.so_dtl_reqdt).HasColumnName("so_dtl_reqdt");
            this.Property(t => t.so_dtl_prmdt).HasColumnName("so_dtl_prmdt");
            this.Property(t => t.so_dtl_shsdt).HasColumnName("so_dtl_shsdt");
            this.Property(t => t.so_dtl_shpdt).HasColumnName("so_dtl_shpdt");
            this.Property(t => t.so_dtl_ordqt).HasColumnName("so_dtl_ordqt");
            this.Property(t => t.so_dtl_shpqt).HasColumnName("so_dtl_shpqt");
            this.Property(t => t.so_dtl_invqt).HasColumnName("so_dtl_invqt");
            this.Property(t => t.so_dtl_retqt).HasColumnName("so_dtl_retqt");
            this.Property(t => t.so_dtl_totaq).HasColumnName("so_dtl_totaq");
            this.Property(t => t.so_dtl_pikqt).HasColumnName("so_dtl_pikqt");
            this.Property(t => t.so_dtl_pkdqt).HasColumnName("so_dtl_pkdqt");
            this.Property(t => t.so_dtl_costc).HasColumnName("so_dtl_costc");
            this.Property(t => t.so_dtl_ltaxf).HasColumnName("so_dtl_ltaxf");
            this.Property(t => t.so_dtl_shply).HasColumnName("so_dtl_shply");
            this.Property(t => t.so_dtl_stats).HasColumnName("so_dtl_stats");
            this.Property(t => t.so_prod_shipf).HasColumnName("so_prod_shipf");
            this.Property(t => t.so_dtl_cprtn).HasColumnName("so_dtl_cprtn");
            this.Property(t => t.in_pgc_key).HasColumnName("in_pgc_key");
            this.Property(t => t.so_dtl_prtsf).HasColumnName("so_dtl_prtsf");
            this.Property(t => t.so_dtl_cpoln).HasColumnName("so_dtl_cpoln");
            this.Property(t => t.so_dtl_cpono).HasColumnName("so_dtl_cpono");
            this.Property(t => t.so_dtl_porelease).HasColumnName("so_dtl_porelease");
            this.Property(t => t.so_dtl_lngrp).HasColumnName("so_dtl_lngrp");
            this.Property(t => t.so_dtl_shpws).HasColumnName("so_dtl_shpws");
            this.Property(t => t.so_resn_code).HasColumnName("so_resn_code");
            this.Property(t => t.so_dtl_sltyp).HasColumnName("so_dtl_sltyp");
            this.Property(t => t.so_dtl_rshdt).HasColumnName("so_dtl_rshdt");
            this.Property(t => t.so_dtl_cpshf).HasColumnName("so_dtl_cpshf");
            this.Property(t => t.so_dtl_fobds).HasColumnName("so_dtl_fobds");
            this.Property(t => t.en_ship_fobfl).HasColumnName("en_ship_fobfl");
            this.Property(t => t.so_dtl_holdf).HasColumnName("so_dtl_holdf");
            this.Property(t => t.so_dtl_mstln).HasColumnName("so_dtl_mstln");
            this.Property(t => t.so_dtl_prtpk).HasColumnName("so_dtl_prtpk");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.so_dtl_pruom).HasColumnName("so_dtl_pruom");
            this.Property(t => t.so_dtl_tolst).HasColumnName("so_dtl_tolst");
            this.Property(t => t.so_dtl_tolsh).HasColumnName("so_dtl_tolsh");
            this.Property(t => t.so_dtl_psapf).HasColumnName("so_dtl_psapf");
            this.Property(t => t.so_dtl_auom).HasColumnName("so_dtl_auom");
            this.Property(t => t.so_dtl_aordq).HasColumnName("so_dtl_aordq");
            this.Property(t => t.sa_created_by).HasColumnName("sa_created_by");
            this.Property(t => t.sa_modified_by).HasColumnName("sa_modified_by");
            this.Property(t => t.so_dtl_chgdt).HasColumnName("so_dtl_chgdt");
            this.Property(t => t.so_dtl_specf).HasColumnName("so_dtl_specf");
            this.Property(t => t.so_dtl_ldplqt).HasColumnName("so_dtl_ldplqt");
            this.Property(t => t.so_dtl_loadqt).HasColumnName("so_dtl_loadqt");
            this.Property(t => t.so_dtl_loadplf).HasColumnName("so_dtl_loadplf");
            this.Property(t => t.so_dtl_adjfl).HasColumnName("so_dtl_adjfl");
            this.Property(t => t.so_dtl_listc).HasColumnName("so_dtl_listc");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.en_loadpf_key).HasColumnName("en_loadpf_key");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.so_dtl_sadrf).HasColumnName("so_dtl_sadrf");
            this.Property(t => t.sa_has_extf).HasColumnName("sa_has_extf");
            this.Property(t => t.so_dtl_expno).HasColumnName("so_dtl_expno");
            this.Property(t => t.so_dtl_s1ltf).HasColumnName("so_dtl_s1ltf");
            this.Property(t => t.so_dtl_cncldt).HasColumnName("so_dtl_cncldt");
            this.Property(t => t.so_dtl_upcnt).HasColumnName("so_dtl_upcnt");
            this.Property(t => t.so_dtl_tollif).HasColumnName("so_dtl_tollif");
            this.Property(t => t.so_dtl_tolpkf).HasColumnName("so_dtl_tolpkf");
            this.Property(t => t.so_dtl_tollof).HasColumnName("so_dtl_tollof");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.so_temphdr_key).HasColumnName("so_temphdr_key");
            this.Property(t => t.so_dtl_storeid).HasColumnName("so_dtl_storeid");
            this.Property(t => t.so_dtl_deptno).HasColumnName("so_dtl_deptno");
            this.Property(t => t.so_dtl_ucclreqf).HasColumnName("so_dtl_ucclreqf");
            this.Property(t => t.so_dtl_stradrf).HasColumnName("so_dtl_stradrf");
            this.Property(t => t.so_dtl_ccamt).HasColumnName("so_dtl_ccamt");
            this.Property(t => t.so_dtl_nobkordf).HasColumnName("so_dtl_nobkordf");
            this.Property(t => t.gl_cmp_profit).HasColumnName("gl_cmp_profit");
            this.Property(t => t.so_brnch_profit).HasColumnName("so_brnch_profit");
            this.Property(t => t.gl_cmp_ship).HasColumnName("gl_cmp_ship");
            this.Property(t => t.so_brnch_ship).HasColumnName("so_brnch_ship");
            this.Property(t => t.so_dtl_shfvatregno).HasColumnName("so_dtl_shfvatregno");
            this.Property(t => t.so_dtl_shtvatregno).HasColumnName("so_dtl_shtvatregno");
            this.Property(t => t.so_dtl_exsus).HasColumnName("so_dtl_exsus");
            this.Property(t => t.so_dtl_cnsgnf).HasColumnName("so_dtl_cnsgnf");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.so_dtl_expeditef).HasColumnName("so_dtl_expeditef");
            this.Property(t => t.so_enduse_key).HasColumnName("so_enduse_key");
            this.Property(t => t.so_hdr_icsono).HasColumnName("so_hdr_icsono");
            this.Property(t => t.so_dtl_csoln).HasColumnName("so_dtl_csoln");
            this.Property(t => t.so_dtl_icsoln).HasColumnName("so_dtl_icsoln");
            this.Property(t => t.so_tempdtl_key).HasColumnName("so_tempdtl_key");
            this.Property(t => t.so_dtl_crtprdordf).HasColumnName("so_dtl_crtprdordf");
            this.Property(t => t.so_dtl_webln).HasColumnName("so_dtl_webln");
            this.Property(t => t.so_dtl_invrsvid).HasColumnName("so_dtl_invrsvid");
            this.Property(t => t.so_dtl_prty).HasColumnName("so_dtl_prty");
        }
    }
}
