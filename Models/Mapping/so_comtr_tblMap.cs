using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_comtr_tblMap : EntityTypeConfiguration<so_comtr_tbl>
    {
        public so_comtr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_comtr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_comtr_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_comtr_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_comtr_stats)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.so_comtr_ref)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.so_comtr_cmuom)
                .HasMaxLength(2);

            this.Property(t => t.gl_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_profit)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_profit)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.so_comtr_reftype)
                .HasMaxLength(1);

            this.Property(t => t.so_comtr_refnum)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("so_comtr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_comtr_key).HasColumnName("so_comtr_key");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.so_comtr_type).HasColumnName("so_comtr_type");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.so_comtr_soamt).HasColumnName("so_comtr_soamt");
            this.Property(t => t.so_comtr_cmval).HasColumnName("so_comtr_cmval");
            this.Property(t => t.so_comtr_booked).HasColumnName("so_comtr_booked");
            this.Property(t => t.so_comtr_due).HasColumnName("so_comtr_due");
            this.Property(t => t.so_comtr_paid).HasColumnName("so_comtr_paid");
            this.Property(t => t.so_comtr_stats).HasColumnName("so_comtr_stats");
            this.Property(t => t.so_comtr_pysldt).HasColumnName("so_comtr_pysldt");
            this.Property(t => t.so_comtr_trndt).HasColumnName("so_comtr_trndt");
            this.Property(t => t.so_comtr_ref).HasColumnName("so_comtr_ref");
            this.Property(t => t.ap_chek_key).HasColumnName("ap_chek_key");
            this.Property(t => t.so_comtr_upcnt).HasColumnName("so_comtr_upcnt");
            this.Property(t => t.so_comtr_cmtypf).HasColumnName("so_comtr_cmtypf");
            this.Property(t => t.so_comtr_cmuom).HasColumnName("so_comtr_cmuom");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.gl_cmp_profit).HasColumnName("gl_cmp_profit");
            this.Property(t => t.so_brnch_profit).HasColumnName("so_brnch_profit");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.so_comtr_rate).HasColumnName("so_comtr_rate");
            this.Property(t => t.so_comtr_asofdt).HasColumnName("so_comtr_asofdt");
            this.Property(t => t.so_comtr_origto3).HasColumnName("so_comtr_origto3");
            this.Property(t => t.so_comtr_tobase).HasColumnName("so_comtr_tobase");
            this.Property(t => t.so_comtr_bookedcf).HasColumnName("so_comtr_bookedcf");
            this.Property(t => t.so_comtr_duecf).HasColumnName("so_comtr_duecf");
            this.Property(t => t.so_comtr_paidcf).HasColumnName("so_comtr_paidcf");
            this.Property(t => t.so_comtr_reftype).HasColumnName("so_comtr_reftype");
            this.Property(t => t.so_comtr_refnum).HasColumnName("so_comtr_refnum");
            this.Property(t => t.so_inbcom_key).HasColumnName("so_inbcom_key");
            this.Property(t => t.so_comtr_reflnnum).HasColumnName("so_comtr_reflnnum");
        }
    }
}
