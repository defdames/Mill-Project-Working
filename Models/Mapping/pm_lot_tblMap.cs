using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_lot_tblMap : EntityTypeConfiguration<pm_lot_tbl>
    {
        public pm_lot_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key, t.sf_ingrd_key, t.sf_opseq_key, t.in_lot_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pm_shop_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_ingrd_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_opseq_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.pm_lot_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pm_lot_actuom)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("pm_lot_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.sf_ingrd_key).HasColumnName("sf_ingrd_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.pm_lot_pflg).HasColumnName("pm_lot_pflg");
            this.Property(t => t.pm_lot_spgvt).HasColumnName("pm_lot_spgvt");
            this.Property(t => t.pm_lot_holdf).HasColumnName("pm_lot_holdf");
            this.Property(t => t.pm_lot_grde).HasColumnName("pm_lot_grde");
            this.Property(t => t.pm_lot_qty).HasColumnName("pm_lot_qty");
            this.Property(t => t.pm_lot_uom).HasColumnName("pm_lot_uom");
            this.Property(t => t.pm_lot_actqt).HasColumnName("pm_lot_actqt");
            this.Property(t => t.pm_lot_actuom).HasColumnName("pm_lot_actuom");
            this.Property(t => t.pm_lot_upcnt).HasColumnName("pm_lot_upcnt");
            this.Property(t => t.pm_lot_wipqt).HasColumnName("pm_lot_wipqt");
            this.Property(t => t.pm_lot_qcqty).HasColumnName("pm_lot_qcqty");
        }
    }
}
