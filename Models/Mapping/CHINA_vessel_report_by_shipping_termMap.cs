using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_vessel_report_by_shipping_termMap : EntityTypeConfiguration<CHINA_vessel_report_by_shipping_term>
    {
        public CHINA_vessel_report_by_shipping_termMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DocKey, t.DocType, t.DocKeyType, t.ar_ivhdr_key, t.ar_bill_name, t.ar_bill_key, t.so_hdr_key, t.ar_ivhdr_ivblc, t.gl_cmp_key, t.country, t.gl_crncy_key, t.so_dtl_fobds });

            // Properties
            this.Property(t => t.DocKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DocType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DocKeyType)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.country)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.so_dtl_fobds)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.vessel)
                .HasMaxLength(60);

            this.Property(t => t.ports_from_to)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("CHINA_vessel_report_by_shipping_term");
            this.Property(t => t.DocKey).HasColumnName("DocKey");
            this.Property(t => t.TranDateKey).HasColumnName("TranDateKey");
            this.Property(t => t.DocType).HasColumnName("DocType");
            this.Property(t => t.DocKeyType).HasColumnName("DocKeyType");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.ar_bill_name).HasColumnName("ar_bill_name");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.ar_ivhdr_ivblc).HasColumnName("ar_ivhdr_ivblc");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.so_dtl_fobds).HasColumnName("so_dtl_fobds");
            this.Property(t => t.vessel).HasColumnName("vessel");
            this.Property(t => t.shipping_dates).HasColumnName("shipping_dates");
            this.Property(t => t.ports_from_to).HasColumnName("ports_from_to");
        }
    }
}
