using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_lotst_tblMap : EntityTypeConfiguration<en_lotst_tbl>
    {
        public en_lotst_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_item_key, t.en_lot_key, t.en_itqsp_key, t.en_itqsp_effdt, t.im_pack_key });

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.en_itqsp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_lotst_text)
                .HasMaxLength(30);

            this.Property(t => t.en_sppck_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_lotst_aprby)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("en_lotst_tbl");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.en_lot_key).HasColumnName("en_lot_key");
            this.Property(t => t.en_itqsp_key).HasColumnName("en_itqsp_key");
            this.Property(t => t.en_itqsp_effdt).HasColumnName("en_itqsp_effdt");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_lotst_stats).HasColumnName("en_lotst_stats");
            this.Property(t => t.en_lotst_aprdt).HasColumnName("en_lotst_aprdt");
            this.Property(t => t.en_lotst_rejdt).HasColumnName("en_lotst_rejdt");
            this.Property(t => t.en_lotst_text).HasColumnName("en_lotst_text");
            this.Property(t => t.en_sppck_key).HasColumnName("en_sppck_key");
            this.Property(t => t.en_lotst_aprby).HasColumnName("en_lotst_aprby");
            this.Property(t => t.en_lotst_upcnt).HasColumnName("en_lotst_upcnt");
        }
    }
}
