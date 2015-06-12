using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_crmapp_tblMap : EntityTypeConfiguration<ar_crmapp_tbl>
    {
        public ar_crmapp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ar_dbcrm_key, t.ar_crmapp_seq });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_dbcrm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_crmapp_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_crmapp_doccmp)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_crmapp_docbrnch)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_crmapp_doc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ar_crmapp_resn)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ar_crmapp_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ar_dbcrm_key).HasColumnName("ar_dbcrm_key");
            this.Property(t => t.ar_crmapp_seq).HasColumnName("ar_crmapp_seq");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_crmapp_doccmp).HasColumnName("ar_crmapp_doccmp");
            this.Property(t => t.ar_crmapp_docbrnch).HasColumnName("ar_crmapp_docbrnch");
            this.Property(t => t.ar_crmapp_doctyp).HasColumnName("ar_crmapp_doctyp");
            this.Property(t => t.ar_crmapp_doc).HasColumnName("ar_crmapp_doc");
            this.Property(t => t.ar_crmapp_amtcf).HasColumnName("ar_crmapp_amtcf");
            this.Property(t => t.ar_crmapp_amtc).HasColumnName("ar_crmapp_amtc");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.ar_crmapp_upcnt).HasColumnName("ar_crmapp_upcnt");
            this.Property(t => t.ar_crmapp_crtdt).HasColumnName("ar_crmapp_crtdt");
            this.Property(t => t.ar_crmapp_chgdt).HasColumnName("ar_crmapp_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.ar_crmapp_discamt).HasColumnName("ar_crmapp_discamt");
            this.Property(t => t.ar_crmapp_wroffc).HasColumnName("ar_crmapp_wroffc");
            this.Property(t => t.ar_crmapp_wroffcf).HasColumnName("ar_crmapp_wroffcf");
            this.Property(t => t.ar_crmapp_docwrofff).HasColumnName("ar_crmapp_docwrofff");
            this.Property(t => t.ar_crmapp_resn).HasColumnName("ar_crmapp_resn");
            this.Property(t => t.ar_crmapp_docdisc).HasColumnName("ar_crmapp_docdisc");
            this.Property(t => t.ar_crmapp_trandt).HasColumnName("ar_crmapp_trandt");
        }
    }
}
