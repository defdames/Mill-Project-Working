using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_srl_tblMap : EntityTypeConfiguration<in_srl_tbl>
    {
        public in_srl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_locn_key, t.in_item_key, t.in_lot_key });

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

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("in_srl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_srl_cycdt).HasColumnName("in_srl_cycdt");
            this.Property(t => t.in_srl_lctqt).HasColumnName("in_srl_lctqt");
            this.Property(t => t.in_srl_lcycn).HasColumnName("in_srl_lcycn");
            this.Property(t => t.in_cycno_key).HasColumnName("in_cycno_key");
            this.Property(t => t.in_srl_qoh).HasColumnName("in_srl_qoh");
            this.Property(t => t.in_srl_costc).HasColumnName("in_srl_costc");
            this.Property(t => t.in_srl_upcnt).HasColumnName("in_srl_upcnt");
            this.Property(t => t.in_srl_issdt).HasColumnName("in_srl_issdt");
            this.Property(t => t.in_srl_recdt).HasColumnName("in_srl_recdt");
            this.Property(t => t.in_srl_sysdt).HasColumnName("in_srl_sysdt");
            this.Property(t => t.in_srl_pkrsv).HasColumnName("in_srl_pkrsv");
            this.Property(t => t.in_srl_aqoh).HasColumnName("in_srl_aqoh");
        }
    }
}
