using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_reqdt_tblMap : EntityTypeConfiguration<po_reqdt_tbl>
    {
        public po_reqdt_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_reqhd_key, t.po_reqdt_key, t.im_pack_key, t.ar_tax_key, t.in_item_key, t.in_item_desc, t.po_reqdt_qty, t.en_vend_key, t.po_reqdt_reqdt, t.sf_work_key, t.po_reqdt_issqt, t.po_hdr_key, t.po_dtl_key, t.pa_atvty_key, t.gl_acct_key, t.uom_key, t.so_hdr_key, t.so_dtl_key, t.in_buyc_key, t.ap_remt_key, t.ap_delfm_key, t.in_whs_key, t.po_reqdt_nonstk, t.po_nstk_key, t.po_reqdt_specf, t.po_reqdt_tgtpr, t.po_reqdt_crncy, t.po_reqdt_tgtuom, t.po_reqdt_taxf, t.po_reqdt_upcnt, t.po_reqdt_crtdt, t.po_reqdt_apprstatus, t.po_reqdt_chgdt, t.sa_user_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_reqhd_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_reqdt_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.ar_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pa_proj_key)
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_item_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_work_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pa_atvty_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_buyc_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_reqdt_nonstk)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_nstk_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_reqdt_specf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_reqdt_crncy)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.po_reqdt_tgtuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.po_reqdt_taxf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_reqdt_upcnt)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_reqdt_apprstatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_reqdt_externalref)
                .HasMaxLength(30);

            this.Property(t => t.po_reqdt_errorlog)
                .HasMaxLength(2000);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_cstcnt_key)
                .HasMaxLength(10);

            this.Property(t => t.en_frgt_key)
                .HasMaxLength(10);

            this.Property(t => t.en_fob_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("po_reqdt_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_reqhd_key).HasColumnName("po_reqhd_key");
            this.Property(t => t.po_reqdt_key).HasColumnName("po_reqdt_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.pa_proj_effdt).HasColumnName("pa_proj_effdt");
            this.Property(t => t.pa_proj_key).HasColumnName("pa_proj_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_item_desc).HasColumnName("in_item_desc");
            this.Property(t => t.po_reqdt_qty).HasColumnName("po_reqdt_qty");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.po_reqdt_reqdt).HasColumnName("po_reqdt_reqdt");
            this.Property(t => t.sf_work_key).HasColumnName("sf_work_key");
            this.Property(t => t.po_reqdt_issqt).HasColumnName("po_reqdt_issqt");
            this.Property(t => t.po_reqdt_issdt).HasColumnName("po_reqdt_issdt");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.pa_atvty_key).HasColumnName("pa_atvty_key");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.in_buyc_key).HasColumnName("in_buyc_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.po_reqdt_nonstk).HasColumnName("po_reqdt_nonstk");
            this.Property(t => t.po_nstk_key).HasColumnName("po_nstk_key");
            this.Property(t => t.po_reqdt_specf).HasColumnName("po_reqdt_specf");
            this.Property(t => t.po_reqdt_reldt).HasColumnName("po_reqdt_reldt");
            this.Property(t => t.po_reqdt_tgtpr).HasColumnName("po_reqdt_tgtpr");
            this.Property(t => t.po_reqdt_crncy).HasColumnName("po_reqdt_crncy");
            this.Property(t => t.po_reqdt_tgtuom).HasColumnName("po_reqdt_tgtuom");
            this.Property(t => t.po_reqdt_taxf).HasColumnName("po_reqdt_taxf");
            this.Property(t => t.po_reqdt_upcnt).HasColumnName("po_reqdt_upcnt");
            this.Property(t => t.po_reqdt_crtdt).HasColumnName("po_reqdt_crtdt");
            this.Property(t => t.po_reqdt_stat).HasColumnName("po_reqdt_stat");
            this.Property(t => t.po_reqdt_apprstatus).HasColumnName("po_reqdt_apprstatus");
            this.Property(t => t.po_reqdt_chgdt).HasColumnName("po_reqdt_chgdt");
            this.Property(t => t.po_reqdt_externalref).HasColumnName("po_reqdt_externalref");
            this.Property(t => t.po_reqdt_clsdt).HasColumnName("po_reqdt_clsdt");
            this.Property(t => t.po_reqdt_errorlog).HasColumnName("po_reqdt_errorlog");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_cstcnt_key).HasColumnName("en_cstcnt_key");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
        }
    }
}
