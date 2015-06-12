using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_vend_extMap : EntityTypeConfiguration<en_vend_ext>
    {
        public en_vend_extMap()
        {
            // Primary Key
            this.HasKey(t => t.en_vend_key);

            // Properties
            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.vendor_name)
                .HasMaxLength(60);

            this.Property(t => t.iso_certification)
                .HasMaxLength(1);

            this.Property(t => t.xref_vendor_name)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("en_vend_ext");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.vendor_name).HasColumnName("vendor_name");
            this.Property(t => t.iso_certification).HasColumnName("iso_certification");
            this.Property(t => t.xref_vendor_name).HasColumnName("xref_vendor_name");
            this.Property(t => t.ins_cert_exp).HasColumnName("ins_cert_exp");
            this.Property(t => t.en_vend_upcnt).HasColumnName("en_vend_upcnt");
        }
    }
}
