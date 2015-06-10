using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_published_planMap : EntityTypeConfiguration<advpl_published_plan>
    {
        public advpl_published_planMap()
        {
            // Primary Key
            this.HasKey(t => new { t.company, t.plan_year, t.plan_month });

            // Properties
            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.plan_year)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.plan_month)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.planid)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("advpl_published_plan");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.plan_year).HasColumnName("plan_year");
            this.Property(t => t.plan_month).HasColumnName("plan_month");
            this.Property(t => t.planid).HasColumnName("planid");
        }
    }
}
