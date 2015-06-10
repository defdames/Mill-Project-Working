using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_reqhd_tblMap : EntityTypeConfiguration<po_reqhd_tbl>
    {
        public po_reqhd_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_reqhd_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_reqhd_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_reqhd_persn)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_reqhd_cmmts)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.po_reqhd_persnemail)
                .HasMaxLength(60);

            this.Property(t => t.po_reqhd_externalref)
                .HasMaxLength(30);

            this.Property(t => t.at_in_sgid)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("po_reqhd_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_reqhd_key).HasColumnName("po_reqhd_key");
            this.Property(t => t.po_reqhd_type).HasColumnName("po_reqhd_type");
            this.Property(t => t.po_reqhd_persn).HasColumnName("po_reqhd_persn");
            this.Property(t => t.po_reqhd_entdt).HasColumnName("po_reqhd_entdt");
            this.Property(t => t.po_reqhd_upcnt).HasColumnName("po_reqhd_upcnt");
            this.Property(t => t.po_reqhd_aprvf).HasColumnName("po_reqhd_aprvf");
            this.Property(t => t.po_reqhd_cmmts).HasColumnName("po_reqhd_cmmts");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.po_reqhd_crtdt).HasColumnName("po_reqhd_crtdt");
            this.Property(t => t.po_reqhd_chgdt).HasColumnName("po_reqhd_chgdt");
            this.Property(t => t.po_reqhd_persnemail).HasColumnName("po_reqhd_persnemail");
            this.Property(t => t.po_reqhd_externalref).HasColumnName("po_reqhd_externalref");
            this.Property(t => t.po_reqhd_clsdt).HasColumnName("po_reqhd_clsdt");
            this.Property(t => t.po_reqhd_eamid).HasColumnName("po_reqhd_eamid");
            this.Property(t => t.at_in_sgid).HasColumnName("at_in_sgid");
        }
    }
}
