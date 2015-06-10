using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_distdb_daily_picture_newsegmentMap : EntityTypeConfiguration<mis_cube_distdb_daily_picture_newsegment>
    {
        public mis_cube_distdb_daily_picture_newsegmentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SalesType, t.CustomerWhse, t.act_fcst });

            // Properties
            this.Property(t => t.Company)
                .HasMaxLength(500);

            this.Property(t => t.TranDate)
                .HasMaxLength(30);

            this.Property(t => t.Agent)
                .HasMaxLength(200);

            this.Property(t => t.Grade)
                .HasMaxLength(200);

            this.Property(t => t.ShipToName)
                .HasMaxLength(570);

            this.Property(t => t.Location)
                .HasMaxLength(200);

            this.Property(t => t.Country)
                .HasMaxLength(20);

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
            this.ToTable("mis_cube_distdb_daily_picture_newsegment");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.TranDate).HasColumnName("TranDate");
            this.Property(t => t.Agent).HasColumnName("Agent");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.ShipToName).HasColumnName("ShipToName");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.SalesType).HasColumnName("SalesType");
            this.Property(t => t.CustomerWhse).HasColumnName("CustomerWhse");
            this.Property(t => t.Dollars).HasColumnName("Dollars");
            this.Property(t => t.Pounds).HasColumnName("Pounds");
            this.Property(t => t.KGS).HasColumnName("KGS");
            this.Property(t => t.CostValue).HasColumnName("CostValue");
            this.Property(t => t.market).HasColumnName("market");
            this.Property(t => t.act_fcst).HasColumnName("act_fcst");
            this.Property(t => t.pdadollars).HasColumnName("pdadollars");
        }
    }
}
