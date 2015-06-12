using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_itqsp_tblMap : EntityTypeConfiguration<en_itqsp_tbl>
    {
        public en_itqsp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_item_key, t.im_pack_key, t.en_itqsp_key, t.en_itqsp_effdt });

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_itqsp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_itqsp_spctp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_itqsp_finsf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_itqsp_cmnts)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_itqsp_desc)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("en_itqsp_tbl");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_itqsp_key).HasColumnName("en_itqsp_key");
            this.Property(t => t.en_itqsp_effdt).HasColumnName("en_itqsp_effdt");
            this.Property(t => t.en_itqsp_spctp).HasColumnName("en_itqsp_spctp");
            this.Property(t => t.en_itqsp_inadt).HasColumnName("en_itqsp_inadt");
            this.Property(t => t.en_itqsp_finsf).HasColumnName("en_itqsp_finsf");
            this.Property(t => t.en_itqsp_cmnts).HasColumnName("en_itqsp_cmnts");
            this.Property(t => t.en_itqsp_crtdt).HasColumnName("en_itqsp_crtdt");
            this.Property(t => t.en_itqsp_chgdt).HasColumnName("en_itqsp_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_itqsp_upcnt).HasColumnName("en_itqsp_upcnt");
            this.Property(t => t.en_itqsp_desc).HasColumnName("en_itqsp_desc");
            this.Property(t => t.en_itqsp_autof).HasColumnName("en_itqsp_autof");
        }
    }
}
