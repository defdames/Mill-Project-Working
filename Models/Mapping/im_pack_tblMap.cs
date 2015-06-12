using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_pack_tblMap : EntityTypeConfiguration<im_pack_tbl>
    {
        public im_pack_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.im_pack_key);

            // Properties
            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.im_pack_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.im_pack_duom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_pack_trpc)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_stat)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_pack_trpg)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_type)
                .HasMaxLength(10);

            this.Property(t => t.im_pack_uid)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.im_pack_unpc)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_pack_vluom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_pack_wuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_pack_com)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.im_siobj_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("im_pack_tbl");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.im_pack_upcnt).HasColumnName("im_pack_upcnt");
            this.Property(t => t.im_pack_chgdt).HasColumnName("im_pack_chgdt");
            this.Property(t => t.im_pack_desc).HasColumnName("im_pack_desc");
            this.Property(t => t.im_pack_dpth).HasColumnName("im_pack_dpth");
            this.Property(t => t.im_pack_duom).HasColumnName("im_pack_duom");
            this.Property(t => t.im_pack_hght).HasColumnName("im_pack_hght");
            this.Property(t => t.im_pack_trpc).HasColumnName("im_pack_trpc");
            this.Property(t => t.im_pack_qty).HasColumnName("im_pack_qty");
            this.Property(t => t.im_pack_stat).HasColumnName("im_pack_stat");
            this.Property(t => t.im_pack_tare).HasColumnName("im_pack_tare");
            this.Property(t => t.im_pack_trpg).HasColumnName("im_pack_trpg");
            this.Property(t => t.im_pack_type).HasColumnName("im_pack_type");
            this.Property(t => t.im_pack_uid).HasColumnName("im_pack_uid");
            this.Property(t => t.im_pack_unpc).HasColumnName("im_pack_unpc");
            this.Property(t => t.im_pack_uom).HasColumnName("im_pack_uom");
            this.Property(t => t.im_pack_vluom).HasColumnName("im_pack_vluom");
            this.Property(t => t.im_pack_vol).HasColumnName("im_pack_vol");
            this.Property(t => t.im_pack_wdth).HasColumnName("im_pack_wdth");
            this.Property(t => t.im_pack_wuom).HasColumnName("im_pack_wuom");
            this.Property(t => t.im_pack_com).HasColumnName("im_pack_com");
            this.Property(t => t.im_siobj_key).HasColumnName("im_siobj_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.im_pack_crtdt).HasColumnName("im_pack_crtdt");
            this.Property(t => t.im_pack_ovrfilqty).HasColumnName("im_pack_ovrfilqty");
        }
    }
}
