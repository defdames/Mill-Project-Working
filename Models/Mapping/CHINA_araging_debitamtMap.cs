using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_araging_debitamtMap : EntityTypeConfiguration<CHINA_araging_debitamt>
    {
        public CHINA_araging_debitamtMap()
        {
            // Primary Key
            this.HasKey(t => new { t.InvKey, t.gl_cmp_key, t.ar_dbcrm_stats });

            // Properties
            this.Property(t => t.InvKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_dbcrm_stats)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CHINA_araging_debitamt");
            this.Property(t => t.InvKey).HasColumnName("InvKey");
            this.Property(t => t.DebitAmt).HasColumnName("DebitAmt");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_dbcrm_stats).HasColumnName("ar_dbcrm_stats");
            this.Property(t => t.DebitAmtf).HasColumnName("DebitAmtf");
        }
    }
}
