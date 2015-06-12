using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_vchr_tblMap : EntityTypeConfiguration<ap_vchr_tbl>
    {
        public ap_vchr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ap_vchr_type, t.ap_vchr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ap_vchr_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ap_vchr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_hdr_key)
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

            this.Property(t => t.pa_proj_key)
                .IsRequired()
                .HasMaxLength(10);

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

            this.Property(t => t.prog_nam)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_uid_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_1099_key)
                .HasMaxLength(10);

            this.Property(t => t.ap_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_doccd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_remt_exsus)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_trnsport_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_pofob_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_sales)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_sales)
                .HasMaxLength(4);

            this.Property(t => t.ap_vchr_typesales)
                .HasMaxLength(1);

            this.Property(t => t.ap_vchr_keysales)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_ship)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_ship)
                .HasMaxLength(4);

            this.Property(t => t.ap_vchr_typeship)
                .HasMaxLength(1);

            this.Property(t => t.ap_vchr_keyship)
                .HasMaxLength(10);

            this.Property(t => t.ap_vchr_batchno)
                .HasMaxLength(10);

            this.Property(t => t.ap_vtmplt_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ap_vchr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ap_vchr_type).HasColumnName("ap_vchr_type");
            this.Property(t => t.ap_vchr_key).HasColumnName("ap_vchr_key");
            this.Property(t => t.ap_vchr_icmemof).HasColumnName("ap_vchr_icmemof");
            this.Property(t => t.ap_vchr_upcnt).HasColumnName("ap_vchr_upcnt");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.ap_chek_key).HasColumnName("ap_chek_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.ap_btch_key).HasColumnName("ap_btch_key");
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
            this.Property(t => t.ap_vchr_pysldt).HasColumnName("ap_vchr_pysldt");
            this.Property(t => t.ap_vchr_pyamt).HasColumnName("ap_vchr_pyamt");
            this.Property(t => t.ap_vchr_pyamtf).HasColumnName("ap_vchr_pyamtf");
            this.Property(t => t.ap_vchr_duedt).HasColumnName("ap_vchr_duedt");
            this.Property(t => t.ap_vchr_ldsdt).HasColumnName("ap_vchr_ldsdt");
            this.Property(t => t.ap_vchr_dscpc).HasColumnName("ap_vchr_dscpc");
            this.Property(t => t.ap_vchr_dydsa).HasColumnName("ap_vchr_dydsa");
            this.Property(t => t.ap_vchr_ntdue).HasColumnName("ap_vchr_ntdue");
            this.Property(t => t.pa_proj_key).HasColumnName("pa_proj_key");
            this.Property(t => t.ap_vchr_remk).HasColumnName("ap_vchr_remk");
            this.Property(t => t.ap_vchr_ref).HasColumnName("ap_vchr_ref");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.prog_nam).HasColumnName("prog_nam");
            this.Property(t => t.sa_uid_key).HasColumnName("sa_uid_key");
            this.Property(t => t.tty_num).HasColumnName("tty_num");
            this.Property(t => t.ap_remt_adres).HasColumnName("ap_remt_adres");
            this.Property(t => t.en_whs_key).HasColumnName("en_whs_key");
            this.Property(t => t.en_vend_1099f).HasColumnName("en_vend_1099f");
            this.Property(t => t.en_1099_key).HasColumnName("en_1099_key");
            this.Property(t => t.ap_vchr_dtltot).HasColumnName("ap_vchr_dtltot");
            this.Property(t => t.ap_vchr_dtltotf).HasColumnName("ap_vchr_dtltotf");
            this.Property(t => t.ap_vchr_slstxamt).HasColumnName("ap_vchr_slstxamt");
            this.Property(t => t.ap_vchr_slstxamtf).HasColumnName("ap_vchr_slstxamtf");
            this.Property(t => t.ap_vchr_usetxamt).HasColumnName("ap_vchr_usetxamt");
            this.Property(t => t.ap_vchr_usetxamtf).HasColumnName("ap_vchr_usetxamtf");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.ap_vchr_declp).HasColumnName("ap_vchr_declp");
            this.Property(t => t.ap_vchr_recalc).HasColumnName("ap_vchr_recalc");
            this.Property(t => t.ap_vchr_origto3).HasColumnName("ap_vchr_origto3");
            this.Property(t => t.ap_vchr_tobase).HasColumnName("ap_vchr_tobase");
            this.Property(t => t.ap_vchr_asofdt).HasColumnName("ap_vchr_asofdt");
            this.Property(t => t.ap_vchr_nondcf).HasColumnName("ap_vchr_nondcf");
            this.Property(t => t.ap_vchr_adsccf).HasColumnName("ap_vchr_adsccf");
            this.Property(t => t.ap_vchr_tdsccf).HasColumnName("ap_vchr_tdsccf");
            this.Property(t => t.ap_vchr_amtc).HasColumnName("ap_vchr_amtc");
            this.Property(t => t.ap_vchr_amtcf).HasColumnName("ap_vchr_amtcf");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.gl_doccd_key).HasColumnName("gl_doccd_key");
            this.Property(t => t.ap_vchr_payopt).HasColumnName("ap_vchr_payopt");
            this.Property(t => t.ap_vchr_dueday).HasColumnName("ap_vchr_dueday");
            this.Property(t => t.ap_vchr_eomopt).HasColumnName("ap_vchr_eomopt");
            this.Property(t => t.ap_vchr_limday).HasColumnName("ap_vchr_limday");
            this.Property(t => t.ap_vchr_ivdtf).HasColumnName("ap_vchr_ivdtf");
            this.Property(t => t.ap_vchr_slsovrflg).HasColumnName("ap_vchr_slsovrflg");
            this.Property(t => t.ap_vchr_slsovramtf).HasColumnName("ap_vchr_slsovramtf");
            this.Property(t => t.ap_vchr_slsovramt).HasColumnName("ap_vchr_slsovramt");
            this.Property(t => t.ap_vchr_appamtcf).HasColumnName("ap_vchr_appamtcf");
            this.Property(t => t.ap_vchr_appamtc).HasColumnName("ap_vchr_appamtc");
            this.Property(t => t.ap_remt_exsus).HasColumnName("ap_remt_exsus");
            this.Property(t => t.ap_remt_type).HasColumnName("ap_remt_type");
            this.Property(t => t.ap_vchr_amtonhold).HasColumnName("ap_vchr_amtonhold");
            this.Property(t => t.ap_vchr_amtonholdf).HasColumnName("ap_vchr_amtonholdf");
            this.Property(t => t.en_trnsport_key).HasColumnName("en_trnsport_key");
            this.Property(t => t.en_pofob_key).HasColumnName("en_pofob_key");
            this.Property(t => t.ap_vchr_eustatdt).HasColumnName("ap_vchr_eustatdt");
            this.Property(t => t.ap_vchr_eustatf).HasColumnName("ap_vchr_eustatf");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.ap_vchr_autovchf).HasColumnName("ap_vchr_autovchf");
            this.Property(t => t.ap_vchr_substats).HasColumnName("ap_vchr_substats");
            this.Property(t => t.ap_vchr_subtype).HasColumnName("ap_vchr_subtype");
            this.Property(t => t.ap_vchr_alloctype).HasColumnName("ap_vchr_alloctype");
            this.Property(t => t.ap_vchr_allocappf).HasColumnName("ap_vchr_allocappf");
            this.Property(t => t.ap_vchr_rollovrdt).HasColumnName("ap_vchr_rollovrdt");
            this.Property(t => t.ap_vchr_allocappdt).HasColumnName("ap_vchr_allocappdt");
            this.Property(t => t.ap_vchr_clsdt).HasColumnName("ap_vchr_clsdt");
            this.Property(t => t.ap_vchr_crtdt).HasColumnName("ap_vchr_crtdt");
            this.Property(t => t.ap_vchr_chgdt).HasColumnName("ap_vchr_chgdt");
            this.Property(t => t.gl_cmp_sales).HasColumnName("gl_cmp_sales");
            this.Property(t => t.so_brnch_sales).HasColumnName("so_brnch_sales");
            this.Property(t => t.ap_vchr_typesales).HasColumnName("ap_vchr_typesales");
            this.Property(t => t.ap_vchr_keysales).HasColumnName("ap_vchr_keysales");
            this.Property(t => t.gl_cmp_ship).HasColumnName("gl_cmp_ship");
            this.Property(t => t.so_brnch_ship).HasColumnName("so_brnch_ship");
            this.Property(t => t.ap_vchr_typeship).HasColumnName("ap_vchr_typeship");
            this.Property(t => t.ap_vchr_keyship).HasColumnName("ap_vchr_keyship");
            this.Property(t => t.ap_vchr_whldtxamtf).HasColumnName("ap_vchr_whldtxamtf");
            this.Property(t => t.ap_vchr_whldtxamt).HasColumnName("ap_vchr_whldtxamt");
            this.Property(t => t.ap_vchr_batchno).HasColumnName("ap_vchr_batchno");
            this.Property(t => t.ap_vtmplt_key).HasColumnName("ap_vtmplt_key");
            this.Property(t => t.ap_vchr_wthldamtf).HasColumnName("ap_vchr_wthldamtf");
        }
    }
}
