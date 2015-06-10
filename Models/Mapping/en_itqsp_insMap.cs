using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_itqsp_insMap : EntityTypeConfiguration<en_itqsp_ins>
    {
        public en_itqsp_insMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_item_key, t.im_pack_key, t.en_itqsp_key, t.en_itqsp_effdt, t.im_insmst_key });

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

            this.Property(t => t.im_insmst_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_itqsp_ins");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_itqsp_key).HasColumnName("en_itqsp_key");
            this.Property(t => t.en_itqsp_effdt).HasColumnName("en_itqsp_effdt");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.im_insmst_joindt).HasColumnName("im_insmst_joindt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
