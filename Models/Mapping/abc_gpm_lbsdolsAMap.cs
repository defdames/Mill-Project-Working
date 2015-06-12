using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class abc_gpm_lbsdolsAMap : EntityTypeConfiguration<abc_gpm_lbsdolsA>
    {
        public abc_gpm_lbsdolsAMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemKey);

            // Properties
            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("abc_gpm_lbsdolsA");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.Dollars).HasColumnName("Dollars");
            this.Property(t => t.Pounds).HasColumnName("Pounds");
            this.Property(t => t.Cost).HasColumnName("Cost");
            this.Property(t => t.GPM).HasColumnName("GPM");
        }
    }
}
