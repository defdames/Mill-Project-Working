using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_dtlms_tblMap : EntityTypeConfiguration<po_dtlms_tbl>
    {
        public po_dtlms_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_hdr_key, t.po_dtl_key, t.en_misc_key });

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

            this.Property(t => t.po_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_misc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ar_tax_key)
                .HasMaxLength(10);

            this.Property(t => t.en_contr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("po_dtlms_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.en_misc_key).HasColumnName("en_misc_key");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.po_dtlms_cttyp).HasColumnName("po_dtlms_cttyp");
            this.Property(t => t.po_dtlms_ctuff).HasColumnName("po_dtlms_ctuff");
            this.Property(t => t.po_dtlms_ctval).HasColumnName("po_dtlms_ctval");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.po_dtlms_crtdt).HasColumnName("po_dtlms_crtdt");
            this.Property(t => t.po_dtlms_chgdt).HasColumnName("po_dtlms_chgdt");
            this.Property(t => t.po_dtlms_upcnt).HasColumnName("po_dtlms_upcnt");
            this.Property(t => t.po_dtlms_taxf).HasColumnName("po_dtlms_taxf");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.en_contr_key).HasColumnName("en_contr_key");
            this.Property(t => t.po_dtlms_extvalcf).HasColumnName("po_dtlms_extvalcf");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.po_dtlms_vatc).HasColumnName("po_dtlms_vatc");
            this.Property(t => t.po_dtlms_vatcf).HasColumnName("po_dtlms_vatcf");
            this.Property(t => t.po_dtlms_computef).HasColumnName("po_dtlms_computef");
            this.Property(t => t.po_dtlms_seqno).HasColumnName("po_dtlms_seqno");
            this.Property(t => t.po_dtlms_extvalc).HasColumnName("po_dtlms_extvalc");
        }
    }
}
