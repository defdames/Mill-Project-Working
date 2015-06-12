using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_check_sum_v4Map : EntityTypeConfiguration<ap_check_sum_v4>
    {
        public ap_check_sum_v4Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ap_chek_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.ap_chek_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ap_check_sum_v4");
            this.Property(t => t.ap_chek_key).HasColumnName("ap_chek_key");
            this.Property(t => t.sumnet).HasColumnName("sumnet");
            this.Property(t => t.sumdisc).HasColumnName("sumdisc");
            this.Property(t => t.sumgross).HasColumnName("sumgross");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
