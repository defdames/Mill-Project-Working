using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_rout_tblMap : EntityTypeConfiguration<sf_rout_tbl>
    {
        public sf_rout_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_rout_key, t.sf_opseq_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_opseq_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_rout_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sf_rout_altop)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("sf_rout_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.sf_rout_desc).HasColumnName("sf_rout_desc");
            this.Property(t => t.fm_prtins_key).HasColumnName("fm_prtins_key");
            this.Property(t => t.sf_opseq_type).HasColumnName("sf_opseq_type");
            this.Property(t => t.sf_rout_effdt).HasColumnName("sf_rout_effdt");
            this.Property(t => t.sf_rout_inadt).HasColumnName("sf_rout_inadt");
            this.Property(t => t.sf_rout_altop).HasColumnName("sf_rout_altop");
            this.Property(t => t.sf_rout_bldt).HasColumnName("sf_rout_bldt");
            this.Property(t => t.sf_rout_btchz).HasColumnName("sf_rout_btchz");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.sf_rout_cpt).HasColumnName("sf_rout_cpt");
            this.Property(t => t.sf_rout_nbtch).HasColumnName("sf_rout_nbtch");
            this.Property(t => t.sf_rout_ovlqt).HasColumnName("sf_rout_ovlqt");
            this.Property(t => t.sf_rout_ovltp).HasColumnName("sf_rout_ovltp");
            this.Property(t => t.sf_rout_ppt).HasColumnName("sf_rout_ppt");
            this.Property(t => t.sf_rout_uldt).HasColumnName("sf_rout_uldt");
            this.Property(t => t.sf_rout_yield).HasColumnName("sf_rout_yield");
            this.Property(t => t.sf_rout_upcnt).HasColumnName("sf_rout_upcnt");
        }
    }
}
