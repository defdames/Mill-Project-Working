using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_bilcn_tblMap : EntityTypeConfiguration<en_bilcn_tbl>
    {
        public en_bilcn_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_bill_key, t.im_contp_key, t.im_cntct_key });

            // Properties
            this.Property(t => t.en_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_contp_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_cntct_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_bilcn_tbl");
            this.Property(t => t.en_bill_key).HasColumnName("en_bill_key");
            this.Property(t => t.im_contp_key).HasColumnName("im_contp_key");
            this.Property(t => t.im_cntct_key).HasColumnName("im_cntct_key");
            this.Property(t => t.en_bilcn_upcnt).HasColumnName("en_bilcn_upcnt");
            this.Property(t => t.en_bilcn_crtdt).HasColumnName("en_bilcn_crtdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_bilcn_chgdt).HasColumnName("en_bilcn_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
