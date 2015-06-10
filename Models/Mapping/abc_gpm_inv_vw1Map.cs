using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class abc_gpm_inv_vw1Map : EntityTypeConfiguration<abc_gpm_inv_vw1>
    {
        public abc_gpm_inv_vw1Map()
        {
            // Primary Key
            this.HasKey(t => t.ItemKey);

            // Properties
            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("abc_gpm_inv_vw1");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.QOH).HasColumnName("QOH");
            this.Property(t => t.Value).HasColumnName("Value");
        }
    }
}
