using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_abcgpm_tbl_usrMap : EntityTypeConfiguration<in_abcgpm_tbl_usr>
    {
        public in_abcgpm_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemKey);

            // Properties
            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ABCode)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("in_abcgpm_tbl_usr");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.ABCode).HasColumnName("ABCode");
            this.Property(t => t.ItemCost).HasColumnName("ItemCost");
            this.Property(t => t.QOH).HasColumnName("QOH");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Forecast).HasColumnName("Forecast");
            this.Property(t => t.Dollars).HasColumnName("Dollars");
            this.Property(t => t.Pounds).HasColumnName("Pounds");
            this.Property(t => t.Cost).HasColumnName("Cost");
            this.Property(t => t.GPM).HasColumnName("GPM");
            this.Property(t => t.BeginMo).HasColumnName("BeginMo");
            this.Property(t => t.BeginYr).HasColumnName("BeginYr");
            this.Property(t => t.EndMo).HasColumnName("EndMo");
            this.Property(t => t.EndYr).HasColumnName("EndYr");
        }
    }
}
