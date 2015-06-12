using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class abc_gpm_lbsdols_vw1Map : EntityTypeConfiguration<abc_gpm_lbsdols_vw1>
    {
        public abc_gpm_lbsdols_vw1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.HdrKey, t.DtlKey, t.ItemKey, t.Dollars });

            // Properties
            this.Property(t => t.HdrKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DtlKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("abc_gpm_lbsdols_vw1");
            this.Property(t => t.HdrKey).HasColumnName("HdrKey");
            this.Property(t => t.DtlKey).HasColumnName("DtlKey");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.Dollars).HasColumnName("Dollars");
            this.Property(t => t.Pounds).HasColumnName("Pounds");
            this.Property(t => t.cost).HasColumnName("cost");
        }
    }
}
