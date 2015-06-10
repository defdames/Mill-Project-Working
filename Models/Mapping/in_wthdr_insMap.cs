using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_wthdr_insMap : EntityTypeConfiguration<in_wthdr_ins>
    {
        public in_wthdr_insMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_wthdr_towhs, t.in_wthdr_key, t.im_insmst_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_wthdr_towhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_wthdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_insmst_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("in_wthdr_ins");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_wthdr_towhs).HasColumnName("in_wthdr_towhs");
            this.Property(t => t.in_wthdr_key).HasColumnName("in_wthdr_key");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.im_insmst_joindt).HasColumnName("im_insmst_joindt");
        }
    }
}
