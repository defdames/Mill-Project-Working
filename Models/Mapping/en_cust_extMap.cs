using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_cust_extMap : EntityTypeConfiguration<en_cust_ext>
    {
        public en_cust_extMap()
        {
            // Primary Key
            this.HasKey(t => t.en_cust_key);

            // Properties
            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.xref_customer_name)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("en_cust_ext");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.xref_customer_name).HasColumnName("xref_customer_name");
            this.Property(t => t.en_cust_upcnt).HasColumnName("en_cust_upcnt");
        }
    }
}
