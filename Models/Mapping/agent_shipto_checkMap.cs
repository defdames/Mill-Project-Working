using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class agent_shipto_checkMap : EntityTypeConfiguration<agent_shipto_check>
    {
        public agent_shipto_checkMap()
        {
            // Primary Key
            this.HasKey(t => new { t.agt, t.shpto });

            // Properties
            this.Property(t => t.agt)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.shpto)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("agent_shipto_check");
            this.Property(t => t.agt).HasColumnName("agt");
            this.Property(t => t.shpto).HasColumnName("shpto");
        }
    }
}
