using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pds_carriersolvent_tempMap : EntityTypeConfiguration<pds_carriersolvent_temp>
    {
        public pds_carriersolvent_tempMap()
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
            this.ToTable("pds_carriersolvent_temp");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
            this.Property(t => t.carrier_solvent).HasColumnName("carrier/solvent");
        }
    }
}
