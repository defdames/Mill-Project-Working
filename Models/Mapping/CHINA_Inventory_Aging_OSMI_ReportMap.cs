using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_Inventory_Aging_OSMI_ReportMap : EntityTypeConfiguration<CHINA_Inventory_Aging_OSMI_Report>
    {
        public CHINA_Inventory_Aging_OSMI_ReportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Classification, t.in_item_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.Classification)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Grouping)
                .HasMaxLength(5);

            this.Property(t => t.ProdGrp)
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ItemStatus)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CHINA_Inventory_Aging_OSMI_Report");
            this.Property(t => t.Classification).HasColumnName("Classification");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_lot_qoh).HasColumnName("in_lot_qoh");
            this.Property(t => t.in_whitmpk_scst).HasColumnName("in_whitmpk_scst");
            this.Property(t => t.Grouping).HasColumnName("Grouping");
            this.Property(t => t.ProdGrp).HasColumnName("ProdGrp");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ItemStatus).HasColumnName("ItemStatus");
            this.Property(t => t.lb_in_lot_qoh).HasColumnName("lb_in_lot_qoh");
            this.Property(t => t.ExtCost).HasColumnName("ExtCost");
            this.Property(t => t.kg_in_lot_qoh).HasColumnName("kg_in_lot_qoh");
        }
    }
}
