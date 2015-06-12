using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EHS_responsiblepersonstableMap : EntityTypeConfiguration<EHS_responsiblepersonstable>
    {
        public EHS_responsiblepersonstableMap()
        {
            // Primary Key
            this.HasKey(t => new { t.company, t.namelfi });

            // Properties
            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.namelfi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.namefull)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EHS responsiblepersonstable");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.namelfi).HasColumnName("namelfi");
            this.Property(t => t.namefull).HasColumnName("namefull");
            this.Property(t => t.email).HasColumnName("email");
        }
    }
}
