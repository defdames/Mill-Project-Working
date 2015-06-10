using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_cntrhdr_tblMap : EntityTypeConfiguration<in_cntrhdr_tbl>
    {
        public in_cntrhdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.en_pkgtyp_key, t.en_mfrid_key, t.in_cntrhdr_srlno, t.in_cntrhdr_ckdgt });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_pkgtyp_key)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_mfrid_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_cntrhdr_srlno)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.in_cntrhdr_ckdgt)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_cntrhdr_id)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.in_cntrhdr_trkno)
                .HasMaxLength(20);

            this.Property(t => t.in_cntrhdr_refno)
                .HasMaxLength(20);

            this.Property(t => t.en_uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_load_key)
                .HasMaxLength(35);

            this.Property(t => t.en_pkgtyp_ptkey)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_mfrid_ptkey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_cntrhdr_ptsrlno)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.in_cntrhdr_ptckdgt)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("in_cntrhdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.en_pkgtyp_key).HasColumnName("en_pkgtyp_key");
            this.Property(t => t.en_mfrid_key).HasColumnName("en_mfrid_key");
            this.Property(t => t.in_cntrhdr_srlno).HasColumnName("in_cntrhdr_srlno");
            this.Property(t => t.in_cntrhdr_ckdgt).HasColumnName("in_cntrhdr_ckdgt");
            this.Property(t => t.in_cntrhdr_id).HasColumnName("in_cntrhdr_id");
            this.Property(t => t.in_cntrhdr_status).HasColumnName("in_cntrhdr_status");
            this.Property(t => t.in_cntrhdr_trkno).HasColumnName("in_cntrhdr_trkno");
            this.Property(t => t.in_cntrhdr_refno).HasColumnName("in_cntrhdr_refno");
            this.Property(t => t.en_uom_key).HasColumnName("en_uom_key");
            this.Property(t => t.in_cntrhdr_return).HasColumnName("in_cntrhdr_return");
            this.Property(t => t.so_load_key).HasColumnName("so_load_key");
            this.Property(t => t.in_cntrhdr_upcnt).HasColumnName("in_cntrhdr_upcnt");
            this.Property(t => t.en_pkgtyp_ptkey).HasColumnName("en_pkgtyp_ptkey");
            this.Property(t => t.en_mfrid_ptkey).HasColumnName("en_mfrid_ptkey");
            this.Property(t => t.in_cntrhdr_ptsrlno).HasColumnName("in_cntrhdr_ptsrlno");
            this.Property(t => t.in_cntrhdr_ptckdgt).HasColumnName("in_cntrhdr_ptckdgt");
        }
    }
}
