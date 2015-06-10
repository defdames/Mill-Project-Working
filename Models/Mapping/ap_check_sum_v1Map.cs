using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_check_sum_v1Map : EntityTypeConfiguration<ap_check_sum_v1>
    {
        public ap_check_sum_v1Map()
        {
            // Primary Key
            this.HasKey(t => t.gl_cmp_key);

            // Properties
            this.Property(t => t.CheckNo)
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ap_check_sum_v1");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.CheckAmt).HasColumnName("CheckAmt");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
