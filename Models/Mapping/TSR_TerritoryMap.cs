using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class TSR_TerritoryMap : EntityTypeConfiguration<TSR_Territory>
    {
        public TSR_TerritoryMap()
        {
            // Primary Key
            this.HasKey(t => t.State);

            // Properties
            this.Property(t => t.State)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Abbrev_St)
                .HasMaxLength(50);

            this.Property(t => t.Agent)
                .HasMaxLength(255);

            this.Property(t => t.Regional_Mgr)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TSR_Territory");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Abbrev_St).HasColumnName("Abbrev St");
            this.Property(t => t.Agent).HasColumnName("Agent");
            this.Property(t => t.Regional_Mgr).HasColumnName("Regional Mgr");
        }
    }
}
