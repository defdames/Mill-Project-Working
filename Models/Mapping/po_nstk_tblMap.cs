using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_nstk_tblMap : EntityTypeConfiguration<po_nstk_tbl>
    {
        public po_nstk_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_nstk_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_nstk_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_key)
                .HasMaxLength(2);

            this.Property(t => t.po_nstk_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.po_nstk_acct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.en_1099_key)
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("po_nstk_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_nstk_key).HasColumnName("po_nstk_key");
            this.Property(t => t.en_uom_key).HasColumnName("en_uom_key");
            this.Property(t => t.po_nstk_desc).HasColumnName("po_nstk_desc");
            this.Property(t => t.po_nstk_acct).HasColumnName("po_nstk_acct");
            this.Property(t => t.po_nstk_upcnt).HasColumnName("po_nstk_upcnt");
            this.Property(t => t.en_1099_key).HasColumnName("en_1099_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.po_nstk_apprf).HasColumnName("po_nstk_apprf");
            this.Property(t => t.po_nstk_eamf).HasColumnName("po_nstk_eamf");
            this.Property(t => t.po_nstk_servicef).HasColumnName("po_nstk_servicef");
        }
    }
}
