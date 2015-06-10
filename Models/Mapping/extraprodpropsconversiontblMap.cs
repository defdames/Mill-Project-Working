using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class extraprodpropsconversiontblMap : EntityTypeConfiguration<extraprodpropsconversiontbl>
    {
        public extraprodpropsconversiontblMap()
        {
            // Primary Key
            this.HasKey(t => t.xprodprop);

            // Properties
            this.Property(t => t.xprodprop)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.conversion)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("extraprodpropsconversiontbl");
            this.Property(t => t.xprodprop).HasColumnName("xprodprop");
            this.Property(t => t.conversion).HasColumnName("conversion");
        }
    }
}
