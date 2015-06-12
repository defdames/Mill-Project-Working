using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class activity_by_whseMap : EntityTypeConfiguration<activity_by_whse>
    {
        public activity_by_whseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Whse, t.WhseItem, t.Commodity, t.PdMo, t.PdYr });

            // Properties
            this.Property(t => t.ItemKey)
                .HasMaxLength(20);

            this.Property(t => t.Whse)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.WhseItem)
                .IsRequired()
                .HasMaxLength(24);

            this.Property(t => t.Commodity)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PdMo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PdYr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("activity_by_whse");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.Whse).HasColumnName("Whse");
            this.Property(t => t.WhseItem).HasColumnName("WhseItem");
            this.Property(t => t.Commodity).HasColumnName("Commodity");
            this.Property(t => t.BOH).HasColumnName("BOH");
            this.Property(t => t.Production).HasColumnName("Production");
            this.Property(t => t.ProdReceipts).HasColumnName("ProdReceipts");
            this.Property(t => t.ProdIssues).HasColumnName("ProdIssues");
            this.Property(t => t.InvAdj).HasColumnName("InvAdj");
            this.Property(t => t.PO).HasColumnName("PO");
            this.Property(t => t.WhseXfers).HasColumnName("WhseXfers");
            this.Property(t => t.PdMo).HasColumnName("PdMo");
            this.Property(t => t.PdYr).HasColumnName("PdYr");
            this.Property(t => t.EOH).HasColumnName("EOH");
        }
    }
}
