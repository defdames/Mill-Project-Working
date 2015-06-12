using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_retrn_tblMap : EntityTypeConfiguration<po_retrn_tbl>
    {
        public po_retrn_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_retrn_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_retrn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_recpt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_retrn_dbmem)
                .HasMaxLength(10);

            this.Property(t => t.po_retrn_rma)
                .HasMaxLength(20);

            this.Property(t => t.en_fob_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_trnsport_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_carr_key)
                .HasMaxLength(10);

            this.Property(t => t.po_retrn_bolno)
                .HasMaxLength(20);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.en_serv_key)
                .HasMaxLength(10);

            this.Property(t => t.po_rtreq_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("po_retrn_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_retrn_key).HasColumnName("po_retrn_key");
            this.Property(t => t.po_retrn_retdt).HasColumnName("po_retrn_retdt");
            this.Property(t => t.po_recpt_key).HasColumnName("po_recpt_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_retrn_dbmem).HasColumnName("po_retrn_dbmem");
            this.Property(t => t.po_retrn_rma).HasColumnName("po_retrn_rma");
            this.Property(t => t.po_retrn_eustatf).HasColumnName("po_retrn_eustatf");
            this.Property(t => t.po_retrn_eustatdt).HasColumnName("po_retrn_eustatdt");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
            this.Property(t => t.en_trnsport_key).HasColumnName("en_trnsport_key");
            this.Property(t => t.po_retrn_upcnt).HasColumnName("po_retrn_upcnt");
            this.Property(t => t.po_retrn_chgdt).HasColumnName("po_retrn_chgdt");
            this.Property(t => t.po_retrn_crtdt).HasColumnName("po_retrn_crtdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.po_retrn_bolno).HasColumnName("po_retrn_bolno");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_serv_key).HasColumnName("en_serv_key");
            this.Property(t => t.po_rtreq_key).HasColumnName("po_rtreq_key");
        }
    }
}
