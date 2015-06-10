using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_tran_tblMap : EntityTypeConfiguration<gl_tran_tbl>
    {
        public gl_tran_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.gl_tran_pk);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_tran_ref1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_tran_ref2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_tran_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_tran_applc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_tran_pk)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("gl_tran_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_tran_key).HasColumnName("gl_tran_key");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.gl_tran_date).HasColumnName("gl_tran_date");
            this.Property(t => t.gl_tran_qty).HasColumnName("gl_tran_qty");
            this.Property(t => t.gl_tran_ref1).HasColumnName("gl_tran_ref1");
            this.Property(t => t.gl_tran_ref2).HasColumnName("gl_tran_ref2");
            this.Property(t => t.gl_tran_desc).HasColumnName("gl_tran_desc");
            this.Property(t => t.gl_tran_applc).HasColumnName("gl_tran_applc");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.sa_frame_id).HasColumnName("sa_frame_id");
            this.Property(t => t.sa_term_id).HasColumnName("sa_term_id");
            this.Property(t => t.gl_tran_crtdt).HasColumnName("gl_tran_crtdt");
            this.Property(t => t.gl_tran_chgdt).HasColumnName("gl_tran_chgdt");
            this.Property(t => t.gl_tran_upcnt).HasColumnName("gl_tran_upcnt");
            this.Property(t => t.gl_perod_seqno).HasColumnName("gl_perod_seqno");
            this.Property(t => t.gl_tran_subcrtdt).HasColumnName("gl_tran_subcrtdt");
            this.Property(t => t.gl_tran_dbamtc).HasColumnName("gl_tran_dbamtc");
            this.Property(t => t.gl_tran_cramtc).HasColumnName("gl_tran_cramtc");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.gl_bkcd_jnum).HasColumnName("gl_bkcd_jnum");
            this.Property(t => t.gl_tran_pk).HasColumnName("gl_tran_pk");
        }
    }
}
