using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_paretoMap : EntityTypeConfiguration<advpl_pareto>
    {
        public advpl_paretoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.Rank });

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Rank)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Pareto)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("advpl_pareto");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Sales___0_kg).HasColumnName("Sales:#,0 kg");
            this.Property(t => t.Pct_Total_0_0_).HasColumnName("Pct.Total:0.0%");
            this.Property(t => t.Cum__0_0_).HasColumnName("Cum%:0.0%");
            this.Property(t => t.Rank).HasColumnName("Rank");
            this.Property(t => t.Pareto).HasColumnName("Pareto");
            this.Property(t => t.Diff_).HasColumnName("Diff?");
        }
    }
}
