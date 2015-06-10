using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class agent_sample_scheduled_alexMap : EntityTypeConfiguration<agent_sample_scheduled_alex>
    {
        public agent_sample_scheduled_alexMap()
        {
            // Primary Key
            this.HasKey(t => t.so_salsm_key);

            // Properties
            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.send_to)
                .HasMaxLength(500);

            this.Property(t => t.cc_to)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("agent_sample_scheduled_alex");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.send_to).HasColumnName("send_to");
            this.Property(t => t.cc_to).HasColumnName("cc_to");
        }
    }
}
