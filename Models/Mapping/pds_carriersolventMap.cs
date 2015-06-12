using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pds_carriersolventMap : EntityTypeConfiguration<pds_carriersolvent>
    {
        public pds_carriersolventMap()
        {
            // Primary Key
            this.HasKey(t => new { t.item, t.en_prod_desc, t.carrier_solvent });

            // Properties
            this.Property(t => t.item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_prod_desc)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.carrier_solvent)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("pds_carriersolvent");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
            this.Property(t => t.carrier_solvent).HasColumnName("carrier/solvent");
        }
    }
}
