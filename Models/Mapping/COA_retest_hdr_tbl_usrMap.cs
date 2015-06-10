using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class COA_retest_hdr_tbl_usrMap : EntityTypeConfiguration<COA_retest_hdr_tbl_usr>
    {
        public COA_retest_hdr_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.date, t.item, t.lot, t.test });

            // Properties
            this.Property(t => t.item)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.lot)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.test)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.result)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("COA_retest_hdr_tbl_usr");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.lot).HasColumnName("lot");
            this.Property(t => t.test).HasColumnName("test");
            this.Property(t => t.result).HasColumnName("result");
        }
    }
}
