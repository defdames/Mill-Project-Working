using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class global_inventory_temp_tblMap : EntityTypeConfiguration<global_inventory_temp_tbl>
    {
        public global_inventory_temp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.en_prod_key, t.in_lot_key, t.inv_qoh });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.reference_number)
                .HasMaxLength(25);

            this.Property(t => t.uom_key)
                .HasMaxLength(10);

            this.Property(t => t.uom_qty)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("global_inventory_temp_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.inv_qoh).HasColumnName("inv_qoh");
            this.Property(t => t.reference_number).HasColumnName("reference_number");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.uom_qty).HasColumnName("uom_qty");
            this.Property(t => t.upload_date).HasColumnName("upload_date");
        }
    }
}
