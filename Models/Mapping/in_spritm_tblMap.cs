using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_spritm_tblMap : EntityTypeConfiguration<in_spritm_tbl>
    {
        public in_spritm_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_spritm_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_spritm_key)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_planfam_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("in_spritm_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_spritm_key).HasColumnName("in_spritm_key");
            this.Property(t => t.in_spritm_type).HasColumnName("in_spritm_type");
            this.Property(t => t.in_spritm_crtdt).HasColumnName("in_spritm_crtdt");
            this.Property(t => t.in_spritm_chgdt).HasColumnName("in_spritm_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_spritm_upcnt).HasColumnName("in_spritm_upcnt");
            this.Property(t => t.in_spritm_advplnf).HasColumnName("in_spritm_advplnf");
            this.Property(t => t.in_spritm_advschf).HasColumnName("in_spritm_advschf");
            this.Property(t => t.en_planfam_key).HasColumnName("en_planfam_key");
        }
    }
}
