using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class china_delivery_note_spj_lotdetailMap : EntityTypeConfiguration<china_delivery_note_spj_lotdetail>
    {
        public china_delivery_note_spj_lotdetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_dtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_load_key)
                .HasMaxLength(35);

            this.Property(t => t.so_hdr_key)
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_lot_key)
                .HasMaxLength(25);

            this.Property(t => t.countryoforigin)
                .HasMaxLength(20);

            this.Property(t => t.ar_ship_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("china_delivery_note_spj_lotdetail");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_load_key).HasColumnName("so_load_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.ShpQty).HasColumnName("ShpQty");
            this.Property(t => t.countryoforigin).HasColumnName("countryoforigin");
            this.Property(t => t.en_lot_mfgdt).HasColumnName("en_lot_mfgdt");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
        }
    }
}
