using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_stock_tblMap : EntityTypeConfiguration<in_stock_tbl>
    {
        public in_stock_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_item_key, t.in_locn_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("in_stock_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.in_locn_issdt).HasColumnName("in_locn_issdt");
            this.Property(t => t.in_locn_recdt).HasColumnName("in_locn_recdt");
            this.Property(t => t.in_stock_cycdt).HasColumnName("in_stock_cycdt");
            this.Property(t => t.in_locn_tagdt).HasColumnName("in_locn_tagdt");
            this.Property(t => t.in_stock_lctqt).HasColumnName("in_stock_lctqt");
            this.Property(t => t.in_stock_lcycn).HasColumnName("in_stock_lcycn");
            this.Property(t => t.in_cycno_key).HasColumnName("in_cycno_key");
            this.Property(t => t.in_locn_qoh).HasColumnName("in_locn_qoh");
            this.Property(t => t.in_stock_upcnt).HasColumnName("in_stock_upcnt");
            this.Property(t => t.in_stock_sysdt).HasColumnName("in_stock_sysdt");
            this.Property(t => t.in_stock_pkrsv).HasColumnName("in_stock_pkrsv");
            this.Property(t => t.in_stock_aqoh).HasColumnName("in_stock_aqoh");
        }
    }
}
