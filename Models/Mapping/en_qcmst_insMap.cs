using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_qcmst_insMap : EntityTypeConfiguration<en_qcmst_ins>
    {
        public en_qcmst_insMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_qcmst_key, t.en_qcmst_effdt, t.im_insmst_key });

            // Properties
            this.Property(t => t.en_qcmst_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_insmst_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sa_user_key)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_qcmst_ins");
            this.Property(t => t.en_qcmst_key).HasColumnName("en_qcmst_key");
            this.Property(t => t.en_qcmst_effdt).HasColumnName("en_qcmst_effdt");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.im_insmst_joindt).HasColumnName("im_insmst_joindt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
