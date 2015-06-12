using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class commission_transaction_invoice_viewMap : EntityTypeConfiguration<commission_transaction_invoice_view>
    {
        public commission_transaction_invoice_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_salsm_key, t.so_hdr_key, t.so_dtl_key, t.so_comtr_soamt, t.so_comtr_cmval, t.so_comtr_booked, t.so_comtr_trndt, t.in_prod_key, t.in_prod_desc, t.so_shpqt_qty, t.ar_bill_key, t.ar_bill_name, t.so_salsm_name, t.ar_ivhdr_key, t.ar_terms_key, t.ar_terms_desc });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_terms_desc)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("commission_transaction_invoice_view");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.so_comtr_soamt).HasColumnName("so_comtr_soamt");
            this.Property(t => t.so_comtr_cmval).HasColumnName("so_comtr_cmval");
            this.Property(t => t.so_comtr_booked).HasColumnName("so_comtr_booked");
            this.Property(t => t.so_comtr_trndt).HasColumnName("so_comtr_trndt");
            this.Property(t => t.in_prod_key).HasColumnName("in_prod_key");
            this.Property(t => t.in_prod_desc).HasColumnName("in_prod_desc");
            this.Property(t => t.so_shpqt_qty).HasColumnName("so_shpqt_qty");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_bill_name).HasColumnName("ar_bill_name");
            this.Property(t => t.so_salsm_name).HasColumnName("so_salsm_name");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
            this.Property(t => t.ar_terms_desc).HasColumnName("ar_terms_desc");
        }
    }
}
