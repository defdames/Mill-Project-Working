using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_ivhdr_tblMap : EntityTypeConfiguration<ar_ivhdr_tbl>
    {
        public ar_ivhdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_brnch_key, t.ar_ivhdr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ivhdr_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_ivhdr_stats)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ar_note_notes)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_reas_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_doccd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_eslcatgry_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_exsus)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_cpono)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.so_hdr_porelease)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_agnt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frgt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_uid_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ar_ivdelcd_key)
                .HasMaxLength(10);

            this.Property(t => t.ar_ivhdr_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ar_sat_key)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ar_ivhdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_brnch_key).HasColumnName("in_brnch_key");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.ar_ivhdr_type).HasColumnName("ar_ivhdr_type");
            this.Property(t => t.ar_ivhdr_stats).HasColumnName("ar_ivhdr_stats");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.ar_ivhdr_ivblc).HasColumnName("ar_ivhdr_ivblc");
            this.Property(t => t.ar_ivhdr_ivblcf).HasColumnName("ar_ivhdr_ivblcf");
            this.Property(t => t.ar_ivhdr_cshc).HasColumnName("ar_ivhdr_cshc");
            this.Property(t => t.ar_ivhdr_cshcf).HasColumnName("ar_ivhdr_cshcf");
            this.Property(t => t.ar_ivhdr_cdisc).HasColumnName("ar_ivhdr_cdisc");
            this.Property(t => t.ar_ivhdr_cdiscf).HasColumnName("ar_ivhdr_cdiscf");
            this.Property(t => t.ar_ivhdr_dsalc).HasColumnName("ar_ivhdr_dsalc");
            this.Property(t => t.ar_ivhdr_dsalcf).HasColumnName("ar_ivhdr_dsalcf");
            this.Property(t => t.ar_ivhdr_dsalcrc).HasColumnName("ar_ivhdr_dsalcrc");
            this.Property(t => t.ar_ivhdr_dsalcrcf).HasColumnName("ar_ivhdr_dsalcrcf");
            this.Property(t => t.ar_ivhdr_wroffc).HasColumnName("ar_ivhdr_wroffc");
            this.Property(t => t.ar_ivhdr_wroffcf).HasColumnName("ar_ivhdr_wroffcf");
            this.Property(t => t.ar_ivhdr_dbmoc).HasColumnName("ar_ivhdr_dbmoc");
            this.Property(t => t.ar_ivhdr_dbmocf).HasColumnName("ar_ivhdr_dbmocf");
            this.Property(t => t.ar_ivhdr_crmoc).HasColumnName("ar_ivhdr_crmoc");
            this.Property(t => t.ar_ivhdr_crmocf).HasColumnName("ar_ivhdr_crmocf");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.ar_ivhdr_rate).HasColumnName("ar_ivhdr_rate");
            this.Property(t => t.ar_ivhdr_origto3).HasColumnName("ar_ivhdr_origto3");
            this.Property(t => t.ar_ivhdr_tobase).HasColumnName("ar_ivhdr_tobase");
            this.Property(t => t.ar_ivhdr_asofdt).HasColumnName("ar_ivhdr_asofdt");
            this.Property(t => t.tran_date_key).HasColumnName("tran_date_key");
            this.Property(t => t.ar_ivhdr_duedt).HasColumnName("ar_ivhdr_duedt");
            this.Property(t => t.ar_ivhdr_stdte).HasColumnName("ar_ivhdr_stdte");
            this.Property(t => t.ar_ivhdr_prtdt).HasColumnName("ar_ivhdr_prtdt");
            this.Property(t => t.ar_ivhdr_reprntdt).HasColumnName("ar_ivhdr_reprntdt");
            this.Property(t => t.ar_ivhdr_wofdt).HasColumnName("ar_ivhdr_wofdt");
            this.Property(t => t.ar_note_notes).HasColumnName("ar_note_notes");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
            this.Property(t => t.ar_reas_key).HasColumnName("ar_reas_key");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.gl_doccd_key).HasColumnName("gl_doccd_key");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.ar_ivhdr_declp).HasColumnName("ar_ivhdr_declp");
            this.Property(t => t.ar_ivhdr_dunflag).HasColumnName("ar_ivhdr_dunflag");
            this.Property(t => t.ar_ivhdr_lastdundt).HasColumnName("ar_ivhdr_lastdundt");
            this.Property(t => t.ar_dunlev_key).HasColumnName("ar_dunlev_key");
            this.Property(t => t.ar_ivhdr_eustatf).HasColumnName("ar_ivhdr_eustatf");
            this.Property(t => t.ar_ivhdr_eustdt).HasColumnName("ar_ivhdr_eustdt");
            this.Property(t => t.ar_ivhdr_eslf).HasColumnName("ar_ivhdr_eslf");
            this.Property(t => t.ar_ivhdr_esldt).HasColumnName("ar_ivhdr_esldt");
            this.Property(t => t.en_eslcatgry_key).HasColumnName("en_eslcatgry_key");
            this.Property(t => t.ar_bill_exsus).HasColumnName("ar_bill_exsus");
            this.Property(t => t.ar_bill_type).HasColumnName("ar_bill_type");
            this.Property(t => t.ar_ivhdr_mschtyp).HasColumnName("ar_ivhdr_mschtyp");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_hdr_cpono).HasColumnName("so_hdr_cpono");
            this.Property(t => t.so_hdr_porelease).HasColumnName("so_hdr_porelease");
            this.Property(t => t.so_hdr_crtdt).HasColumnName("so_hdr_crtdt");
            this.Property(t => t.so_agnt_key).HasColumnName("so_agnt_key");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.sa_uid_key).HasColumnName("sa_uid_key");
            this.Property(t => t.ar_ivhdr_crtdt).HasColumnName("ar_ivhdr_crtdt");
            this.Property(t => t.ar_ivhdr_chgdt).HasColumnName("ar_ivhdr_chgdt");
            this.Property(t => t.ar_ivhdr_upcnt).HasColumnName("ar_ivhdr_upcnt");
            this.Property(t => t.ar_ivdelcd_key).HasColumnName("ar_ivdelcd_key");
            this.Property(t => t.ar_ivhdr_vatmthd).HasColumnName("ar_ivhdr_vatmthd");
            this.Property(t => t.ar_ivhdr_deductcf).HasColumnName("ar_ivhdr_deductcf");
            this.Property(t => t.ar_bill_adkey).HasColumnName("ar_bill_adkey");
            this.Property(t => t.ar_ship_adkey).HasColumnName("ar_ship_adkey");
            this.Property(t => t.ar_ivhdr_remk).HasColumnName("ar_ivhdr_remk");
            this.Property(t => t.ar_sat_key).HasColumnName("ar_sat_key");
        }
    }
}
