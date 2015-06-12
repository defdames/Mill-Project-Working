using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_lotpk_tbl_sapMap : EntityTypeConfiguration<in_lotpk_tbl_sap>
    {
        public in_lotpk_tbl_sapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_whs_key, t.en_prod_key, t.in_lot_key });

            // Properties
            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("in_lotpk_tbl_sap");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_lot_qoh).HasColumnName("in_lot_qoh");
        }
    }
}
