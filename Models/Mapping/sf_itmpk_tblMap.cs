using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_itmpk_tblMap : EntityTypeConfiguration<sf_itmpk_tbl>
    {
        public sf_itmpk_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.in_item_key, t.im_pack_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.sf_asprdgrp_key)
                .HasMaxLength(10);

            this.Property(t => t.in_spritm_asprd)
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("sf_itmpk_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.sf_itmpk_advplnf).HasColumnName("sf_itmpk_advplnf");
            this.Property(t => t.sf_itmpk_advschf).HasColumnName("sf_itmpk_advschf");
            this.Property(t => t.sf_itmpk_type).HasColumnName("sf_itmpk_type");
            this.Property(t => t.sf_asprdgrp_key).HasColumnName("sf_asprdgrp_key");
            this.Property(t => t.sf_itmpk_prdschf).HasColumnName("sf_itmpk_prdschf");
            this.Property(t => t.in_spritm_asprd).HasColumnName("in_spritm_asprd");
            this.Property(t => t.sf_itmpk_asdlvrf).HasColumnName("sf_itmpk_asdlvrf");
            this.Property(t => t.sf_itmpk_crtdt).HasColumnName("sf_itmpk_crtdt");
            this.Property(t => t.sf_itmpk_chgdt).HasColumnName("sf_itmpk_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.sf_itmpk_upcnt).HasColumnName("sf_itmpk_upcnt");
        }
    }
}
