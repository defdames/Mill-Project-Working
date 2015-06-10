using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_in_lotpk_tbl_sap_countertypeMap : EntityTypeConfiguration<CHINA_in_lotpk_tbl_sap_countertype>
    {
        public CHINA_in_lotpk_tbl_sap_countertypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_whs_key, t.en_prod_key, t.in_lot_key, t.in_lot_qoh });

            // Properties
            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .HasMaxLength(6);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("CHINA_in_lotpk_tbl_sap_countertype");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_lot_qoh).HasColumnName("in_lot_qoh");
        }
    }
}
