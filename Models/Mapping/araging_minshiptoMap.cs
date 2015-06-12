using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class araging_minshiptoMap : EntityTypeConfiguration<araging_minshipto>
    {
        public araging_minshiptoMap()
        {
            // Primary Key
            this.HasKey(t => t.en_bill_key);

            // Properties
            this.Property(t => t.en_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_ship_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("araging_minshipto");
            this.Property(t => t.en_bill_key).HasColumnName("en_bill_key");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
        }
    }
}
