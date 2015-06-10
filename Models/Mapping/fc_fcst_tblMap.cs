using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class fc_fcst_tblMap : EntityTypeConfiguration<fc_fcst_tbl>
    {
        public fc_fcst_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.fc_fcst_numbr });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.fc_fcst_numbr)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.fc_fcst_histn)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.fc_fcst_qdflg)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.fc_fcst_expid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.fc_fcst_descr)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.fc_fcst_cstsh)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("fc_fcst_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.fc_fcst_numbr).HasColumnName("fc_fcst_numbr");
            this.Property(t => t.fc_fcst_histn).HasColumnName("fc_fcst_histn");
            this.Property(t => t.fc_fcst_qdflg).HasColumnName("fc_fcst_qdflg");
            this.Property(t => t.ar_cust_key).HasColumnName("ar_cust_key");
            this.Property(t => t.fc_fcst_expid).HasColumnName("fc_fcst_expid");
            this.Property(t => t.fc_fcst_methd).HasColumnName("fc_fcst_methd");
            this.Property(t => t.fc_fcst_crtdt).HasColumnName("fc_fcst_crtdt");
            this.Property(t => t.fc_fcst_buckt).HasColumnName("fc_fcst_buckt");
            this.Property(t => t.fc_fcst_strdt).HasColumnName("fc_fcst_strdt");
            this.Property(t => t.fc_fcst_enddt).HasColumnName("fc_fcst_enddt");
            this.Property(t => t.fc_fcst_perct).HasColumnName("fc_fcst_perct");
            this.Property(t => t.fc_fcst_descr).HasColumnName("fc_fcst_descr");
            this.Property(t => t.fc_fcst_chgdt).HasColumnName("fc_fcst_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.fc_fcst_upcnt).HasColumnName("fc_fcst_upcnt");
            this.Property(t => t.fc_fcst_cstsh).HasColumnName("fc_fcst_cstsh");
        }
    }
}
