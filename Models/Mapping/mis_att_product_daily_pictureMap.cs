using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_att_product_daily_pictureMap : EntityTypeConfiguration<mis_att_product_daily_picture>
    {
        public mis_att_product_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => t.item);

            // Properties
            this.Property(t => t.item)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("mis_att_product_daily_picture");
            this.Property(t => t.item).HasColumnName("item");
        }
    }
}
