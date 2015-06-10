using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class capital_purchases1Map : EntityTypeConfiguration<capital_purchases1>
    {
        public capital_purchases1Map()
        {
            // Primary Key
            this.HasKey(t => t.Po_num);

            // Properties
            this.Property(t => t.Po_num)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("capital_purchases1");
            this.Property(t => t.Po_num).HasColumnName("Po_num");
            this.Property(t => t.PoTotal).HasColumnName("PoTotal");
        }
    }
}
