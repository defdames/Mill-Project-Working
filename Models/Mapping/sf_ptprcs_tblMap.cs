using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_ptprcs_tblMap : EntityTypeConfiguration<sf_ptprcs_tbl>
    {
        public sf_ptprcs_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.in_item_key, t.sf_prcss_key, t.sf_prcss_ver, t.sf_frmla_effdt, t.sf_frmla_inadt });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_prcss_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_prcss_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sf_ptprcs_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.sf_prcss_key).HasColumnName("sf_prcss_key");
            this.Property(t => t.sf_prcss_ver).HasColumnName("sf_prcss_ver");
            this.Property(t => t.sf_frmla_effdt).HasColumnName("sf_frmla_effdt");
            this.Property(t => t.sf_frmla_inadt).HasColumnName("sf_frmla_inadt");
            this.Property(t => t.sf_ptprcs_alflg).HasColumnName("sf_ptprcs_alflg");
            this.Property(t => t.sf_ptprcs_defqty).HasColumnName("sf_ptprcs_defqty");
            this.Property(t => t.sf_ptprcs_upcnt).HasColumnName("sf_ptprcs_upcnt");
        }
    }
}
