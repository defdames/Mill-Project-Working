using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_Detail_General_LedgerMap : EntityTypeConfiguration<CHINA_Detail_General_Ledger>
    {
        public CHINA_Detail_General_LedgerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_perod_id, t.gl_perod_year, t.gl_acct_key, t.GlTranDesc, t.GlDbcrFlag, t.gl_acct_desc, t.gl_pdbal_open, t.gl_tran_ref2, t.gl_tran_applc, t.gl_tran_ref1, t.gl_cmp_key });

            // Properties
            this.Property(t => t.gl_perod_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.GlTranDesc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.GlDbcrFlag)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_acct_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_tran_ref2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_tran_applc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_tran_ref1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Vendor)
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_Detail_General_Ledger");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.GlTranKey).HasColumnName("GlTranKey");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.GlTranDate).HasColumnName("GlTranDate");
            this.Property(t => t.GlTranDesc).HasColumnName("GlTranDesc");
            this.Property(t => t.TranAmt).HasColumnName("TranAmt");
            this.Property(t => t.GlDbcrFlag).HasColumnName("GlDbcrFlag");
            this.Property(t => t.gl_acct_desc).HasColumnName("gl_acct_desc");
            this.Property(t => t.gl_pdbal_open).HasColumnName("gl_pdbal_open");
            this.Property(t => t.gl_tran_ref2).HasColumnName("gl_tran_ref2");
            this.Property(t => t.gl_tran_applc).HasColumnName("gl_tran_applc");
            this.Property(t => t.gl_tran_ref1).HasColumnName("gl_tran_ref1");
            this.Property(t => t.Vendor).HasColumnName("Vendor");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
