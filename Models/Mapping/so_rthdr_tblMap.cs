using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_rthdr_tblMap : EntityTypeConfiguration<so_rthdr_tbl>
    {
        public so_rthdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_rthdr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_rthdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_rthdr_refid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_rthdr_connam)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_rthdr_contel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_resn_code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_id)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.so_rthdr_authoriid)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_modified_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_mode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frgt_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("so_rthdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_rthdr_key).HasColumnName("so_rthdr_key");
            this.Property(t => t.so_rthdr_refid).HasColumnName("so_rthdr_refid");
            this.Property(t => t.so_rthdr_rtdt).HasColumnName("so_rthdr_rtdt");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.so_rthdr_connam).HasColumnName("so_rthdr_connam");
            this.Property(t => t.so_rthdr_contel).HasColumnName("so_rthdr_contel");
            this.Property(t => t.so_resn_code).HasColumnName("so_resn_code");
            this.Property(t => t.so_rthdr_stat).HasColumnName("so_rthdr_stat");
            this.Property(t => t.so_rtath_date).HasColumnName("so_rtath_date");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.sa_user_id).HasColumnName("sa_user_id");
            this.Property(t => t.so_rthdr_insflag).HasColumnName("so_rthdr_insflag");
            this.Property(t => t.so_rthdr_authoriid).HasColumnName("so_rthdr_authoriid");
            this.Property(t => t.so_rthdr_amnttotal).HasColumnName("so_rthdr_amnttotal");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.so_rthdr_reqdt).HasColumnName("so_rthdr_reqdt");
            this.Property(t => t.so_rthdr_scheduldt).HasColumnName("so_rthdr_scheduldt");
            this.Property(t => t.sa_modified_by).HasColumnName("sa_modified_by");
            this.Property(t => t.so_rthdr_chgdt).HasColumnName("so_rthdr_chgdt");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.so_rthdr_upcnt).HasColumnName("so_rthdr_upcnt");
            this.Property(t => t.so_rthdr_eustat).HasColumnName("so_rthdr_eustat");
            this.Property(t => t.so_rthdr_eustatdt).HasColumnName("so_rthdr_eustatdt");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.so_rthdr_type).HasColumnName("so_rthdr_type");
        }
    }
}
