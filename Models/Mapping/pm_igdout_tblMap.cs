using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_igdout_tblMap : EntityTypeConfiguration<pm_igdout_tbl>
    {
        public pm_igdout_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key, t.sf_ingrd_key, t.sf_opseq_key });

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

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_ingrd_iotp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sf_ingrd_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pm_igdout_tranuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pm_igdout_frzuom)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("pm_igdout_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.sf_ingrd_key).HasColumnName("sf_ingrd_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.sf_ingrd_iotp).HasColumnName("sf_ingrd_iotp");
            this.Property(t => t.sf_ingrd_qty).HasColumnName("sf_ingrd_qty");
            this.Property(t => t.sf_ingrd_nomqty).HasColumnName("sf_ingrd_nomqty");
            this.Property(t => t.pm_igdout_qty).HasColumnName("pm_igdout_qty");
            this.Property(t => t.pm_igdout_wipqt).HasColumnName("pm_igdout_wipqt");
            this.Property(t => t.sf_ingrd_uom).HasColumnName("sf_ingrd_uom");
            this.Property(t => t.pm_igdout_tranuom).HasColumnName("pm_igdout_tranuom");
            this.Property(t => t.fm_prtins_key).HasColumnName("fm_prtins_key");
            this.Property(t => t.fm_ingins_key).HasColumnName("fm_ingins_key");
            this.Property(t => t.pm_igdout_frzqty).HasColumnName("pm_igdout_frzqty");
            this.Property(t => t.pm_igdout_frzuom).HasColumnName("pm_igdout_frzuom");
            this.Property(t => t.pm_igdout_frzcst).HasColumnName("pm_igdout_frzcst");
            this.Property(t => t.pm_igdout_stdqty).HasColumnName("pm_igdout_stdqty");
            this.Property(t => t.pm_igdout_cstrat).HasColumnName("pm_igdout_cstrat");
            this.Property(t => t.pm_igdout_exprat).HasColumnName("pm_igdout_exprat");
            this.Property(t => t.pm_igdout_upcnt).HasColumnName("pm_igdout_upcnt");
        }
    }
}
