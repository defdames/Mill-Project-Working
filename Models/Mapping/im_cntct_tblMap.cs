using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_cntct_tblMap : EntityTypeConfiguration<im_cntct_tbl>
    {
        public im_cntct_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.im_cntct_key);

            // Properties
            this.Property(t => t.im_cntct_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_cntct_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_cntct_title)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_cntct_phone)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.im_cntct_fax)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.im_cntct_moble)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.im_cntct_telex)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.im_cntct_text)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.im_cntct_itnet)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("im_cntct_tbl");
            this.Property(t => t.im_cntct_key).HasColumnName("im_cntct_key");
            this.Property(t => t.im_cntct_name).HasColumnName("im_cntct_name");
            this.Property(t => t.im_cntct_title).HasColumnName("im_cntct_title");
            this.Property(t => t.im_cntct_phone).HasColumnName("im_cntct_phone");
            this.Property(t => t.im_cntct_fax).HasColumnName("im_cntct_fax");
            this.Property(t => t.im_cntct_moble).HasColumnName("im_cntct_moble");
            this.Property(t => t.im_cntct_telex).HasColumnName("im_cntct_telex");
            this.Property(t => t.im_cntct_text).HasColumnName("im_cntct_text");
            this.Property(t => t.im_cntct_crtdt).HasColumnName("im_cntct_crtdt");
            this.Property(t => t.im_cntct_chgdt).HasColumnName("im_cntct_chgdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.im_cntct_upcnt).HasColumnName("im_cntct_upcnt");
            this.Property(t => t.im_cntct_itnet).HasColumnName("im_cntct_itnet");
        }
    }
}
