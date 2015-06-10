using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_ptlot_tblMap : EntityTypeConfiguration<en_ptlot_tbl>
    {
        public en_ptlot_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_ptsublot_key);

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.en_itqsp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_ptlot_tbl");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_lot_key).HasColumnName("en_lot_key");
            this.Property(t => t.en_itqsp_key).HasColumnName("en_itqsp_key");
            this.Property(t => t.en_itqsp_effdt).HasColumnName("en_itqsp_effdt");
            this.Property(t => t.en_ptlot_crtdt).HasColumnName("en_ptlot_crtdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_ptlot_upcnt).HasColumnName("en_ptlot_upcnt");
            this.Property(t => t.en_ptsublot_key).HasColumnName("en_ptsublot_key");
        }
    }
}
