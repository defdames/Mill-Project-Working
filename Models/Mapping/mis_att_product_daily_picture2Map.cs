using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_att_product_daily_picture2Map : EntityTypeConfiguration<mis_att_product_daily_picture2>
    {
        public mis_att_product_daily_picture2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Item, t.PackKey, t.Catalog, t.ProductStatus });

            // Properties
            this.Property(t => t.Product)
                .HasMaxLength(20);

            this.Property(t => t.ProductDesc)
                .HasMaxLength(60);

            this.Property(t => t.Item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PackKey)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Catalog)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ProdGrp)
                .HasMaxLength(30);

            this.Property(t => t.ProductStatus)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LNum)
                .HasMaxLength(60);

            this.Property(t => t.LNum_CreateDt)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Market)
                .HasMaxLength(30);

            this.Property(t => t.SLLStatus)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("mis_att_product_daily_picture2");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.ProductDesc).HasColumnName("ProductDesc");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.PackKey).HasColumnName("PackKey");
            this.Property(t => t.Catalog).HasColumnName("Catalog");
            this.Property(t => t.ProdGrp).HasColumnName("ProdGrp");
            this.Property(t => t.ProductStatus).HasColumnName("ProductStatus");
            this.Property(t => t.LNum).HasColumnName("LNum");
            this.Property(t => t.LNum_CreateDt).HasColumnName("LNum_CreateDt");
            this.Property(t => t.Market).HasColumnName("Market");
            this.Property(t => t.SLLStatus).HasColumnName("SLLStatus");
            this.Property(t => t.QOHLBS_SM).HasColumnName("QOHLBS_SM");
            this.Property(t => t.QOHKGS_SM).HasColumnName("QOHKGS_SM");
            this.Property(t => t.InvValue_SM).HasColumnName("InvValue_SM");
            this.Property(t => t.DaysOnHand_SM).HasColumnName("DaysOnHand_SM");
            this.Property(t => t.QOHLBS_SX).HasColumnName("QOHLBS_SX");
            this.Property(t => t.QOHKGS_SX).HasColumnName("QOHKGS_SX");
            this.Property(t => t.InvValue_SX).HasColumnName("InvValue_SX");
            this.Property(t => t.DaysOnHand_SX).HasColumnName("DaysOnHand_SX");
            this.Property(t => t.QOHLBS_SL).HasColumnName("QOHLBS_SL");
            this.Property(t => t.QOHKGS_SL).HasColumnName("QOHKGS_SL");
            this.Property(t => t.InvValue_SL).HasColumnName("InvValue_SL");
            this.Property(t => t.DaysOnHand_SL).HasColumnName("DaysOnHand_SL");
            this.Property(t => t.QOHLBS_SA).HasColumnName("QOHLBS_SA");
            this.Property(t => t.QOHKGS_SA).HasColumnName("QOHKGS_SA");
            this.Property(t => t.InvValue_SA).HasColumnName("InvValue_SA");
            this.Property(t => t.DaysOnHand_SA).HasColumnName("DaysOnHand_SA");
            this.Property(t => t.QOHLBS_SS).HasColumnName("QOHLBS_SS");
            this.Property(t => t.QOHKGS_SS).HasColumnName("QOHKGS_SS");
            this.Property(t => t.InvValue_SS).HasColumnName("InvValue_SS");
            this.Property(t => t.DaysOnHand_SS).HasColumnName("DaysOnHand_SS");
        }
    }
}
