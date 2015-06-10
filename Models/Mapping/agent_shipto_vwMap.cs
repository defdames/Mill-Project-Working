using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class agent_shipto_vwMap : EntityTypeConfiguration<agent_shipto_vw>
    {
        public agent_shipto_vwMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Shipto, t.TargetAcct, t.WhseAcct });

            // Properties
            this.Property(t => t.Shipto)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ShipName)
                .HasMaxLength(30);

            this.Property(t => t.TargetAcct)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.WhseAcct)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.TopCustomerName)
                .HasMaxLength(20);

            this.Property(t => t.Location)
                .HasMaxLength(31);

            // Table & Column Mappings
            this.ToTable("agent_shipto_vw");
            this.Property(t => t.Shipto).HasColumnName("Shipto");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.TargetAcct).HasColumnName("TargetAcct");
            this.Property(t => t.WhseAcct).HasColumnName("WhseAcct");
            this.Property(t => t.TopCustomerName).HasColumnName("TopCustomerName");
            this.Property(t => t.Location).HasColumnName("Location");
        }
    }
}
