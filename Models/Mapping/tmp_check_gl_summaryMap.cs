using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_check_gl_summaryMap : EntityTypeConfiguration<tmp_check_gl_summary>
    {
        public tmp_check_gl_summaryMap()
        {
            // Primary Key
            this.HasKey(t => t.sectionpart);

            // Properties
            this.Property(t => t.gl_acct_key)
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_desc)
                .HasMaxLength(30);

            this.Property(t => t.ap_vchr_key)
                .HasMaxLength(10);

            this.Property(t => t.sectionpart)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Chk_num)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("tmp_check_gl_summary");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.gl_acct_desc).HasColumnName("gl_acct_desc");
            this.Property(t => t.check_amount).HasColumnName("check_amount");
            this.Property(t => t.ap_vchr_key).HasColumnName("ap_vchr_key");
            this.Property(t => t.varianceamt).HasColumnName("varianceamt");
            this.Property(t => t.po_dtlrc_qty).HasColumnName("po_dtlrc_qty");
            this.Property(t => t.ap_vcdtl_invqt).HasColumnName("ap_vcdtl_invqt");
            this.Property(t => t.sectionpart).HasColumnName("sectionpart");
            this.Property(t => t.ap_vchr_tdscc).HasColumnName("ap_vchr_tdscc");
            this.Property(t => t.ap_vcdtl_line).HasColumnName("ap_vcdtl_line");
            this.Property(t => t.net_amt).HasColumnName("net_amt");
            this.Property(t => t.Chk_num).HasColumnName("Chk_num");
        }
    }
}
