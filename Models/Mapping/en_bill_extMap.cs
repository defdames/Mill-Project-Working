using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_bill_extMap : EntityTypeConfiguration<en_bill_ext>
    {
        public en_bill_extMap()
        {
            // Primary Key
            this.HasKey(t => t.en_bill_key);

            // Properties
            this.Property(t => t.en_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_country_id)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.aextended_bill_name)
                .HasMaxLength(80);

            this.Property(t => t.city)
                .HasMaxLength(80);

            this.Property(t => t.zcontactname)
                .HasMaxLength(255);

            this.Property(t => t.zinternetaddress)
                .HasMaxLength(255);

            this.Property(t => t.xref_bill_to)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("en_bill_ext");
            this.Property(t => t.en_bill_key).HasColumnName("en_bill_key");
            this.Property(t => t.en_country_id).HasColumnName("en_country_id");
            this.Property(t => t.aextended_bill_name).HasColumnName("aextended_bill_name");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.zcontactname).HasColumnName("zcontactname");
            this.Property(t => t.zinternetaddress).HasColumnName("zinternetaddress");
            this.Property(t => t.xref_bill_to).HasColumnName("xref_bill_to");
            this.Property(t => t.en_bill_upcnt).HasColumnName("en_bill_upcnt");
        }
    }
}
