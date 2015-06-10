using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_salsm_tblMap : EntityTypeConfiguration<so_salsm_tbl>
    {
        public so_salsm_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_salsm_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_salsm_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_adr1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_adr2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_adr3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_salsm_pczip)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_salsm_cntry)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_salsm_tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_salsm_fax)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_salsm_modem)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_salsm_itnet)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.so_salsm_telex)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_salsm_terr)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_salsm_comty)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.so_salsm_mgrid)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.so_salsm_cmuom)
                .HasMaxLength(2);

            this.Property(t => t.gl_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("so_salsm_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.so_salsm_name).HasColumnName("so_salsm_name");
            this.Property(t => t.so_salsm_adr1).HasColumnName("so_salsm_adr1");
            this.Property(t => t.so_salsm_adr2).HasColumnName("so_salsm_adr2");
            this.Property(t => t.so_salsm_adr3).HasColumnName("so_salsm_adr3");
            this.Property(t => t.so_salsm_city).HasColumnName("so_salsm_city");
            this.Property(t => t.so_salsm_pczip).HasColumnName("so_salsm_pczip");
            this.Property(t => t.so_salsm_cntry).HasColumnName("so_salsm_cntry");
            this.Property(t => t.so_salsm_tel).HasColumnName("so_salsm_tel");
            this.Property(t => t.so_salsm_fax).HasColumnName("so_salsm_fax");
            this.Property(t => t.so_salsm_modem).HasColumnName("so_salsm_modem");
            this.Property(t => t.so_salsm_itnet).HasColumnName("so_salsm_itnet");
            this.Property(t => t.so_salsm_telex).HasColumnName("so_salsm_telex");
            this.Property(t => t.so_salsm_terr).HasColumnName("so_salsm_terr");
            this.Property(t => t.so_salsm_comty).HasColumnName("so_salsm_comty");
            this.Property(t => t.so_salsm_cmval).HasColumnName("so_salsm_cmval");
            this.Property(t => t.so_salsm_booked).HasColumnName("so_salsm_booked");
            this.Property(t => t.so_salsm_due).HasColumnName("so_salsm_due");
            this.Property(t => t.so_salsm_paid).HasColumnName("so_salsm_paid");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.so_salsm_chgdt).HasColumnName("so_salsm_chgdt");
            this.Property(t => t.so_salsm_crtdt).HasColumnName("so_salsm_crtdt");
            this.Property(t => t.so_salsm_mgrid).HasColumnName("so_salsm_mgrid");
            this.Property(t => t.so_salsm_cmtypf).HasColumnName("so_salsm_cmtypf");
            this.Property(t => t.so_salsm_cmuom).HasColumnName("so_salsm_cmuom");
            this.Property(t => t.so_salsm_upcnt).HasColumnName("so_salsm_upcnt");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
        }
    }
}
