using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class commodity_by_whse_sapMap : EntityTypeConfiguration<commodity_by_whse_sap>
    {
        public commodity_by_whse_sapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemKey, t.PackKey, t.PdMo, t.PdYr, t.Commodity, t.GLAcct, t.ClassKey, t.in_whs_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PackKey)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.PdMo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PdYr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Commodity)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GLAcct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ClassKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("commodity_by_whse_sap");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.PackKey).HasColumnName("PackKey");
            this.Property(t => t.lbsqty).HasColumnName("lbsqty");
            this.Property(t => t.kgsqty).HasColumnName("kgsqty");
            this.Property(t => t.PdMo).HasColumnName("PdMo");
            this.Property(t => t.PdYr).HasColumnName("PdYr");
            this.Property(t => t.Commodity).HasColumnName("Commodity");
            this.Property(t => t.GLAcct).HasColumnName("GLAcct");
            this.Property(t => t.ClassKey).HasColumnName("ClassKey");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
