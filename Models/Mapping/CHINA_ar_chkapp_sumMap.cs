using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_ar_chkapp_sumMap : EntityTypeConfiguration<CHINA_ar_chkapp_sum>
    {
        public CHINA_ar_chkapp_sumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ar_dbcrm_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_dbcrm_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CHINA_ar_chkapp_sum");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ar_dbcrm_key).HasColumnName("ar_dbcrm_key");
            this.Property(t => t.CheckappAmt).HasColumnName("CheckappAmt");
            this.Property(t => t.CheckappAmtf).HasColumnName("CheckappAmtf");
        }
    }
}
