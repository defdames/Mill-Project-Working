using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_locn_tblMap : EntityTypeConfiguration<in_locn_tbl>
    {
        public in_locn_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_locn_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_locn_rmt)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_locn_nettf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_locn_type)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_shelf_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.in_locn_desc)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("in_locn_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.in_locn_upcnt).HasColumnName("in_locn_upcnt");
            this.Property(t => t.in_locn_rmt).HasColumnName("in_locn_rmt");
            this.Property(t => t.in_locn_nettf).HasColumnName("in_locn_nettf");
            this.Property(t => t.in_locn_type).HasColumnName("in_locn_type");
            this.Property(t => t.in_shelf_wdth).HasColumnName("in_shelf_wdth");
            this.Property(t => t.in_shelf_dpth).HasColumnName("in_shelf_dpth");
            this.Property(t => t.in_shelf_hgth).HasColumnName("in_shelf_hgth");
            this.Property(t => t.in_shelf_ucap).HasColumnName("in_shelf_ucap");
            this.Property(t => t.in_shelf_uom).HasColumnName("in_shelf_uom");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_locn_chgdt).HasColumnName("in_locn_chgdt");
            this.Property(t => t.in_locn_crtdt).HasColumnName("in_locn_crtdt");
            this.Property(t => t.in_locn_desc).HasColumnName("in_locn_desc");
            this.Property(t => t.in_locn_advschf).HasColumnName("in_locn_advschf");
            this.Property(t => t.in_locn_autoblendf).HasColumnName("in_locn_autoblendf");
        }
    }
}
