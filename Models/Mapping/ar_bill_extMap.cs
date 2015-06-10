using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_bill_extMap : EntityTypeConfiguration<ar_bill_ext>
    {
        public ar_bill_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ar_bill_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_rfc)
                .HasMaxLength(13);

            this.Property(t => t.ar_bill_xrefcreacct)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ar_bill_xrefdebacct)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ar_bill_payacct)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("ar_bill_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_bill_rfc).HasColumnName("ar_bill_rfc");
            this.Property(t => t.ar_bill_upcnt).HasColumnName("ar_bill_upcnt");
            this.Property(t => t.ar_bill_xrefcreacct).HasColumnName("ar_bill_xrefcreacct");
            this.Property(t => t.ar_bill_xrefdebacct).HasColumnName("ar_bill_xrefdebacct");
            this.Property(t => t.ar_bill_payacct).HasColumnName("ar_bill_payacct");
        }
    }
}
