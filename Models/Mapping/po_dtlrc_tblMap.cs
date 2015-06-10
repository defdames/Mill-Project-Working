using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_dtlrc_tblMap : EntityTypeConfiguration<po_dtlrc_tbl>
    {
        public po_dtlrc_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_recpt_key, t.po_dtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_recpt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_puom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_uom_ruom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_uom_fuom)
                .HasMaxLength(2);

            this.Property(t => t.po_dtlrc_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.en_uom_pruom)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("po_dtlrc_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_recpt_key).HasColumnName("po_recpt_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_dtlrc_qty).HasColumnName("po_dtlrc_qty");
            this.Property(t => t.po_dtlrc_accqt).HasColumnName("po_dtlrc_accqt");
            this.Property(t => t.po_dtlrc_rejqt).HasColumnName("po_dtlrc_rejqt");
            this.Property(t => t.po_dtlrc_retqt).HasColumnName("po_dtlrc_retqt");
            this.Property(t => t.ap_vchdtl_invqt).HasColumnName("ap_vchdtl_invqt");
            this.Property(t => t.po_dtlrc_qoh).HasColumnName("po_dtlrc_qoh");
            this.Property(t => t.en_uom_puom).HasColumnName("en_uom_puom");
            this.Property(t => t.po_dtlrc_poqty).HasColumnName("po_dtlrc_poqty");
            this.Property(t => t.en_uom_ruom).HasColumnName("en_uom_ruom");
            this.Property(t => t.en_uom_fuom).HasColumnName("en_uom_fuom");
            this.Property(t => t.po_dtlrc_totaqty).HasColumnName("po_dtlrc_totaqty");
            this.Property(t => t.po_dtlrc_cmnts).HasColumnName("po_dtlrc_cmnts");
            this.Property(t => t.po_dtlrc_prqty).HasColumnName("po_dtlrc_prqty");
            this.Property(t => t.en_uom_pruom).HasColumnName("en_uom_pruom");
            this.Property(t => t.po_dtlrc_quotcf).HasColumnName("po_dtlrc_quotcf");
            this.Property(t => t.po_dtlrc_quotc).HasColumnName("po_dtlrc_quotc");
            this.Property(t => t.po_dtlrc_coaf).HasColumnName("po_dtlrc_coaf");
            this.Property(t => t.ap_invdtl_invqt).HasColumnName("ap_invdtl_invqt");
            this.Property(t => t.po_dtlrc_stdcst).HasColumnName("po_dtlrc_stdcst");
        }
    }
}
