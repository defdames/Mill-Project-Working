using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class expense_budget_SSMap : EntityTypeConfiguration<expense_budget_SS>
    {
        public expense_budget_SSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.employee_name, t.expense_name, t.expense_type, t.expense_amount, t.expense_year, t.expense_quarter });

            // Properties
            this.Property(t => t.employee_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.expense_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.expense_type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.expense_year)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.expense_quarter)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.approved)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("expense budget SS");
            this.Property(t => t.employee_name).HasColumnName("employee_name");
            this.Property(t => t.expense_name).HasColumnName("expense_name");
            this.Property(t => t.expense_type).HasColumnName("expense_type");
            this.Property(t => t.expense_amount).HasColumnName("expense_amount");
            this.Property(t => t.expense_year).HasColumnName("expense_year");
            this.Property(t => t.expense_quarter).HasColumnName("expense_quarter");
            this.Property(t => t.approved).HasColumnName("approved");
        }
    }
}
