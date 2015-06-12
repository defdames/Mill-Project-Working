using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class abc_gpm_dbcrm_lbsdolsMap : EntityTypeConfiguration<abc_gpm_dbcrm_lbsdols>
    {
        public abc_gpm_dbcrm_lbsdolsMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemKey);

            // Properties
            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("abc_gpm_dbcrm_lbsdols");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.dc_Dollars).HasColumnName("dc_Dollars");
            this.Property(t => t.dc_Pounds).HasColumnName("dc_Pounds");
            this.Property(t => t.dc_Cost).HasColumnName("dc_Cost");
            this.Property(t => t.dc_GPM).HasColumnName("dc_GPM");
        }
    }
}
