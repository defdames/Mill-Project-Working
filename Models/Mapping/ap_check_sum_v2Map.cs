using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_check_sum_v2Map : EntityTypeConfiguration<ap_check_sum_v2>
    {
        public ap_check_sum_v2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.CheckNo, t.gl_cmp_key });

            // Properties
            this.Property(t => t.CheckNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorId)
                .HasMaxLength(10);

            this.Property(t => t.RemitId)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ap_check_sum_v2");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.RemitId).HasColumnName("RemitId");
            this.Property(t => t.RemitAdr).HasColumnName("RemitAdr");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
