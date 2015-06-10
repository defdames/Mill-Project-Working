using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_reqhst_tblMap : EntityTypeConfiguration<po_reqhst_tbl>
    {
        public po_reqhst_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_reqhd_key, t.po_reqdt_key, t.po_hdr_key, t.po_dtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_reqhd_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_reqdt_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("po_reqhst_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_reqhd_key).HasColumnName("po_reqhd_key");
            this.Property(t => t.po_reqdt_key).HasColumnName("po_reqdt_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.po_reqhst_issqt).HasColumnName("po_reqhst_issqt");
            this.Property(t => t.po_reqhst_issdt).HasColumnName("po_reqhst_issdt");
            this.Property(t => t.po_reqhst_crtdt).HasColumnName("po_reqhst_crtdt");
            this.Property(t => t.po_reqhst_chgdt).HasColumnName("po_reqhst_chgdt");
            this.Property(t => t.po_reqhst_upcnt).HasColumnName("po_reqhst_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
