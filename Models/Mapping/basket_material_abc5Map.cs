using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class basket_material_abc5Map : EntityTypeConfiguration<basket_material_abc5>
    {
        public basket_material_abc5Map()
        {
            // Primary Key
            this.HasKey(t => new { t.in_item_key, t.gl_perod_year });

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("basket_material_abc5");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
        }
    }
}
