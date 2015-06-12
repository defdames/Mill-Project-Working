using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_bgdtl_tblMap : EntityTypeConfiguration<gl_bgdtl_tbl>
    {
        public gl_bgdtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_bdgt_id, t.gl_perod_seqno, t.gl_acct_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_bdgt_id)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.gl_perod_seqno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_bgdtl_ref1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_bgdtl_ref2)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("gl_bgdtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_bdgt_id).HasColumnName("gl_bdgt_id");
            this.Property(t => t.gl_perod_seqno).HasColumnName("gl_perod_seqno");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.gl_bgdtl_ref1).HasColumnName("gl_bgdtl_ref1");
            this.Property(t => t.gl_bgdtl_ref2).HasColumnName("gl_bgdtl_ref2");
            this.Property(t => t.gl_bdgt_amt).HasColumnName("gl_bdgt_amt");
            this.Property(t => t.gl_bdgt_prcnt).HasColumnName("gl_bdgt_prcnt");
            this.Property(t => t.gl_bgdtl_upcnt).HasColumnName("gl_bgdtl_upcnt");
        }
    }
}
