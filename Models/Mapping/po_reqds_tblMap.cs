using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_reqds_tblMap : EntityTypeConfiguration<po_reqds_tbl>
    {
        public po_reqds_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_reqhd_key, t.po_reqdt_key, t.po_reqds_key });

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

            this.Property(t => t.po_reqds_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_reqds_text)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("po_reqds_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_reqhd_key).HasColumnName("po_reqhd_key");
            this.Property(t => t.po_reqdt_key).HasColumnName("po_reqdt_key");
            this.Property(t => t.po_reqds_key).HasColumnName("po_reqds_key");
            this.Property(t => t.po_reqds_text).HasColumnName("po_reqds_text");
        }
    }
}
