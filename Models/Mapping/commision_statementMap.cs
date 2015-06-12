using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class commision_statementMap : EntityTypeConfiguration<commision_statement>
    {
        public commision_statementMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_salsm_key, t.gl_cmp_key, t.so_salsm_name, t.so_salsm_adr1, t.so_salsm_adr2, t.so_salsm_adr3, t.so_salsm_city, t.so_salsm_cntry, t.so_salsm_pczip, t.so_comtr_trndt, t.so_comtr_due, t.so_comtr_paid });

            // Properties
            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_salsm_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_adr1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_adr2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_adr3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_salsm_cntry)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_salsm_pczip)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.doc)
                .HasMaxLength(13);

            this.Property(t => t.en_ship_name)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("commision_statement");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_salsm_name).HasColumnName("so_salsm_name");
            this.Property(t => t.so_salsm_adr1).HasColumnName("so_salsm_adr1");
            this.Property(t => t.so_salsm_adr2).HasColumnName("so_salsm_adr2");
            this.Property(t => t.so_salsm_adr3).HasColumnName("so_salsm_adr3");
            this.Property(t => t.so_salsm_city).HasColumnName("so_salsm_city");
            this.Property(t => t.so_salsm_cntry).HasColumnName("so_salsm_cntry");
            this.Property(t => t.so_salsm_pczip).HasColumnName("so_salsm_pczip");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.so_comtr_trndt).HasColumnName("so_comtr_trndt");
            this.Property(t => t.so_comtr_due).HasColumnName("so_comtr_due");
            this.Property(t => t.so_comtr_paid).HasColumnName("so_comtr_paid");
            this.Property(t => t.en_ship_name).HasColumnName("en_ship_name");
            this.Property(t => t.ar_ivhdr_ivblc).HasColumnName("ar_ivhdr_ivblc");
            this.Property(t => t.ar_ivhdr_crmoc).HasColumnName("ar_ivhdr_crmoc");
            this.Property(t => t.ar_ivhdr_cdisc).HasColumnName("ar_ivhdr_cdisc");
            this.Property(t => t.ar_ivhdr_cshc).HasColumnName("ar_ivhdr_cshc");
            this.Property(t => t.ar_ivhdr_wroffc).HasColumnName("ar_ivhdr_wroffc");
        }
    }
}
