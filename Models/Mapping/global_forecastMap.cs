using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class global_forecastMap : EntityTypeConfiguration<global_forecast>
    {
        public global_forecastMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.location)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("global_forecast");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.datestamp).HasColumnName("datestamp");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.id).HasColumnName("id");
        }
    }
}
