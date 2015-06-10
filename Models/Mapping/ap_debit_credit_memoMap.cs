using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_debit_credit_memoMap : EntityTypeConfiguration<ap_debit_credit_memo>
    {
        public ap_debit_credit_memoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ap_vchr_type, t.ap_vchr_key, t.ap_vchr_invno, t.ap_vchr_invdt, t.ap_vchr_stats, t.gl_crncy_key, t.ap_vchr_rate, t.ap_vchr_chkc, t.ap_vchr_chkf, t.ap_vchr_adscc, t.ap_vchr_nondc, t.ap_vchr_tdscc, t.ap_vchr_date, t.ap_vchr_pyamt, t.ap_vchr_pyamtf, t.ap_vchr_duedt, t.ap_vchr_ldsdt, t.ap_vchr_dscpc, t.ap_vchr_dydsa, t.ap_vchr_ntdue, t.ap_vchr_remk, t.ap_vchr_ref, t.ap_resn_key, t.ap_remt_key, t.sa_uid_key, t.ap_vchr_dtltot, t.ap_vchr_dtltotf, t.ap_vchr_slstxamt, t.ap_vchr_slstxamtf, t.ap_vchr_usetxamt, t.ap_vchr_usetxamtf, t.ap_delfm_key, t.ap_vchr_amtc, t.ap_vchr_amtcf, t.gl_paycd_key, t.ap_vchr_appamtcf, t.ap_vchr_appamtc, t.ap_remt_name, t.im_adres_name, t.im_adres_line1, t.im_adres_line2, t.im_adres_line3, t.im_adres_city, t.im_adres_state, t.im_adres_cntry, t.im_adres_pczip, t.im_adres_tel, t.im_adres_fax, t.im_adres_telex, t.ar_terms_desc });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_vchr_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ap_vchr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_vchr_invno)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ap_vchr_stats)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ap_vchr_dydsa)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ap_vchr_ntdue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ap_vchr_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ap_vchr_ref)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ap_resn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_uid_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ap_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.po_recpt_key)
                .HasMaxLength(10);

            this.Property(t => t.ap_vcdtl_ref)
                .HasMaxLength(20);

            this.Property(t => t.ap_vcdtl_remk)
                .HasMaxLength(30);

            this.Property(t => t.ap_remt_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_line1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_line2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_line3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_adres_cntry)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_pczip)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_adres_tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_fax)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_telex)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ar_terms_desc)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ap_debit_credit_memo");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ap_vchr_type).HasColumnName("ap_vchr_type");
            this.Property(t => t.ap_vchr_key).HasColumnName("ap_vchr_key");
            this.Property(t => t.ap_vchr_invno).HasColumnName("ap_vchr_invno");
            this.Property(t => t.ap_vchr_invdt).HasColumnName("ap_vchr_invdt");
            this.Property(t => t.ap_vchr_stats).HasColumnName("ap_vchr_stats");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.ap_vchr_rate).HasColumnName("ap_vchr_rate");
            this.Property(t => t.ap_vchr_chkc).HasColumnName("ap_vchr_chkc");
            this.Property(t => t.ap_vchr_chkf).HasColumnName("ap_vchr_chkf");
            this.Property(t => t.ap_vchr_adscc).HasColumnName("ap_vchr_adscc");
            this.Property(t => t.ap_vchr_nondc).HasColumnName("ap_vchr_nondc");
            this.Property(t => t.ap_vchr_tdscc).HasColumnName("ap_vchr_tdscc");
            this.Property(t => t.ap_vchr_date).HasColumnName("ap_vchr_date");
            this.Property(t => t.ap_vchr_pyamt).HasColumnName("ap_vchr_pyamt");
            this.Property(t => t.ap_vchr_pyamtf).HasColumnName("ap_vchr_pyamtf");
            this.Property(t => t.ap_vchr_duedt).HasColumnName("ap_vchr_duedt");
            this.Property(t => t.ap_vchr_ldsdt).HasColumnName("ap_vchr_ldsdt");
            this.Property(t => t.ap_vchr_dscpc).HasColumnName("ap_vchr_dscpc");
            this.Property(t => t.ap_vchr_dydsa).HasColumnName("ap_vchr_dydsa");
            this.Property(t => t.ap_vchr_ntdue).HasColumnName("ap_vchr_ntdue");
            this.Property(t => t.ap_vchr_remk).HasColumnName("ap_vchr_remk");
            this.Property(t => t.ap_vchr_ref).HasColumnName("ap_vchr_ref");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.sa_uid_key).HasColumnName("sa_uid_key");
            this.Property(t => t.ap_vchr_dtltot).HasColumnName("ap_vchr_dtltot");
            this.Property(t => t.ap_vchr_dtltotf).HasColumnName("ap_vchr_dtltotf");
            this.Property(t => t.ap_vchr_slstxamt).HasColumnName("ap_vchr_slstxamt");
            this.Property(t => t.ap_vchr_slstxamtf).HasColumnName("ap_vchr_slstxamtf");
            this.Property(t => t.ap_vchr_usetxamt).HasColumnName("ap_vchr_usetxamt");
            this.Property(t => t.ap_vchr_usetxamtf).HasColumnName("ap_vchr_usetxamtf");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.ap_vchr_amtc).HasColumnName("ap_vchr_amtc");
            this.Property(t => t.ap_vchr_amtcf).HasColumnName("ap_vchr_amtcf");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.ap_vchr_appamtcf).HasColumnName("ap_vchr_appamtcf");
            this.Property(t => t.ap_vchr_appamtc).HasColumnName("ap_vchr_appamtc");
            this.Property(t => t.ap_vcdtl_line).HasColumnName("ap_vcdtl_line");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.po_recpt_key).HasColumnName("po_recpt_key");
            this.Property(t => t.ap_vcdtl_iunitc).HasColumnName("ap_vcdtl_iunitc");
            this.Property(t => t.ap_vcdtl_ref).HasColumnName("ap_vcdtl_ref");
            this.Property(t => t.ap_vcdtl_iunitcf).HasColumnName("ap_vcdtl_iunitcf");
            this.Property(t => t.ap_vcdtl_remk).HasColumnName("ap_vcdtl_remk");
            this.Property(t => t.ap_remt_name).HasColumnName("ap_remt_name");
            this.Property(t => t.im_adres_name).HasColumnName("im_adres_name");
            this.Property(t => t.im_adres_line1).HasColumnName("im_adres_line1");
            this.Property(t => t.im_adres_line2).HasColumnName("im_adres_line2");
            this.Property(t => t.im_adres_line3).HasColumnName("im_adres_line3");
            this.Property(t => t.im_adres_city).HasColumnName("im_adres_city");
            this.Property(t => t.im_adres_state).HasColumnName("im_adres_state");
            this.Property(t => t.im_adres_cntry).HasColumnName("im_adres_cntry");
            this.Property(t => t.im_adres_pczip).HasColumnName("im_adres_pczip");
            this.Property(t => t.im_adres_tel).HasColumnName("im_adres_tel");
            this.Property(t => t.im_adres_fax).HasColumnName("im_adres_fax");
            this.Property(t => t.im_adres_telex).HasColumnName("im_adres_telex");
            this.Property(t => t.ar_terms_desc).HasColumnName("ar_terms_desc");
        }
    }
}
