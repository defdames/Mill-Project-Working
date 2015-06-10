using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class currency_rate_table_cmp_commission_report_cp1Map : EntityTypeConfiguration<currency_rate_table_cmp_commission_report_cp1>
    {
        public currency_rate_table_cmp_commission_report_cp1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.currencyPK, t.gl_crcnv_bdate, t.gl_crcnv_edate, t.gl_crcnv_rate, t.gl_cmp_key, t.gl_CRNCY_FROM, t.gl_CRNCY_TO });

            // Properties
            this.Property(t => t.currencyPK)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.gl_CRNCY_FROM)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.gl_CRNCY_TO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("currency_rate_table_cmp_commission_report_cp1");
            this.Property(t => t.currencyPK).HasColumnName("currencyPK");
            this.Property(t => t.gl_crcnv_bdate).HasColumnName("gl_crcnv_bdate");
            this.Property(t => t.gl_crcnv_edate).HasColumnName("gl_crcnv_edate");
            this.Property(t => t.gl_crcnv_rate).HasColumnName("gl_crcnv_rate");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_CRNCY_FROM).HasColumnName("gl_CRNCY_FROM");
            this.Property(t => t.gl_CRNCY_TO).HasColumnName("gl_CRNCY_TO");
        }
    }
}
