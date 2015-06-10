using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EHS_incident_analysis_tbl_usrMap : EntityTypeConfiguration<EHS_incident_analysis_tbl_usr>
    {
        public EHS_incident_analysis_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.Incident_no);

            // Properties
            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Supervisor)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Emp_last)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Emp_mi)
                .HasMaxLength(50);

            this.Property(t => t.Emp_first)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Incident_classification)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Job_title)
                .HasMaxLength(50);

            this.Property(t => t.Department)
                .HasMaxLength(50);

            this.Property(t => t.Short_incident_desc)
                .HasMaxLength(50);

            this.Property(t => t.Injury_type)
                .HasMaxLength(50);

            this.Property(t => t.Body_part)
                .HasMaxLength(50);

            this.Property(t => t.Cause_code)
                .HasMaxLength(50);

            this.Property(t => t.Chemicals_released)
                .HasMaxLength(50);

            this.Property(t => t.Amount_released)
                .HasMaxLength(50);

            this.Property(t => t.Media_affected)
                .HasMaxLength(50);

            this.Property(t => t.Spill_location)
                .HasMaxLength(50);

            this.Property(t => t.Cleanup_methods)
                .HasMaxLength(50);

            this.Property(t => t.Environmental_impact)
                .HasMaxLength(50);

            this.Property(t => t.OutsideMedAtt)
                .HasMaxLength(50);

            this.Property(t => t.Recordable)
                .HasMaxLength(50);

            this.Property(t => t.LTA)
                .HasMaxLength(50);

            this.Property(t => t.Restricted_duty)
                .HasMaxLength(50);

            this.Property(t => t.equipment_class)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EHS_incident_analysis_tbl_usr");
            this.Property(t => t.Incident_no).HasColumnName("Incident_no");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Incident_date).HasColumnName("Incident_date");
            this.Property(t => t.Incident_time).HasColumnName("Incident_time");
            this.Property(t => t.Reported_date).HasColumnName("Reported_date");
            this.Property(t => t.Completed_date).HasColumnName("Completed_date");
            this.Property(t => t.Supervisor).HasColumnName("Supervisor");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Emp_last).HasColumnName("Emp_last");
            this.Property(t => t.Emp_mi).HasColumnName("Emp_mi");
            this.Property(t => t.Emp_first).HasColumnName("Emp_first");
            this.Property(t => t.Incident_classification).HasColumnName("Incident_classification");
            this.Property(t => t.Injury_time).HasColumnName("Injury_time");
            this.Property(t => t.Years_service).HasColumnName("Years_service");
            this.Property(t => t.Shift_start_time).HasColumnName("Shift_start_time");
            this.Property(t => t.Job_title).HasColumnName("Job_title");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.Injury_description).HasColumnName("Injury_description");
            this.Property(t => t.Short_incident_desc).HasColumnName("Short_incident_desc");
            this.Property(t => t.Injury_type).HasColumnName("Injury_type");
            this.Property(t => t.Body_part).HasColumnName("Body_part");
            this.Property(t => t.Cause_code).HasColumnName("Cause_code");
            this.Property(t => t.Treatment_description).HasColumnName("Treatment_description");
            this.Property(t => t.Chemicals_released).HasColumnName("Chemicals_released");
            this.Property(t => t.Amount_released).HasColumnName("Amount_released");
            this.Property(t => t.Media_affected).HasColumnName("Media_affected");
            this.Property(t => t.Migrate_offsite).HasColumnName("Migrate_offsite");
            this.Property(t => t.Spill_location).HasColumnName("Spill_location");
            this.Property(t => t.Cleanup_methods).HasColumnName("Cleanup_methods");
            this.Property(t => t.Environmental_impact).HasColumnName("Environmental_impact");
            this.Property(t => t.Incident_description).HasColumnName("Incident_description");
            this.Property(t => t.Witnesses).HasColumnName("Witnesses");
            this.Property(t => t.Root_cause).HasColumnName("Root_cause");
            this.Property(t => t.Contributing_cause).HasColumnName("Contributing_cause");
            this.Property(t => t.OutsideMedAtt).HasColumnName("OutsideMedAtt");
            this.Property(t => t.Recordable).HasColumnName("Recordable");
            this.Property(t => t.LTA).HasColumnName("LTA");
            this.Property(t => t.Restricted_duty).HasColumnName("Restricted_duty");
            this.Property(t => t.NumberOfDays).HasColumnName("NumberOfDays");
            this.Property(t => t.equipment_class).HasColumnName("equipment_class");
        }
    }
}
