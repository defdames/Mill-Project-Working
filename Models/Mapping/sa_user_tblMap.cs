using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sa_user_tblMap : EntityTypeConfiguration<sa_user_tbl>
    {
        public sa_user_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.sa_user_key);

            // Properties
            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sa_user_paswd)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.sa_user_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_adr1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_adr2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sa_user_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_postc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sa_user_fax)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_defbr)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sa_user_defpt)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sa_user_defwh)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sa_user_deffr)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.sa_osuser_key)
                .HasMaxLength(32);

            this.Property(t => t.sa_user_email)
                .HasMaxLength(60);

            this.Property(t => t.sa_user_ceuser)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.sa_user_cepaswd)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.sa_user_colorset)
                .HasMaxLength(30);

            this.Property(t => t.sa_user_loginname)
                .HasMaxLength(40);

            this.Property(t => t.sa_user_sgid)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.en_role_key)
                .HasMaxLength(10);

            this.Property(t => t.sa_user_manager)
                .HasMaxLength(8);

            this.Property(t => t.sa_user_newappr)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("sa_user_tbl");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.sa_user_paswd).HasColumnName("sa_user_paswd");
            this.Property(t => t.sa_user_name).HasColumnName("sa_user_name");
            this.Property(t => t.sa_user_adr1).HasColumnName("sa_user_adr1");
            this.Property(t => t.sa_user_adr2).HasColumnName("sa_user_adr2");
            this.Property(t => t.sa_user_city).HasColumnName("sa_user_city");
            this.Property(t => t.sa_user_state).HasColumnName("sa_user_state");
            this.Property(t => t.sa_user_postc).HasColumnName("sa_user_postc");
            this.Property(t => t.sa_user_tel).HasColumnName("sa_user_tel");
            this.Property(t => t.sa_user_fax).HasColumnName("sa_user_fax");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sa_user_defbr).HasColumnName("sa_user_defbr");
            this.Property(t => t.sa_user_defpt).HasColumnName("sa_user_defpt");
            this.Property(t => t.sa_user_defwh).HasColumnName("sa_user_defwh");
            this.Property(t => t.sa_user_lastlogin).HasColumnName("sa_user_lastlogin");
            this.Property(t => t.sa_user_deffr).HasColumnName("sa_user_deffr");
            this.Property(t => t.sa_user_strdt).HasColumnName("sa_user_strdt");
            this.Property(t => t.sa_user_enddt).HasColumnName("sa_user_enddt");
            this.Property(t => t.sa_user_loginframe).HasColumnName("sa_user_loginframe");
            this.Property(t => t.sa_osuser_key).HasColumnName("sa_osuser_key");
            this.Property(t => t.sa_user_webf).HasColumnName("sa_user_webf");
            this.Property(t => t.sa_user_desktopf).HasColumnName("sa_user_desktopf");
            this.Property(t => t.sa_user_email).HasColumnName("sa_user_email");
            this.Property(t => t.sa_user_ceuser).HasColumnName("sa_user_ceuser");
            this.Property(t => t.sa_user_cepaswd).HasColumnName("sa_user_cepaswd");
            this.Property(t => t.sa_user_colorset).HasColumnName("sa_user_colorset");
            this.Property(t => t.sa_user_enticnf).HasColumnName("sa_user_enticnf");
            this.Property(t => t.sa_user_upcnt).HasColumnName("sa_user_upcnt");
            this.Property(t => t.sa_user_loginname).HasColumnName("sa_user_loginname");
            this.Property(t => t.sa_user_sgid).HasColumnName("sa_user_sgid");
            this.Property(t => t.en_role_key).HasColumnName("en_role_key");
            this.Property(t => t.sa_user_options).HasColumnName("sa_user_options");
            this.Property(t => t.sa_user_locked).HasColumnName("sa_user_locked");
            this.Property(t => t.sa_user_apprinadt).HasColumnName("sa_user_apprinadt");
            this.Property(t => t.sa_user_skipapprf).HasColumnName("sa_user_skipapprf");
            this.Property(t => t.sa_user_manager).HasColumnName("sa_user_manager");
            this.Property(t => t.sa_user_newappr).HasColumnName("sa_user_newappr");
            this.Property(t => t.sa_user_chngpwd).HasColumnName("sa_user_chngpwd");
        }
    }
}
