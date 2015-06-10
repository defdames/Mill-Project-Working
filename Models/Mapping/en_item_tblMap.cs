using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_item_tblMap : EntityTypeConfiguration<en_item_tbl>
    {
        public en_item_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_item_key);

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_item_sdesc)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.en_item_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_phfmt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mohcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_item_abcc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_srce_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_class_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_comcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_type_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_itgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_itcat_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_item_trdnm)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.en_ituse_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_item_trdmk)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_item_orgin)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_audt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_item_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.en_subst_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_item_duom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_item_wuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_item_ssds)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_item_ssby)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_item_revno)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_item_drwsz)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_item_drwno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ec_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_item_srlf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_catlg_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_gtech_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_item_dmuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_item_chem)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_phyfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_item_cert)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_item_lot)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_item_msds)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_item_clrno)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_item_cas)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_item_ca2)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_item_dotpg)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_item_hzpdo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_item_hzpun)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_uomgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_item_vuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_frtitem_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.en_item_upcean)
                .HasMaxLength(13);

            this.Property(t => t.en_item_scccode)
                .HasMaxLength(14);

            this.Property(t => t.en_item_sccdesc)
                .HasMaxLength(60);

            this.Property(t => t.en_item_lotfrmt)
                .HasMaxLength(250);

            this.Property(t => t.en_item_procname)
                .HasMaxLength(32);

            this.Property(t => t.en_gtin_key)
                .HasMaxLength(14);

            this.Property(t => t.en_uom_alternate)
                .HasMaxLength(2);

            this.Property(t => t.en_invacctgrp_key)
                .HasMaxLength(10);

            this.Property(t => t.en_item_plotfrmt)
                .HasMaxLength(250);

            this.Property(t => t.en_item_mlotfrmt)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("en_item_tbl");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.en_item_sdesc).HasColumnName("en_item_sdesc");
            this.Property(t => t.en_item_desc).HasColumnName("en_item_desc");
            this.Property(t => t.en_item_cmth).HasColumnName("en_item_cmth");
            this.Property(t => t.en_phfmt_key).HasColumnName("en_phfmt_key");
            this.Property(t => t.en_item_shelf).HasColumnName("en_item_shelf");
            this.Property(t => t.en_item_lead).HasColumnName("en_item_lead");
            this.Property(t => t.en_mohcd_key).HasColumnName("en_mohcd_key");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.en_item_abcc).HasColumnName("en_item_abcc");
            this.Property(t => t.en_srce_key).HasColumnName("en_srce_key");
            this.Property(t => t.en_class_key).HasColumnName("en_class_key");
            this.Property(t => t.en_comcd_key).HasColumnName("en_comcd_key");
            this.Property(t => t.en_item_ndysp).HasColumnName("en_item_ndysp");
            this.Property(t => t.en_item_sstk).HasColumnName("en_item_sstk");
            this.Property(t => t.en_item_minoq).HasColumnName("en_item_minoq");
            this.Property(t => t.en_item_ropt).HasColumnName("en_item_ropt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_item_lscdt).HasColumnName("en_item_lscdt");
            this.Property(t => t.en_item_pmcd).HasColumnName("en_item_pmcd");
            this.Property(t => t.en_type_key).HasColumnName("en_type_key");
            this.Property(t => t.en_itgrp_key).HasColumnName("en_itgrp_key");
            this.Property(t => t.en_itcat_key).HasColumnName("en_itcat_key");
            this.Property(t => t.en_item_trdnm).HasColumnName("en_item_trdnm");
            this.Property(t => t.en_ituse_key).HasColumnName("en_ituse_key");
            this.Property(t => t.en_item_trdmk).HasColumnName("en_item_trdmk");
            this.Property(t => t.en_item_orgin).HasColumnName("en_item_orgin");
            this.Property(t => t.en_audt_key).HasColumnName("en_audt_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_item_cmnts).HasColumnName("en_item_cmnts");
            this.Property(t => t.en_item_crtdt).HasColumnName("en_item_crtdt");
            this.Property(t => t.en_item_chgdt).HasColumnName("en_item_chgdt");
            this.Property(t => t.en_subst_key).HasColumnName("en_subst_key");
            this.Property(t => t.en_item_duom).HasColumnName("en_item_duom");
            this.Property(t => t.en_item_wgt).HasColumnName("en_item_wgt");
            this.Property(t => t.en_item_wuom).HasColumnName("en_item_wuom");
            this.Property(t => t.en_item_cnfgf).HasColumnName("en_item_cnfgf");
            this.Property(t => t.en_item_ssds).HasColumnName("en_item_ssds");
            this.Property(t => t.en_ssds_date).HasColumnName("en_ssds_date");
            this.Property(t => t.en_item_ssby).HasColumnName("en_item_ssby");
            this.Property(t => t.en_ssby_date).HasColumnName("en_ssby_date");
            this.Property(t => t.en_item_revno).HasColumnName("en_item_revno");
            this.Property(t => t.en_item_drwsz).HasColumnName("en_item_drwsz");
            this.Property(t => t.en_item_drwno).HasColumnName("en_item_drwno");
            this.Property(t => t.ec_hdr_key).HasColumnName("ec_hdr_key");
            this.Property(t => t.en_item_srlf).HasColumnName("en_item_srlf");
            this.Property(t => t.en_catlg_key).HasColumnName("en_catlg_key");
            this.Property(t => t.en_item_wdth).HasColumnName("en_item_wdth");
            this.Property(t => t.en_item_hght).HasColumnName("en_item_hght");
            this.Property(t => t.en_item_dpth).HasColumnName("en_item_dpth");
            this.Property(t => t.en_gtech_key).HasColumnName("en_gtech_key");
            this.Property(t => t.en_item_dmuom).HasColumnName("en_item_dmuom");
            this.Property(t => t.en_item_chem).HasColumnName("en_item_chem");
            this.Property(t => t.en_phyfm_key).HasColumnName("en_phyfm_key");
            this.Property(t => t.en_item_spgvt).HasColumnName("en_item_spgvt");
            this.Property(t => t.en_item_cert).HasColumnName("en_item_cert");
            this.Property(t => t.en_item_yldf).HasColumnName("en_item_yldf");
            this.Property(t => t.en_item_lot).HasColumnName("en_item_lot");
            this.Property(t => t.en_item_msds).HasColumnName("en_item_msds");
            this.Property(t => t.en_item_clrno).HasColumnName("en_item_clrno");
            this.Property(t => t.en_item_cas).HasColumnName("en_item_cas");
            this.Property(t => t.en_item_ca2).HasColumnName("en_item_ca2");
            this.Property(t => t.en_item_dotpg).HasColumnName("en_item_dotpg");
            this.Property(t => t.en_item_hzpdo).HasColumnName("en_item_hzpdo");
            this.Property(t => t.en_item_hzpun).HasColumnName("en_item_hzpun");
            this.Property(t => t.en_item_cpk).HasColumnName("en_item_cpk");
            this.Property(t => t.en_item_lvlcd).HasColumnName("en_item_lvlcd");
            this.Property(t => t.en_item_allocf).HasColumnName("en_item_allocf");
            this.Property(t => t.en_item_pickf).HasColumnName("en_item_pickf");
            this.Property(t => t.en_item_bkflf).HasColumnName("en_item_bkflf");
            this.Property(t => t.en_item_lotalcf).HasColumnName("en_item_lotalcf");
            this.Property(t => t.en_item_sopolicy).HasColumnName("en_item_sopolicy");
            this.Property(t => t.en_item_wtpolicy).HasColumnName("en_item_wtpolicy");
            this.Property(t => t.en_item_wopolicy).HasColumnName("en_item_wopolicy");
            this.Property(t => t.en_uomgrp_key).HasColumnName("en_uomgrp_key");
            this.Property(t => t.en_item_ffltm).HasColumnName("en_item_ffltm");
            this.Property(t => t.en_item_piktm).HasColumnName("en_item_piktm");
            this.Property(t => t.en_item_rsrvtm).HasColumnName("en_item_rsrvtm");
            this.Property(t => t.en_item_pltqt).HasColumnName("en_item_pltqt");
            this.Property(t => t.en_item_vol).HasColumnName("en_item_vol");
            this.Property(t => t.en_item_vuom).HasColumnName("en_item_vuom");
            this.Property(t => t.en_item_actconf).HasColumnName("en_item_actconf");
            this.Property(t => t.en_item_drctf).HasColumnName("en_item_drctf");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.en_item_taxf).HasColumnName("en_item_taxf");
            this.Property(t => t.en_resn_key).HasColumnName("en_resn_key");
            this.Property(t => t.en_item_fillattr).HasColumnName("en_item_fillattr");
            this.Property(t => t.en_item_upcean).HasColumnName("en_item_upcean");
            this.Property(t => t.en_item_scccode).HasColumnName("en_item_scccode");
            this.Property(t => t.en_item_sccdesc).HasColumnName("en_item_sccdesc");
            this.Property(t => t.en_item_mfridlen).HasColumnName("en_item_mfridlen");
            this.Property(t => t.en_item_actfillf).HasColumnName("en_item_actfillf");
            this.Property(t => t.en_item_sublotf).HasColumnName("en_item_sublotf");
            this.Property(t => t.en_item_qcsublotf).HasColumnName("en_item_qcsublotf");
            this.Property(t => t.en_item_hazf).HasColumnName("en_item_hazf");
            this.Property(t => t.en_item_bkflinf).HasColumnName("en_item_bkflinf");
            this.Property(t => t.en_item_bkflopf).HasColumnName("en_item_bkflopf");
            this.Property(t => t.en_item_lotfrmt).HasColumnName("en_item_lotfrmt");
            this.Property(t => t.en_item_ovtfct).HasColumnName("en_item_ovtfct");
            this.Property(t => t.en_item_cstpltp).HasColumnName("en_item_cstpltp");
            this.Property(t => t.en_item_procname).HasColumnName("en_item_procname");
            this.Property(t => t.en_item_qcspecf).HasColumnName("en_item_qcspecf");
            this.Property(t => t.en_gtin_key).HasColumnName("en_gtin_key");
            this.Property(t => t.en_item_cntrl).HasColumnName("en_item_cntrl");
            this.Property(t => t.en_item_upcnt).HasColumnName("en_item_upcnt");
            this.Property(t => t.en_uom_alternate).HasColumnName("en_uom_alternate");
            this.Property(t => t.en_item_plmf).HasColumnName("en_item_plmf");
            this.Property(t => t.en_invacctgrp_key).HasColumnName("en_invacctgrp_key");
            this.Property(t => t.en_item_invcntrlf).HasColumnName("en_item_invcntrlf");
            this.Property(t => t.en_item_hazmgr).HasColumnName("en_item_hazmgr");
            this.Property(t => t.en_item_plotfrmt).HasColumnName("en_item_plotfrmt");
            this.Property(t => t.en_item_mlotfrmt).HasColumnName("en_item_mlotfrmt");
        }
    }
}
