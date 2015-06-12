using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_pdbal_tblMap : EntityTypeConfiguration<gl_pdbal_tbl>
    {
        public gl_pdbal_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_acct_key, t.gl_perod_seqno });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_perod_seqno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("gl_pdbal_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.gl_pdbal_open).HasColumnName("gl_pdbal_open");
            this.Property(t => t.gl_pdbal_dbamtc).HasColumnName("gl_pdbal_dbamtc");
            this.Property(t => t.gl_pdbal_upcnt).HasColumnName("gl_pdbal_upcnt");
            this.Property(t => t.gl_perod_seqno).HasColumnName("gl_perod_seqno");
            this.Property(t => t.gl_pdbal_cramtc).HasColumnName("gl_pdbal_cramtc");
        }
    }
}
