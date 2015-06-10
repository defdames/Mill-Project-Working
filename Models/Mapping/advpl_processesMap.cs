using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_processesMap : EntityTypeConfiguration<advpl_processes>
    {
        public advpl_processesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Process_ID, t.System_ID, t.batch_size, t.company });

            // Properties
            this.Property(t => t.Process_ID)
                .IsRequired()
                .HasMaxLength(27);

            this.Property(t => t.System_ID)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.batch_size)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("advpl_processes");
            this.Property(t => t.Process_ID).HasColumnName("Process ID");
            this.Property(t => t.System_ID).HasColumnName("System ID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.batch_size).HasColumnName("batch_size");
            this.Property(t => t.company).HasColumnName("company");
        }
    }
}
