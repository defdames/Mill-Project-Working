using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_frmla_insMap : EntityTypeConfiguration<en_frmla_ins>
    {
        public en_frmla_insMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_frmla_key, t.en_frmla_ver, t.im_insmst_key });

            // Properties
            this.Property(t => t.en_frmla_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_frmla_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.im_insmst_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("en_frmla_ins");
            this.Property(t => t.en_frmla_key).HasColumnName("en_frmla_key");
            this.Property(t => t.en_frmla_ver).HasColumnName("en_frmla_ver");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.im_insmst_joindt).HasColumnName("im_insmst_joindt");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
        }
    }
}
