using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class open_po_daily_pictureMap : EntityTypeConfiguration<open_po_daily_picture>
    {
        public open_po_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_buyc, t.in_item_key, t.po_hdr_key, t.po_dtl_key, t.extdueqt, t.in_desc, t.po_dtl_dueqt, t.po_dtl_ordqt, t.po_dtl_prmdt, t.po_dtl_quotc, t.po_dtl_reqdt, t.po_dtl_stats, t.po_dtl_uom, t.po_hdr_orddt, t.po_hdr_revno, t.in_whs_key, t.gl_cmp_key, t.so_brnch_key, t.notes, t.gl_crncy_key });

            // Properties
            this.Property(t => t.in_buyc)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Type)
                .HasMaxLength(9);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_vend_key)
                .HasMaxLength(10);

            this.Property(t => t.en_vend_name)
                .HasMaxLength(30);

            this.Property(t => t.in_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.po_dtl_stats)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_dtl_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.po_hdr_revno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.notes)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.requisition_number)
                .HasMaxLength(10);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("open_po_daily_picture");
            this.Property(t => t.yearcapture).HasColumnName("yearcapture");
            this.Property(t => t.weekcapture).HasColumnName("weekcapture");
            this.Property(t => t.monthcapture).HasColumnName("monthcapture");
            this.Property(t => t.in_buyc).HasColumnName("in_buyc");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.en_vend_name).HasColumnName("en_vend_name");
            this.Property(t => t.extdueqt).HasColumnName("extdueqt");
            this.Property(t => t.in_desc).HasColumnName("in_desc");
            this.Property(t => t.po_dtl_dueqt).HasColumnName("po_dtl_dueqt");
            this.Property(t => t.po_dtl_ordqt).HasColumnName("po_dtl_ordqt");
            this.Property(t => t.po_dtl_prmdt).HasColumnName("po_dtl_prmdt");
            this.Property(t => t.po_dtl_quotc).HasColumnName("po_dtl_quotc");
            this.Property(t => t.po_dtl_reqdt).HasColumnName("po_dtl_reqdt");
            this.Property(t => t.po_dtl_stats).HasColumnName("po_dtl_stats");
            this.Property(t => t.po_dtl_uom).HasColumnName("po_dtl_uom");
            this.Property(t => t.po_hdr_orddt).HasColumnName("po_hdr_orddt");
            this.Property(t => t.po_hdr_revno).HasColumnName("po_hdr_revno");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.notes).HasColumnName("notes");
            this.Property(t => t.requisition_number).HasColumnName("requisition_number");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
        }
    }
}
