using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_allocation_lotdetailMap : EntityTypeConfiguration<CHINA_allocation_lotdetail>
    {
        public CHINA_allocation_lotdetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.SOHDR, t.SODTL, t.in_lot_key, t.countryoforigin });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.SOHDR)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SODTL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.countryoforigin)
                .IsRequired()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("CHINA_allocation_lotdetail");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.SOHDR).HasColumnName("SOHDR");
            this.Property(t => t.SODTL).HasColumnName("SODTL");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.ShpQty).HasColumnName("ShpQty");
            this.Property(t => t.countryoforigin).HasColumnName("countryoforigin");
        }
    }
}
