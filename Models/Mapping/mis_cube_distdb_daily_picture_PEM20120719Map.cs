using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_distdb_daily_picture_PEM20120719Map : EntityTypeConfiguration<mis_cube_distdb_daily_picture_PEM20120719>
    {
        public mis_cube_distdb_daily_picture_PEM20120719Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Company, t.ShiptoName, t.SalesType, t.CustomerWhse, t.CostValue });

            // Properties
            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.TranDate)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Agent)
                .HasMaxLength(45);

            this.Property(t => t.Grade)
                .HasMaxLength(60);

            this.Property(t => t.ShiptoName)
                .IsRequired()
                .HasMaxLength(67);

            this.Property(t => t.Location)
                .HasMaxLength(35);

            this.Property(t => t.Country)
                .HasMaxLength(20);

            this.Property(t => t.SalesType)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.CustomerWhse)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("mis_cube_distdb_daily_picture_PEM20120719");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.TranDate).HasColumnName("TranDate");
            this.Property(t => t.Agent).HasColumnName("Agent");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.ShiptoName).HasColumnName("ShiptoName");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.SalesType).HasColumnName("SalesType");
            this.Property(t => t.CustomerWhse).HasColumnName("CustomerWhse");
            this.Property(t => t.Dollars).HasColumnName("Dollars");
            this.Property(t => t.Pounds).HasColumnName("Pounds");
            this.Property(t => t.KGS).HasColumnName("KGS");
            this.Property(t => t.CostValue).HasColumnName("CostValue");
        }
    }
}
