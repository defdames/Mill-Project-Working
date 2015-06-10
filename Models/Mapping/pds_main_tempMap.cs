using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pds_main_tempMap : EntityTypeConfiguration<pds_main_temp>
    {
        public pds_main_tempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Item, t.en_prod_desc });

            // Properties
            this.Property(t => t.Item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.AluminumDescription)
                .HasMaxLength(255);

            this.Property(t => t.ProductDescriptor1)
                .HasMaxLength(255);

            this.Property(t => t.ProductDescriptor2)
                .HasMaxLength(255);

            this.Property(t => t.ProductDescriptor3)
                .HasMaxLength(255);

            this.Property(t => t.ProductDescriptor4)
                .HasMaxLength(255);

            this.Property(t => t.ProductDescriptor5)
                .HasMaxLength(255);

            this.Property(t => t.FormulatingGuidelines)
                .HasMaxLength(4000);

            this.Property(t => t.MarketIcon1)
                .HasMaxLength(50);

            this.Property(t => t.MarketIcon2)
                .HasMaxLength(50);

            this.Property(t => t.MarketIcon3)
                .HasMaxLength(50);

            this.Property(t => t.MarketIcon4)
                .HasMaxLength(50);

            this.Property(t => t.MarketIcon5)
                .HasMaxLength(50);

            this.Property(t => t.MarketIcon6)
                .HasMaxLength(50);

            this.Property(t => t.MarketIcon7)
                .HasMaxLength(50);

            this.Property(t => t.MarketIcon8)
                .HasMaxLength(50);

            this.Property(t => t.Descriptions)
                .HasMaxLength(4000);

            this.Property(t => t.Application)
                .HasMaxLength(4000);

            this.Property(t => t.ProductAttribPriority1)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority1Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority2)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority2Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority3)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority3Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority4)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority4Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority5)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority5Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority6)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority6Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority7)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority7Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority8)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority8Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority9)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority9Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority10)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority10Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority11)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority11Value)
                .HasMaxLength(255);

            this.Property(t => t.ProductAttribPriority12)
                .HasMaxLength(50);

            this.Property(t => t.ProductAttribPriority12Value)
                .HasMaxLength(255);

            this.Property(t => t.en_item_msds)
                .HasMaxLength(10);

            this.Property(t => t.ProductCategory)
                .HasMaxLength(50);

            this.Property(t => t.LeafingType)
                .HasMaxLength(50);

            this.Property(t => t.AutomotiveCategory)
                .HasMaxLength(50);

            this.Property(t => t.PrintingInksCategory)
                .HasMaxLength(50);

            this.Property(t => t.PlasticsCategory)
                .HasMaxLength(50);

            this.Property(t => t.GeneralIndCategory)
                .HasMaxLength(50);

            this.Property(t => t.TradeMaintCategory)
                .HasMaxLength(50);

            this.Property(t => t.PowderCoatCategory)
                .HasMaxLength(50);

            this.Property(t => t.CosmeticsCategory)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("pds_main_temp");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
            this.Property(t => t.AluminumDescription).HasColumnName("AluminumDescription");
            this.Property(t => t.ProductDescriptor1).HasColumnName("ProductDescriptor1");
            this.Property(t => t.ProductDescriptor2).HasColumnName("ProductDescriptor2");
            this.Property(t => t.ProductDescriptor3).HasColumnName("ProductDescriptor3");
            this.Property(t => t.ProductDescriptor4).HasColumnName("ProductDescriptor4");
            this.Property(t => t.ProductDescriptor5).HasColumnName("ProductDescriptor5");
            this.Property(t => t.FormulatingGuidelines).HasColumnName("FormulatingGuidelines");
            this.Property(t => t.MarketIcon1).HasColumnName("MarketIcon1");
            this.Property(t => t.MarketIcon2).HasColumnName("MarketIcon2");
            this.Property(t => t.MarketIcon3).HasColumnName("MarketIcon3");
            this.Property(t => t.MarketIcon4).HasColumnName("MarketIcon4");
            this.Property(t => t.MarketIcon5).HasColumnName("MarketIcon5");
            this.Property(t => t.MarketIcon6).HasColumnName("MarketIcon6");
            this.Property(t => t.MarketIcon7).HasColumnName("MarketIcon7");
            this.Property(t => t.MarketIcon8).HasColumnName("MarketIcon8");
            this.Property(t => t.Descriptions).HasColumnName("Descriptions");
            this.Property(t => t.Application).HasColumnName("Application");
            this.Property(t => t.ProductAttribPriority1).HasColumnName("ProductAttribPriority1");
            this.Property(t => t.ProductAttribPriority1Value).HasColumnName("ProductAttribPriority1Value");
            this.Property(t => t.ProductAttribPriority2).HasColumnName("ProductAttribPriority2");
            this.Property(t => t.ProductAttribPriority2Value).HasColumnName("ProductAttribPriority2Value");
            this.Property(t => t.ProductAttribPriority3).HasColumnName("ProductAttribPriority3");
            this.Property(t => t.ProductAttribPriority3Value).HasColumnName("ProductAttribPriority3Value");
            this.Property(t => t.ProductAttribPriority4).HasColumnName("ProductAttribPriority4");
            this.Property(t => t.ProductAttribPriority4Value).HasColumnName("ProductAttribPriority4Value");
            this.Property(t => t.ProductAttribPriority5).HasColumnName("ProductAttribPriority5");
            this.Property(t => t.ProductAttribPriority5Value).HasColumnName("ProductAttribPriority5Value");
            this.Property(t => t.ProductAttribPriority6).HasColumnName("ProductAttribPriority6");
            this.Property(t => t.ProductAttribPriority6Value).HasColumnName("ProductAttribPriority6Value");
            this.Property(t => t.ProductAttribPriority7).HasColumnName("ProductAttribPriority7");
            this.Property(t => t.ProductAttribPriority7Value).HasColumnName("ProductAttribPriority7Value");
            this.Property(t => t.ProductAttribPriority8).HasColumnName("ProductAttribPriority8");
            this.Property(t => t.ProductAttribPriority8Value).HasColumnName("ProductAttribPriority8Value");
            this.Property(t => t.ProductAttribPriority9).HasColumnName("ProductAttribPriority9");
            this.Property(t => t.ProductAttribPriority9Value).HasColumnName("ProductAttribPriority9Value");
            this.Property(t => t.ProductAttribPriority10).HasColumnName("ProductAttribPriority10");
            this.Property(t => t.ProductAttribPriority10Value).HasColumnName("ProductAttribPriority10Value");
            this.Property(t => t.ProductAttribPriority11).HasColumnName("ProductAttribPriority11");
            this.Property(t => t.ProductAttribPriority11Value).HasColumnName("ProductAttribPriority11Value");
            this.Property(t => t.ProductAttribPriority12).HasColumnName("ProductAttribPriority12");
            this.Property(t => t.ProductAttribPriority12Value).HasColumnName("ProductAttribPriority12Value");
            this.Property(t => t.en_item_msds).HasColumnName("en_item_msds");
            this.Property(t => t.NorthAmerica).HasColumnName("NorthAmerica");
            this.Property(t => t.SouthAmerica).HasColumnName("SouthAmerica");
            this.Property(t => t.Europe).HasColumnName("Europe");
            this.Property(t => t.Asia).HasColumnName("Asia");
            this.Property(t => t.Commercial).HasColumnName("Commercial");
            this.Property(t => t.Discontinued).HasColumnName("Discontinued");
            this.Property(t => t.Restricted).HasColumnName("Restricted");
            this.Property(t => t.Other).HasColumnName("Other");
            this.Property(t => t.ProductCategory).HasColumnName("ProductCategory");
            this.Property(t => t.LeafingType).HasColumnName("LeafingType");
            this.Property(t => t.AutomotiveCategory).HasColumnName("AutomotiveCategory");
            this.Property(t => t.PrintingInksCategory).HasColumnName("PrintingInksCategory");
            this.Property(t => t.PlasticsCategory).HasColumnName("PlasticsCategory");
            this.Property(t => t.GeneralIndCategory).HasColumnName("GeneralIndCategory");
            this.Property(t => t.TradeMaintCategory).HasColumnName("TradeMaintCategory");
            this.Property(t => t.PowderCoatCategory).HasColumnName("PowderCoatCategory");
            this.Property(t => t.CosmeticsCategory).HasColumnName("CosmeticsCategory");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Safety).HasColumnName("Safety");
        }
    }
}
