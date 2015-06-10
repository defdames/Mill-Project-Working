using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_ivhdr_extMap : EntityTypeConfiguration<ar_ivhdr_ext>
    {
        public ar_ivhdr_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_brnch_key, t.ar_ivhdr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.vessel)
                .HasMaxLength(60);

            this.Property(t => t.markings)
                .HasMaxLength(30);

            this.Property(t => t.shipping_dates)
                .HasMaxLength(30);

            this.Property(t => t.airway_bill_voy)
                .HasMaxLength(30);

            this.Property(t => t.destination_cntry)
                .HasMaxLength(60);

            this.Property(t => t.ports_from_to)
                .HasMaxLength(60);

            this.Property(t => t.ar_ivhdr_satproc)
                .HasMaxLength(1);

            this.Property(t => t.ar_ivhdr_einvstatusmsg)
                .HasMaxLength(255);

            this.Property(t => t.ar_ivhdr_vat)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ar_ivhdr_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_brnch_key).HasColumnName("in_brnch_key");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.vessel).HasColumnName("vessel");
            this.Property(t => t.markings).HasColumnName("markings");
            this.Property(t => t.shipping_dates).HasColumnName("shipping_dates");
            this.Property(t => t.airway_bill_voy).HasColumnName("airway_bill_voy");
            this.Property(t => t.destination_cntry).HasColumnName("destination_cntry");
            this.Property(t => t.ports_from_to).HasColumnName("ports_from_to");
            this.Property(t => t.ar_ivhdr_upcnt).HasColumnName("ar_ivhdr_upcnt");
            this.Property(t => t.ar_ivhdr_satproc).HasColumnName("ar_ivhdr_satproc");
            this.Property(t => t.ar_ivhdr_satpdt).HasColumnName("ar_ivhdr_satpdt");
            this.Property(t => t.ar_ivhdr_einvstatusmsg).HasColumnName("ar_ivhdr_einvstatusmsg");
            this.Property(t => t.ar_ivhdr_folio).HasColumnName("ar_ivhdr_folio");
            this.Property(t => t.ar_ivhdr_vat).HasColumnName("ar_ivhdr_vat");
        }
    }
}
