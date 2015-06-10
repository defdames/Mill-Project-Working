using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_vpbrk_tblMap : EntityTypeConfiguration<in_vpbrk_tbl>
    {
        public in_vpbrk_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.in_vpbrk_key);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .HasMaxLength(4);

            this.Property(t => t.in_whs_key)
                .HasMaxLength(4);

            this.Property(t => t.ap_delfm_key)
                .HasMaxLength(10);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_vpbrk_cmnts)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_uom_pruom)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("in_vpbrk_tbl");
            this.Property(t => t.in_vpbrk_key).HasColumnName("in_vpbrk_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_vpbrk_effdt).HasColumnName("in_vpbrk_effdt");
            this.Property(t => t.in_vpbrk_bklvl).HasColumnName("in_vpbrk_bklvl");
            this.Property(t => t.in_vpbrk_inadt).HasColumnName("in_vpbrk_inadt");
            this.Property(t => t.in_vpbrk_bkflg).HasColumnName("in_vpbrk_bkflg");
            this.Property(t => t.in_vpbrk_quote).HasColumnName("in_vpbrk_quote");
            this.Property(t => t.in_vpbrk_disc).HasColumnName("in_vpbrk_disc");
            this.Property(t => t.in_vpbrk_discc).HasColumnName("in_vpbrk_discc");
            this.Property(t => t.in_vpbrk_lqtdt).HasColumnName("in_vpbrk_lqtdt");
            this.Property(t => t.in_vpbrk_cmnts).HasColumnName("in_vpbrk_cmnts");
            this.Property(t => t.en_uom_pruom).HasColumnName("en_uom_pruom");
            this.Property(t => t.in_vpbrk_upcnt).HasColumnName("in_vpbrk_upcnt");
            this.Property(t => t.in_vpbrk_type).HasColumnName("in_vpbrk_type");
        }
    }
}
