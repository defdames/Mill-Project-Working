using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_remt_insMap : EntityTypeConfiguration<en_remt_ins>
    {
        public en_remt_insMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_remt_key, t.im_insmst_key });

            // Properties
            this.Property(t => t.en_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_insmst_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sa_user_key)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_remt_ins");
            this.Property(t => t.en_remt_key).HasColumnName("en_remt_key");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.im_insmst_joindt).HasColumnName("im_insmst_joindt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
