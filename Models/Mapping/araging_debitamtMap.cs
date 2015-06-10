using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class araging_debitamtMap : EntityTypeConfiguration<araging_debitamt>
    {
        public araging_debitamtMap()
        {
            // Primary Key
            this.HasKey(t => new { t.invkey, t.gl_cmp_key, t.ar_dbcrm_stats });

            // Properties
            this.Property(t => t.invkey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_dbcrm_stats)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("araging_debitamt");
            this.Property(t => t.invkey).HasColumnName("invkey");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_dbcrm_stats).HasColumnName("ar_dbcrm_stats");
            this.Property(t => t.debitamt).HasColumnName("debitamt");
            this.Property(t => t.debitamtf).HasColumnName("debitamtf");
        }
    }
}
