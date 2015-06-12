using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_chdtl_tblMap : EntityTypeConfiguration<ar_chdtl_tbl>
    {
        public ar_chdtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ar_chek_key, t.ar_chdtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_chek_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_chdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ar_chdtl_doccmp)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_chdtl_docbrnch)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_chdtl_doctype)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_chdtl_dockey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_chdtl_resn)
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("ar_chdtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ar_chek_key).HasColumnName("ar_chek_key");
            this.Property(t => t.ar_chdtl_key).HasColumnName("ar_chdtl_key");
            this.Property(t => t.ar_chdtl_doccmp).HasColumnName("ar_chdtl_doccmp");
            this.Property(t => t.ar_chdtl_docbrnch).HasColumnName("ar_chdtl_docbrnch");
            this.Property(t => t.ar_chdtl_doctype).HasColumnName("ar_chdtl_doctype");
            this.Property(t => t.ar_chdtl_dockey).HasColumnName("ar_chdtl_dockey");
            this.Property(t => t.ar_chdtl_trandt).HasColumnName("ar_chdtl_trandt");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_chdtl_resn).HasColumnName("ar_chdtl_resn");
            this.Property(t => t.ar_chdtl_appamt).HasColumnName("ar_chdtl_appamt");
            this.Property(t => t.ar_chdtl_appamtf).HasColumnName("ar_chdtl_appamtf");
            this.Property(t => t.ar_chdtl_docamtf).HasColumnName("ar_chdtl_docamtf");
            this.Property(t => t.ar_chdtl_disamt).HasColumnName("ar_chdtl_disamt");
            this.Property(t => t.ar_chdtl_disamtf).HasColumnName("ar_chdtl_disamtf");
            this.Property(t => t.ar_chdtl_docdisf).HasColumnName("ar_chdtl_docdisf");
            this.Property(t => t.ar_chdtl_wroffc).HasColumnName("ar_chdtl_wroffc");
            this.Property(t => t.ar_chdtl_wroffcf).HasColumnName("ar_chdtl_wroffcf");
            this.Property(t => t.ar_chdtl_docwrofff).HasColumnName("ar_chdtl_docwrofff");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.ar_chdtl_crtdt).HasColumnName("ar_chdtl_crtdt");
            this.Property(t => t.ar_chdtl_chgdt).HasColumnName("ar_chdtl_chgdt");
            this.Property(t => t.ar_chdtl_upcnt).HasColumnName("ar_chdtl_upcnt");
        }
    }
}
