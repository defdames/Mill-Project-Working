using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CapitalProject_BudgetMap : EntityTypeConfiguration<CapitalProject_Budget>
    {
        public CapitalProject_BudgetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.CapitalProjNum, t.AccountCode });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CapitalProjNum)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.AccountCode)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("CapitalProject_Budget");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.CapitalProjNum).HasColumnName("CapitalProjNum");
            this.Property(t => t.AccountCode).HasColumnName("AccountCode");
            this.Property(t => t.ApprovedCost).HasColumnName("ApprovedCost");
            this.Property(t => t.EstAdditionalCost).HasColumnName("EstAdditionalCost");
        }
    }
}
