using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_acct_tblMap : EntityTypeConfiguration<gl_acct_tbl>
    {
        public gl_acct_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_acct_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.gl_class_key)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.gl_class_key2)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.gl_class_key3)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.gl_class_key4)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.gl_class_key5)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.gl_type_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_acct_dbcrf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_acct_cntra_acct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_cntrl_acct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_bdgtwt_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_acct_glonly)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_locacct_sgid)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("gl_acct_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.gl_acct_desc).HasColumnName("gl_acct_desc");
            this.Property(t => t.gl_class_key).HasColumnName("gl_class_key");
            this.Property(t => t.gl_class_key2).HasColumnName("gl_class_key2");
            this.Property(t => t.gl_class_key3).HasColumnName("gl_class_key3");
            this.Property(t => t.gl_class_key4).HasColumnName("gl_class_key4");
            this.Property(t => t.gl_class_key5).HasColumnName("gl_class_key5");
            this.Property(t => t.gl_type_key).HasColumnName("gl_type_key");
            this.Property(t => t.gl_acct_dbcrf).HasColumnName("gl_acct_dbcrf");
            this.Property(t => t.gl_acct_cntra_acct).HasColumnName("gl_acct_cntra_acct");
            this.Property(t => t.gl_acct_cntrl_acct).HasColumnName("gl_acct_cntrl_acct");
            this.Property(t => t.gl_bdgtwt_key).HasColumnName("gl_bdgtwt_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.gl_acct_upcnt).HasColumnName("gl_acct_upcnt");
            this.Property(t => t.gl_acct_chgdt).HasColumnName("gl_acct_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_acct_crtdt).HasColumnName("gl_acct_crtdt");
            this.Property(t => t.gl_acct_glonly).HasColumnName("gl_acct_glonly");
            this.Property(t => t.gl_acct_inadt).HasColumnName("gl_acct_inadt");
            this.Property(t => t.gl_acct_mcrncyf).HasColumnName("gl_acct_mcrncyf");
            this.Property(t => t.gl_acct_fctf).HasColumnName("gl_acct_fctf");
            this.Property(t => t.gl_acct_3rdpartyf).HasColumnName("gl_acct_3rdpartyf");
            this.Property(t => t.gl_acct_matchf).HasColumnName("gl_acct_matchf");
            this.Property(t => t.gl_acct_easf).HasColumnName("gl_acct_easf");
            this.Property(t => t.gl_locacct_sgid).HasColumnName("gl_locacct_sgid");
        }
    }
}
