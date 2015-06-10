using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_payhdr_tblMap : EntityTypeConfiguration<ap_payhdr_tbl>
    {
        public ap_payhdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ap_payhdr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ap_payhdr_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ap_bank_key)
                .HasMaxLength(20);

            this.Property(t => t.ap_bank_acctno)
                .HasMaxLength(20);

            this.Property(t => t.ap_payhdr_chekty)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ap_payhdr_tranref)
                .HasMaxLength(20);

            this.Property(t => t.ap_payhdr_stats)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ap_payhdr_clstat)
                .HasMaxLength(10);

            this.Property(t => t.ap_payhdr_desc)
                .HasMaxLength(30);

            this.Property(t => t.ap_payhdr_ref)
                .HasMaxLength(30);

            this.Property(t => t.ap_payhdr_entid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_payhdr_entnm)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ap_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.prog_nam)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ap_payhdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ap_payhdr_key).HasColumnName("ap_payhdr_key");
            this.Property(t => t.ap_bank_key).HasColumnName("ap_bank_key");
            this.Property(t => t.ap_bank_acctno).HasColumnName("ap_bank_acctno");
            this.Property(t => t.ap_payhdr_type).HasColumnName("ap_payhdr_type");
            this.Property(t => t.ap_payhdr_chekty).HasColumnName("ap_payhdr_chekty");
            this.Property(t => t.ap_payhdr_tranref).HasColumnName("ap_payhdr_tranref");
            this.Property(t => t.ap_payhdr_seldt).HasColumnName("ap_payhdr_seldt");
            this.Property(t => t.ap_payhdr_paydt).HasColumnName("ap_payhdr_paydt");
            this.Property(t => t.ap_payhdr_voddt).HasColumnName("ap_payhdr_voddt");
            this.Property(t => t.ap_payhdr_prtdt).HasColumnName("ap_payhdr_prtdt");
            this.Property(t => t.ap_payhdr_presdt).HasColumnName("ap_payhdr_presdt");
            this.Property(t => t.ap_payhdr_stats).HasColumnName("ap_payhdr_stats");
            this.Property(t => t.ap_payhdr_clstat).HasColumnName("ap_payhdr_clstat");
            this.Property(t => t.ap_payhdr_desc).HasColumnName("ap_payhdr_desc");
            this.Property(t => t.ap_payhdr_ref).HasColumnName("ap_payhdr_ref");
            this.Property(t => t.ap_payhdr_entid).HasColumnName("ap_payhdr_entid");
            this.Property(t => t.ap_payhdr_entnm).HasColumnName("ap_payhdr_entnm");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.ap_payhdr_amt).HasColumnName("ap_payhdr_amt");
            this.Property(t => t.ap_payhdr_amtf).HasColumnName("ap_payhdr_amtf");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.prog_nam).HasColumnName("prog_nam");
            this.Property(t => t.ap_payhdr_crtdt).HasColumnName("ap_payhdr_crtdt");
            this.Property(t => t.ap_payhdr_chgdt).HasColumnName("ap_payhdr_chgdt");
            this.Property(t => t.ap_payhdr_upcnt).HasColumnName("ap_payhdr_upcnt");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.ap_payhdr_payst).HasColumnName("ap_payhdr_payst");
            this.Property(t => t.ap_payhdr_duedt).HasColumnName("ap_payhdr_duedt");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
        }
    }
}
