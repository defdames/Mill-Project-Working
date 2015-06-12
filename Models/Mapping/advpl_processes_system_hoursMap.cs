using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_processes_system_hoursMap : EntityTypeConfiguration<advpl_processes_system_hours>
    {
        public advpl_processes_system_hoursMap()
        {
            // Primary Key
            this.HasKey(t => new { t.company, t.systemid, t.maxhours });

            // Properties
            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.systemid)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.maxhours)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("advpl_processes_system_hours");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.systemid).HasColumnName("systemid");
            this.Property(t => t.bucket).HasColumnName("bucket");
            this.Property(t => t.maxhours).HasColumnName("maxhours");
        }
    }
}
