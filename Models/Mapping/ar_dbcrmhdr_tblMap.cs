using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_dbcrmhdr_tblMap : EntityTypeConfiguration<ar_dbcrmhdr_tbl>
    {
        public ar_dbcrmhdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_brnch_key, t.ar_dbcrm_type, t.ar_dbcrm_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_dbcrm_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_dbcrm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_dbcrm_stats)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sa_uid_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ar_dbcrm_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ar_dbcrm_ptrmk)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_doccd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_dbcrmhdr_refdoc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_dbcrmhdr_auth)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_dbcrm_distype)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_eslcatgry_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_exsus)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ar_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_ship_key)
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_cpono)
                .HasMaxLength(25);

            this.Property(t => t.ar_dbcrmhdr_replacepo)
                .HasMaxLength(25);

            this.Property(t => t.ar_sat_key)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ar_dbcrmhdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_brnch_key).HasColumnName("in_brnch_key");
            this.Property(t => t.ar_dbcrm_type).HasColumnName("ar_dbcrm_type");
            this.Property(t => t.ar_dbcrm_key).HasColumnName("ar_dbcrm_key");
            this.Property(t => t.tran_date_key).HasColumnName("tran_date_key");
            this.Property(t => t.ar_dbcrm_prtdt).HasColumnName("ar_dbcrm_prtdt");
            this.Property(t => t.comp_date_key).HasColumnName("comp_date_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_dbcrm_stats).HasColumnName("ar_dbcrm_stats");
            this.Property(t => t.sa_uid_key).HasColumnName("sa_uid_key");
            this.Property(t => t.ar_dbcrm_amt).HasColumnName("ar_dbcrm_amt");
            this.Property(t => t.ar_dbcrm_cramt).HasColumnName("ar_dbcrm_cramt");
            this.Property(t => t.ar_dbcrm_remk).HasColumnName("ar_dbcrm_remk");
            this.Property(t => t.ar_dbcrm_ptrmk).HasColumnName("ar_dbcrm_ptrmk");
            this.Property(t => t.ar_dbcrm_rchgc).HasColumnName("ar_dbcrm_rchgc");
            this.Property(t => t.ar_dbcrm_amtf).HasColumnName("ar_dbcrm_amtf");
            this.Property(t => t.ar_dbcrm_cramtf).HasColumnName("ar_dbcrm_cramtf");
            this.Property(t => t.ar_dbcrm_rchgcf).HasColumnName("ar_dbcrm_rchgcf");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.ar_dbcrmhdr_rate).HasColumnName("ar_dbcrmhdr_rate");
            this.Property(t => t.ar_dbcrmhdr_upcnt).HasColumnName("ar_dbcrmhdr_upcnt");
            this.Property(t => t.ar_dbcrm_wroffc).HasColumnName("ar_dbcrm_wroffc");
            this.Property(t => t.ar_dbcrm_wroffcf).HasColumnName("ar_dbcrm_wroffcf");
            this.Property(t => t.ar_dbcrmhdr_stdte).HasColumnName("ar_dbcrmhdr_stdte");
            this.Property(t => t.ar_dbcrmhdr_dundt).HasColumnName("ar_dbcrmhdr_dundt");
            this.Property(t => t.ar_dbcrmhdr_dunflg).HasColumnName("ar_dbcrmhdr_dunflg");
            this.Property(t => t.ar_dunlev_key).HasColumnName("ar_dunlev_key");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.gl_doccd_key).HasColumnName("gl_doccd_key");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.en_vatmthd_key).HasColumnName("en_vatmthd_key");
            this.Property(t => t.ar_dbcrm_origto3).HasColumnName("ar_dbcrm_origto3");
            this.Property(t => t.ar_dbcrm_tobase).HasColumnName("ar_dbcrm_tobase");
            this.Property(t => t.ar_dbcrm_asofdt).HasColumnName("ar_dbcrm_asofdt");
            this.Property(t => t.ar_dbcrmhdr_applcf).HasColumnName("ar_dbcrmhdr_applcf");
            this.Property(t => t.ar_dbcrmhdr_applc).HasColumnName("ar_dbcrmhdr_applc");
            this.Property(t => t.ar_dbcrmhdr_crttyp).HasColumnName("ar_dbcrmhdr_crttyp");
            this.Property(t => t.ar_dbcrmhdr_reftyp).HasColumnName("ar_dbcrmhdr_reftyp");
            this.Property(t => t.ar_dbcrmhdr_refdoc).HasColumnName("ar_dbcrmhdr_refdoc");
            this.Property(t => t.ar_dbcrmhdr_auth).HasColumnName("ar_dbcrmhdr_auth");
            this.Property(t => t.so_hdr_crtdt).HasColumnName("so_hdr_crtdt");
            this.Property(t => t.ar_dbcrm_distype).HasColumnName("ar_dbcrm_distype");
            this.Property(t => t.ar_dbcrm_eslf).HasColumnName("ar_dbcrm_eslf");
            this.Property(t => t.ar_dbcrm_esldt).HasColumnName("ar_dbcrm_esldt");
            this.Property(t => t.en_eslcatgry_key).HasColumnName("en_eslcatgry_key");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.ar_bill_type).HasColumnName("ar_bill_type");
            this.Property(t => t.ar_bill_exsus).HasColumnName("ar_bill_exsus");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
            this.Property(t => t.ar_dbcrmhdr_duedt).HasColumnName("ar_dbcrmhdr_duedt");
            this.Property(t => t.ar_dbcrm_cdiscf).HasColumnName("ar_dbcrm_cdiscf");
            this.Property(t => t.ar_dbcrm_dsalcf).HasColumnName("ar_dbcrm_dsalcf");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.ar_dbcrm_dsalcrcf).HasColumnName("ar_dbcrm_dsalcrcf");
            this.Property(t => t.ar_dbcrmhdr_mcpof).HasColumnName("ar_dbcrmhdr_mcpof");
            this.Property(t => t.ar_dbcrmhdr_basis).HasColumnName("ar_dbcrmhdr_basis");
            this.Property(t => t.ar_dbcrm_deductcf).HasColumnName("ar_dbcrm_deductcf");
            this.Property(t => t.so_hdr_cpono).HasColumnName("so_hdr_cpono");
            this.Property(t => t.ar_dbcrmhdr_replacepo).HasColumnName("ar_dbcrmhdr_replacepo");
            this.Property(t => t.ar_sat_key).HasColumnName("ar_sat_key");
        }
    }
}
