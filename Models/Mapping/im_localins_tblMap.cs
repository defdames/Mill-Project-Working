using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_localins_tblMap : EntityTypeConfiguration<im_localins_tbl>
    {
        public im_localins_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.im_localins_key);

            // Properties
            this.Property(t => t.im_insmst_extfile)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("im_localins_tbl");
            this.Property(t => t.im_localins_key).HasColumnName("im_localins_key");
            this.Property(t => t.im_instp_key).HasColumnName("im_instp_key");
            this.Property(t => t.im_prpmst_key).HasColumnName("im_prpmst_key");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.im_localins_flag).HasColumnName("im_localins_flag");
            this.Property(t => t.im_cppmst_key).HasColumnName("im_cppmst_key");
            this.Property(t => t.im_insmst_extfile).HasColumnName("im_insmst_extfile");
            this.Property(t => t.im_insmst_effdt).HasColumnName("im_insmst_effdt");
            this.Property(t => t.im_insmst_inadt).HasColumnName("im_insmst_inadt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.im_localins_chgdt).HasColumnName("im_localins_chgdt");
            this.Property(t => t.im_localins_upcnt).HasColumnName("im_localins_upcnt");
        }
    }
}
