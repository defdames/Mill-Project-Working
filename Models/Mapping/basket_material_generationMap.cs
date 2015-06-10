using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class basket_material_generationMap : EntityTypeConfiguration<basket_material_generation>
    {
        public basket_material_generationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PackKey, t.Whse, t.PdMo, t.PdYr, t.ABCCode });

            // Properties
            this.Property(t => t.ItemKey)
                .HasMaxLength(25);

            this.Property(t => t.PackKey)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Whse)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.PdMo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PdYr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Period)
                .HasMaxLength(7);

            this.Property(t => t.ABCCode)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("basket_material_generation");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.PackKey).HasColumnName("PackKey");
            this.Property(t => t.Whse).HasColumnName("Whse");
            this.Property(t => t.PdMo).HasColumnName("PdMo");
            this.Property(t => t.PdYr).HasColumnName("PdYr");
            this.Property(t => t.Period).HasColumnName("Period");
            this.Property(t => t.ABCCode).HasColumnName("ABCCode");
            this.Property(t => t.QtyGenerated).HasColumnName("QtyGenerated");
        }
    }
}
