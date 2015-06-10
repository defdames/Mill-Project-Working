using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_spritm_tblMap : EntityTypeConfiguration<en_spritm_tbl>
    {
        public en_spritm_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_spritm_key);

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_spritm_key)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_planfam_key)
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_spritm_tbl");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_spritm_key).HasColumnName("en_spritm_key");
            this.Property(t => t.en_spritm_type).HasColumnName("en_spritm_type");
            this.Property(t => t.en_spritm_advplnf).HasColumnName("en_spritm_advplnf");
            this.Property(t => t.en_spritm_advschf).HasColumnName("en_spritm_advschf");
            this.Property(t => t.en_planfam_key).HasColumnName("en_planfam_key");
            this.Property(t => t.en_spritm_crtdt).HasColumnName("en_spritm_crtdt");
            this.Property(t => t.en_spritm_chgdt).HasColumnName("en_spritm_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_spritm_upcnt).HasColumnName("en_spritm_upcnt");
        }
    }
}
