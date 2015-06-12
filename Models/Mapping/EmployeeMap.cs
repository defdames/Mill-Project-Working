using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.Clock);

            // Properties
            this.Property(t => t.Plant)
                .HasMaxLength(255);

            this.Property(t => t.Employee_Name)
                .HasMaxLength(255);

            this.Property(t => t.Active_or_Inactive)
                .HasMaxLength(255);

            this.Property(t => t.First)
                .HasMaxLength(255);

            this.Property(t => t.Last)
                .HasMaxLength(255);

            this.Property(t => t.MI)
                .HasMaxLength(255);

            this.Property(t => t.Number)
                .HasMaxLength(255);

            this.Property(t => t.Street)
                .HasMaxLength(255);

            this.Property(t => t.City)
                .HasMaxLength(255);

            this.Property(t => t.State)
                .HasMaxLength(255);

            this.Property(t => t.Zip)
                .HasMaxLength(255);

            this.Property(t => t.Phone)
                .HasMaxLength(255);

            this.Property(t => t.Cell_Phone)
                .HasMaxLength(255);

            this.Property(t => t.Status)
                .HasMaxLength(255);

            this.Property(t => t.Classification)
                .HasMaxLength(255);

            this.Property(t => t.Dept)
                .HasMaxLength(255);

            this.Property(t => t.Shift)
                .HasMaxLength(255);

            this.Property(t => t.Layoff_Date)
                .HasMaxLength(255);

            this.Property(t => t.Non_Emp_Date)
                .HasMaxLength(255);

            this.Property(t => t.Month)
                .HasMaxLength(255);

            this.Property(t => t.Day)
                .HasMaxLength(255);

            this.Property(t => t.Number1)
                .HasMaxLength(255);

            this.Property(t => t.Union_)
                .HasMaxLength(255);

            this.Property(t => t.Prev_Yr_Left)
                .HasMaxLength(255);

            this.Property(t => t.Entitlement)
                .HasMaxLength(255);

            this.Property(t => t.Vac_Days_Used)
                .HasMaxLength(255);

            this.Property(t => t.Vac_Days_Avail)
                .HasMaxLength(255);

            this.Property(t => t.Vac_Remaining)
                .HasMaxLength(255);

            this.Property(t => t.Shoe_Remarks)
                .HasMaxLength(255);

            this.Property(t => t.Shoe_Style)
                .HasMaxLength(255);

            this.Property(t => t.Shoe_Size)
                .HasMaxLength(255);

            this.Property(t => t.Filter_Field)
                .HasMaxLength(255);

            this.Property(t => t.Hourly_Salaried)
                .HasMaxLength(255);

            this.Property(t => t.originalplant)
                .HasMaxLength(255);

            this.Property(t => t.originaldept)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Employees");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.Employee_Name).HasColumnName("Employee Name");
            this.Property(t => t.Active_or_Inactive).HasColumnName("Active or Inactive");
            this.Property(t => t.First).HasColumnName("First");
            this.Property(t => t.Last).HasColumnName("Last");
            this.Property(t => t.MI).HasColumnName("MI");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.Street).HasColumnName("Street");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Cell_Phone).HasColumnName("Cell Phone");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Start_Date).HasColumnName("Start Date");
            this.Property(t => t.Dept_Date).HasColumnName("Dept Date");
            this.Property(t => t.Classification).HasColumnName("Classification");
            this.Property(t => t.Dept).HasColumnName("Dept");
            this.Property(t => t.Shift).HasColumnName("Shift");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.Clock).HasColumnName("Clock");
            this.Property(t => t.Layoff_Date).HasColumnName("Layoff Date");
            this.Property(t => t.Non_Emp_Date).HasColumnName("Non-Emp Date");
            this.Property(t => t.Month).HasColumnName("Month");
            this.Property(t => t.Day).HasColumnName("Day");
            this.Property(t => t.Plant_Date).HasColumnName("Plant Date");
            this.Property(t => t.Number1).HasColumnName("Number1");
            this.Property(t => t.Union_).HasColumnName("Union?");
            this.Property(t => t.Prev_Yr_Left).HasColumnName("Prev Yr Left");
            this.Property(t => t.Entitlement).HasColumnName("Entitlement");
            this.Property(t => t.Vac_Days_Used).HasColumnName("Vac Days Used");
            this.Property(t => t.Vac_Days_Avail).HasColumnName("Vac Days Avail");
            this.Property(t => t.Vac_Remaining).HasColumnName("Vac Remaining");
            this.Property(t => t.Shoe_Remarks).HasColumnName("Shoe Remarks");
            this.Property(t => t.Shoe_Style).HasColumnName("Shoe Style");
            this.Property(t => t.Shoe_Size).HasColumnName("Shoe Size");
            this.Property(t => t.Filter_Field).HasColumnName("Filter Field");
            this.Property(t => t.Seniority).HasColumnName("Seniority");
            this.Property(t => t.Hourly_Salaried).HasColumnName("Hourly/Salaried");
            this.Property(t => t.originalplant).HasColumnName("originalplant");
            this.Property(t => t.originaldept).HasColumnName("originaldept");
            this.Property(t => t.currentdeptdate).HasColumnName("currentdeptdate");
        }
    }
}
