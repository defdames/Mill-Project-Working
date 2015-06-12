using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_brnch_tblMap : EntityTypeConfiguration<so_brnch_tbl>
    {
        public so_brnch_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_brnch_apmisc)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_unvch)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_prcvr)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_vchvr)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_arfvr)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_mtloh)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_otpoh)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_inspa)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_fincg)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_woffa)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_uivsp)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_rstka)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_cmexp)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.so_brnch_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_brnch_cont)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_brnch_regn)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_brnch_defwh)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_brnch_fregt)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_misc)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_apfrgt)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_glid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_brnch_apfvr)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ap_resn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_brnch_estap)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_poret)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_clear)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_expense)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_slstaxvr)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_contrapo)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_promexp)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brnch_dedacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_bunit_key)
                .HasMaxLength(38);

            this.Property(t => t.so_brnch_intmacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_misc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("so_brnch_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.so_brnch_apmisc).HasColumnName("so_brnch_apmisc");
            this.Property(t => t.so_brnch_unvch).HasColumnName("so_brnch_unvch");
            this.Property(t => t.so_brnch_prcvr).HasColumnName("so_brnch_prcvr");
            this.Property(t => t.so_brnch_vchvr).HasColumnName("so_brnch_vchvr");
            this.Property(t => t.so_brnch_arfvr).HasColumnName("so_brnch_arfvr");
            this.Property(t => t.so_brnch_mtloh).HasColumnName("so_brnch_mtloh");
            this.Property(t => t.so_brnch_otpoh).HasColumnName("so_brnch_otpoh");
            this.Property(t => t.so_brnch_inspa).HasColumnName("so_brnch_inspa");
            this.Property(t => t.so_brnch_fincg).HasColumnName("so_brnch_fincg");
            this.Property(t => t.so_brnch_woffa).HasColumnName("so_brnch_woffa");
            this.Property(t => t.so_brnch_uivsp).HasColumnName("so_brnch_uivsp");
            this.Property(t => t.so_brnch_rstka).HasColumnName("so_brnch_rstka");
            this.Property(t => t.so_brnch_cmexp).HasColumnName("so_brnch_cmexp");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.so_brnch_crtdt).HasColumnName("so_brnch_crtdt");
            this.Property(t => t.so_brnch_chgdt).HasColumnName("so_brnch_chgdt");
            this.Property(t => t.so_brnch_name).HasColumnName("so_brnch_name");
            this.Property(t => t.so_brnch_cont).HasColumnName("so_brnch_cont");
            this.Property(t => t.so_brnch_regn).HasColumnName("so_brnch_regn");
            this.Property(t => t.so_brnch_defwh).HasColumnName("so_brnch_defwh");
            this.Property(t => t.so_brnch_fregt).HasColumnName("so_brnch_fregt");
            this.Property(t => t.so_brnch_misc).HasColumnName("so_brnch_misc");
            this.Property(t => t.so_brnch_apfrgt).HasColumnName("so_brnch_apfrgt");
            this.Property(t => t.so_brnch_glbrk).HasColumnName("so_brnch_glbrk");
            this.Property(t => t.so_brnch_glid).HasColumnName("so_brnch_glid");
            this.Property(t => t.so_brnch_autoinv).HasColumnName("so_brnch_autoinv");
            this.Property(t => t.so_brnch_apfvr).HasColumnName("so_brnch_apfvr");
            this.Property(t => t.so_brnch_athlmtc).HasColumnName("so_brnch_athlmtc");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.so_brnch_estap).HasColumnName("so_brnch_estap");
            this.Property(t => t.so_brnch_poret).HasColumnName("so_brnch_poret");
            this.Property(t => t.so_brnch_clear).HasColumnName("so_brnch_clear");
            this.Property(t => t.so_brnch_expense).HasColumnName("so_brnch_expense");
            this.Property(t => t.so_brnch_upcnt).HasColumnName("so_brnch_upcnt");
            this.Property(t => t.so_brnch_slstaxvr).HasColumnName("so_brnch_slstaxvr");
            this.Property(t => t.so_brnch_slstaxpct).HasColumnName("so_brnch_slstaxpct");
            this.Property(t => t.so_brnch_slstaxamt).HasColumnName("so_brnch_slstaxamt");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.so_brnch_contrapo).HasColumnName("so_brnch_contrapo");
            this.Property(t => t.so_brnch_promexp).HasColumnName("so_brnch_promexp");
            this.Property(t => t.so_brnch_mngpayf).HasColumnName("so_brnch_mngpayf");
            this.Property(t => t.so_brnch_mngrecf).HasColumnName("so_brnch_mngrecf");
            this.Property(t => t.so_brnch_dedacct).HasColumnName("so_brnch_dedacct");
            this.Property(t => t.gl_bunit_key).HasColumnName("gl_bunit_key");
            this.Property(t => t.so_brnch_autprdtnf).HasColumnName("so_brnch_autprdtnf");
            this.Property(t => t.so_brnch_intmacct).HasColumnName("so_brnch_intmacct");
            this.Property(t => t.so_brnch_ignwhinvf).HasColumnName("so_brnch_ignwhinvf");
            this.Property(t => t.so_brnch_nstkamt).HasColumnName("so_brnch_nstkamt");
            this.Property(t => t.gl_misc_key).HasColumnName("gl_misc_key");
            this.Property(t => t.so_brnch_bbtermsf).HasColumnName("so_brnch_bbtermsf");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
        }
    }
}
