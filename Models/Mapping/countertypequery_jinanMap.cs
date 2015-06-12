using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class countertypequery_jinanMap : EntityTypeConfiguration<countertypequery_jinan>
    {
        public countertypequery_jinanMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_item_key, t.so_prod_key });

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("countertypequery_jinan");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
        }
    }
}
