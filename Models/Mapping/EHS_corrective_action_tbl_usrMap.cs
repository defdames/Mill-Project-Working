using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EHS_corrective_action_tbl_usrMap : EntityTypeConfiguration<EHS_corrective_action_tbl_usr>
    {
        public EHS_corrective_action_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Incident_no, t.CA_dtl_key });

            // Properties
            this.Property(t => t.Incident_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CA_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Corrective_action)
                .IsRequired();

            this.Property(t => t.Cause_addressed)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Responsible_person)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EHS_corrective_action_tbl_usr");
            this.Property(t => t.Incident_no).HasColumnName("Incident_no");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.CA_dtl_key).HasColumnName("CA_dtl_key");
            this.Property(t => t.Corrective_action).HasColumnName("Corrective_action");
            this.Property(t => t.Cause_addressed).HasColumnName("Cause_addressed");
            this.Property(t => t.Responsible_person).HasColumnName("Responsible_person");
            this.Property(t => t.Target_date).HasColumnName("Target_date");
            this.Property(t => t.Completion_date).HasColumnName("Completion_date");
        }
    }
}
