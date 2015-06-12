using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_hdr_tblMap : EntityTypeConfiguration<so_hdr_tbl>
    {
        public so_hdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_hdr_key });

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

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_adtxt)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.so_hdr_pytrm)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_hdr_cont)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_hdr_frgtshipuom)
                .HasMaxLength(2);

            this.Property(t => t.so_hdr_remks)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.so_hdr_tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_hdr_typec)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.so_hdr_cpono)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.so_hdr_porelease)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pa_proj_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_instl)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_hdr_stat)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.so_hdr_ref)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.so_resn_code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_created_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sa_modified_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.so_dtl_fobds)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_carr_key)
                .HasMaxLength(10);

            this.Property(t => t.en_frgt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.en_service_key)
                .HasMaxLength(10);

            this.Property(t => t.en_loadpf_key)
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_prcwtuom)
                .HasMaxLength(2);

            this.Property(t => t.so_hdr_expno)
                .HasMaxLength(25);

            this.Property(t => t.ar_tax_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_key)
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_exsus)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_temphdr_key)
                .HasMaxLength(20);

            this.Property(t => t.so_hdr_storeid)
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_intvndno)
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_deptno)
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_ccaudit)
                .HasMaxLength(76);

            this.Property(t => t.sa_webuser_key)
                .HasMaxLength(60);

            this.Property(t => t.gl_cmp_po)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_po)
                .HasMaxLength(4);

            this.Property(t => t.en_fob_key)
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_csono)
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_webid)
                .HasMaxLength(255);

            this.Property(t => t.so_hdr_prcconfid)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("so_hdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_bill_adkey).HasColumnName("ar_bill_adkey");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.ar_ship_adkey).HasColumnName("ar_ship_adkey");
            this.Property(t => t.ar_ship_adtxt).HasColumnName("ar_ship_adtxt");
            this.Property(t => t.so_hdr_revno).HasColumnName("so_hdr_revno");
            this.Property(t => t.so_hdr_revdt).HasColumnName("so_hdr_revdt");
            this.Property(t => t.so_hdr_reqdt).HasColumnName("so_hdr_reqdt");
            this.Property(t => t.so_hdr_clsdt).HasColumnName("so_hdr_clsdt");
            this.Property(t => t.so_hdr_lrvdt).HasColumnName("so_hdr_lrvdt");
            this.Property(t => t.so_hdr_prmdt).HasColumnName("so_hdr_prmdt");
            this.Property(t => t.so_hdr_prtdt).HasColumnName("so_hdr_prtdt");
            this.Property(t => t.so_hdr_espdt).HasColumnName("so_hdr_espdt");
            this.Property(t => t.so_hdr_pytrm).HasColumnName("so_hdr_pytrm");
            this.Property(t => t.so_hdr_cont).HasColumnName("so_hdr_cont");
            this.Property(t => t.so_hdr_frgtshipuom).HasColumnName("so_hdr_frgtshipuom");
            this.Property(t => t.so_hdr_remks).HasColumnName("so_hdr_remks");
            this.Property(t => t.so_hdr_tel).HasColumnName("so_hdr_tel");
            this.Property(t => t.so_hdr_shply).HasColumnName("so_hdr_shply");
            this.Property(t => t.so_hdr_holdf).HasColumnName("so_hdr_holdf");
            this.Property(t => t.so_hdr_typec).HasColumnName("so_hdr_typec");
            this.Property(t => t.so_hdr_cpono).HasColumnName("so_hdr_cpono");
            this.Property(t => t.so_hdr_porelease).HasColumnName("so_hdr_porelease");
            this.Property(t => t.pa_proj_key).HasColumnName("pa_proj_key");
            this.Property(t => t.so_hdr_invf).HasColumnName("so_hdr_invf");
            this.Property(t => t.so_hdr_instl).HasColumnName("so_hdr_instl");
            this.Property(t => t.so_hdr_stat).HasColumnName("so_hdr_stat");
            this.Property(t => t.so_hdr_ref).HasColumnName("so_hdr_ref");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.so_hdr_rate).HasColumnName("so_hdr_rate");
            this.Property(t => t.so_hdr_rvar).HasColumnName("so_hdr_rvar");
            this.Property(t => t.so_hdr_ciapc).HasColumnName("so_hdr_ciapc");
            this.Property(t => t.so_resn_code).HasColumnName("so_resn_code");
            this.Property(t => t.sa_created_by).HasColumnName("sa_created_by");
            this.Property(t => t.sa_modified_by).HasColumnName("sa_modified_by");
            this.Property(t => t.so_hdr_chgdt).HasColumnName("so_hdr_chgdt");
            this.Property(t => t.so_hdr_crtdt).HasColumnName("so_hdr_crtdt");
            this.Property(t => t.so_hdr_upcnt).HasColumnName("so_hdr_upcnt");
            this.Property(t => t.so_dtl_fobds).HasColumnName("so_dtl_fobds");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.en_loadpf_key).HasColumnName("en_loadpf_key");
            this.Property(t => t.so_hdr_prcwtuom).HasColumnName("so_hdr_prcwtuom");
            this.Property(t => t.so_hdr_frgtshipwt).HasColumnName("so_hdr_frgtshipwt");
            this.Property(t => t.so_hdr_sadrf).HasColumnName("so_hdr_sadrf");
            this.Property(t => t.so_hdr_badrf).HasColumnName("so_hdr_badrf");
            this.Property(t => t.sa_has_extf).HasColumnName("sa_has_extf");
            this.Property(t => t.so_hdr_expno).HasColumnName("so_hdr_expno");
            this.Property(t => t.so_hdr_autofrcmbf).HasColumnName("so_hdr_autofrcmbf");
            this.Property(t => t.so_hdr_cncldt).HasColumnName("so_hdr_cncldt");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.so_hdr_taxf).HasColumnName("so_hdr_taxf");
            this.Property(t => t.so_hdr_ogroprcwt).HasColumnName("so_hdr_ogroprcwt");
            this.Property(t => t.so_hdr_onetprcwt).HasColumnName("so_hdr_onetprcwt");
            this.Property(t => t.so_hdr_dmctlf).HasColumnName("so_hdr_dmctlf");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.ar_bill_exsus).HasColumnName("ar_bill_exsus");
            this.Property(t => t.so_hdr_origto3).HasColumnName("so_hdr_origto3");
            this.Property(t => t.so_hdr_tobase).HasColumnName("so_hdr_tobase");
            this.Property(t => t.so_hdr_asofdt).HasColumnName("so_hdr_asofdt");
            this.Property(t => t.so_hdr_whordf).HasColumnName("so_hdr_whordf");
            this.Property(t => t.so_hdr_prcorddt).HasColumnName("so_hdr_prcorddt");
            this.Property(t => t.so_hdr_prcshpdt).HasColumnName("so_hdr_prcshpdt");
            this.Property(t => t.so_temphdr_key).HasColumnName("so_temphdr_key");
            this.Property(t => t.so_hdr_storeid).HasColumnName("so_hdr_storeid");
            this.Property(t => t.ar_bill_intvndno).HasColumnName("ar_bill_intvndno");
            this.Property(t => t.so_hdr_deptno).HasColumnName("so_hdr_deptno");
            this.Property(t => t.so_hdr_stradrf).HasColumnName("so_hdr_stradrf");
            this.Property(t => t.so_hdr_ccaudit).HasColumnName("so_hdr_ccaudit");
            this.Property(t => t.sa_webuser_key).HasColumnName("sa_webuser_key");
            this.Property(t => t.so_hdr_eustat).HasColumnName("so_hdr_eustat");
            this.Property(t => t.so_hdr_eustatdt).HasColumnName("so_hdr_eustatdt");
            this.Property(t => t.ei_atf_key).HasColumnName("ei_atf_key");
            this.Property(t => t.gl_cmp_po).HasColumnName("gl_cmp_po");
            this.Property(t => t.so_brnch_po).HasColumnName("so_brnch_po");
            this.Property(t => t.so_hdr_intcmpf).HasColumnName("so_hdr_intcmpf");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
            this.Property(t => t.so_hdr_asynchstat).HasColumnName("so_hdr_asynchstat");
            this.Property(t => t.so_hdr_usagef).HasColumnName("so_hdr_usagef");
            this.Property(t => t.so_hdr_ettbillcf).HasColumnName("so_hdr_ettbillcf");
            this.Property(t => t.so_hdr_csono).HasColumnName("so_hdr_csono");
            this.Property(t => t.im_cntct_key).HasColumnName("im_cntct_key");
            this.Property(t => t.so_hdr_webid).HasColumnName("so_hdr_webid");
            this.Property(t => t.so_hdr_prcconfid).HasColumnName("so_hdr_prcconfid");
            this.Property(t => t.so_hdr_maxdtl).HasColumnName("so_hdr_maxdtl");
        }
    }
}
