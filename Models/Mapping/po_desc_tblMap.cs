using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_desc_tblMap : EntityTypeConfiguration<po_desc_tbl>
    {
        public po_desc_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_hdr_key, t.po_dtl_key, t.po_desc_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_desc_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_desc_text)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("po_desc_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.po_desc_key).HasColumnName("po_desc_key");
            this.Property(t => t.po_desc_text).HasColumnName("po_desc_text");
            this.Property(t => t.po_desc_upcnt).HasColumnName("po_desc_upcnt");
        }
    }
}
