using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class artermMap : EntityTypeConfiguration<arterm>
    {
        public artermMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_bill_key, t.ar_terms_key, t.ar_bill_name, t.HIHGBAL });

            // Properties
            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_bill_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ar_terms_desc)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("arterms");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
            this.Property(t => t.ar_bill_name).HasColumnName("ar_bill_name");
            this.Property(t => t.ar_terms_desc).HasColumnName("ar_terms_desc");
            this.Property(t => t.ytddaystopay).HasColumnName("ytddaystopay");
            this.Property(t => t.days).HasColumnName("days");
            this.Property(t => t.rcount).HasColumnName("rcount");
            this.Property(t => t.HIHGBAL).HasColumnName("HIHGBAL");
            this.Property(t => t.AR_BILL_CLMTC).HasColumnName("AR_BILL_CLMTC");
        }
    }
}
