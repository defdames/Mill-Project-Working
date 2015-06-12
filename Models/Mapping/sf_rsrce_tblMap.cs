using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_rsrce_tblMap : EntityTypeConfiguration<sf_rsrce_tbl>
    {
        public sf_rsrce_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_rsrce_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_rsrce_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_rsrce_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sf_rsrce_dept)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_rsrce_locid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("sf_rsrce_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_rsrce_key).HasColumnName("sf_rsrce_key");
            this.Property(t => t.sf_rsrce_type).HasColumnName("sf_rsrce_type");
            this.Property(t => t.sf_rsrce_desc).HasColumnName("sf_rsrce_desc");
            this.Property(t => t.sf_rsrce_dept).HasColumnName("sf_rsrce_dept");
            this.Property(t => t.sf_rsrce_units).HasColumnName("sf_rsrce_units");
            this.Property(t => t.sf_rsrce_dycap).HasColumnName("sf_rsrce_dycap");
            this.Property(t => t.sf_rsrce_yrcap).HasColumnName("sf_rsrce_yrcap");
            this.Property(t => t.sf_rsrce_sdirc).HasColumnName("sf_rsrce_sdirc");
            this.Property(t => t.sf_rsrce_sovhf).HasColumnName("sf_rsrce_sovhf");
            this.Property(t => t.sf_rsrce_sovhc).HasColumnName("sf_rsrce_sovhc");
            this.Property(t => t.sf_rsrce_pdirc).HasColumnName("sf_rsrce_pdirc");
            this.Property(t => t.sf_rsrce_povhf).HasColumnName("sf_rsrce_povhf");
            this.Property(t => t.sf_rsrce_povhc).HasColumnName("sf_rsrce_povhc");
            this.Property(t => t.sf_rsrce_effdt).HasColumnName("sf_rsrce_effdt");
            this.Property(t => t.sf_rsrce_inadt).HasColumnName("sf_rsrce_inadt");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.sf_rsrce_locid).HasColumnName("sf_rsrce_locid");
            this.Property(t => t.sf_rsrce_bkflshf).HasColumnName("sf_rsrce_bkflshf");
            this.Property(t => t.sf_rsrce_advschf).HasColumnName("sf_rsrce_advschf");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.sf_rsrce_crtdt).HasColumnName("sf_rsrce_crtdt");
            this.Property(t => t.sf_rsrce_chgdt).HasColumnName("sf_rsrce_chgdt");
            this.Property(t => t.sf_rsrce_upcnt).HasColumnName("sf_rsrce_upcnt");
        }
    }
}
