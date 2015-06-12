using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class asia_supply_chain_performanceMap : EntityTypeConfiguration<asia_supply_chain_performance>
    {
        public asia_supply_chain_performanceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.type, t.company });

            // Properties
            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.user)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("asia_supply_chain_performance");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.count).HasColumnName("count");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.user).HasColumnName("user");
            this.Property(t => t.period).HasColumnName("period");
            this.Property(t => t.year).HasColumnName("year");
        }
    }
}
