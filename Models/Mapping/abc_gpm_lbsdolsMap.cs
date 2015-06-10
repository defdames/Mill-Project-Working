using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class abc_gpm_lbsdolsMap : EntityTypeConfiguration<abc_gpm_lbsdols>
    {
        public abc_gpm_lbsdolsMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemKey);

            // Properties
            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("abc_gpm_lbsdols");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.Dollars).HasColumnName("Dollars");
            this.Property(t => t.Pounds).HasColumnName("Pounds");
            this.Property(t => t.Cost).HasColumnName("Cost");
            this.Property(t => t.GPM).HasColumnName("GPM");
        }
    }
}
