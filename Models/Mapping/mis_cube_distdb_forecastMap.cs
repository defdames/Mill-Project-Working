using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_distdb_forecastMap : EntityTypeConfiguration<mis_cube_distdb_forecast>
    {
        public mis_cube_distdb_forecastMap()
        {
            // Primary Key
            this.HasKey(t => new { t.company, t.Country, t.SalesType, t.CustomerWhse, t.act_fcst });

            // Properties
            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.trandate)
                .HasMaxLength(10);

            this.Property(t => t.agent)
                .HasMaxLength(200);

            this.Property(t => t.Grade)
                .HasMaxLength(200);

            this.Property(t => t.ShipToName)
                .HasMaxLength(200);

            this.Property(t => t.Location)
                .HasMaxLength(200);

            this.Property(t => t.Country)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.SalesType)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.CustomerWhse)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.market)
                .HasMaxLength(200);

            this.Property(t => t.act_fcst)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("mis_cube_distdb_forecast");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.trandate).HasColumnName("trandate");
            this.Property(t => t.agent).HasColumnName("agent");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.ShipToName).HasColumnName("ShipToName");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.SalesType).HasColumnName("SalesType");
            this.Property(t => t.CustomerWhse).HasColumnName("CustomerWhse");
            this.Property(t => t.Dollars).HasColumnName("Dollars");
            this.Property(t => t.Pounds).HasColumnName("Pounds");
            this.Property(t => t.KGS).HasColumnName("KGS");
            this.Property(t => t.costvalue).HasColumnName("costvalue");
            this.Property(t => t.market).HasColumnName("market");
            this.Property(t => t.act_fcst).HasColumnName("act_fcst");
        }
    }
}
