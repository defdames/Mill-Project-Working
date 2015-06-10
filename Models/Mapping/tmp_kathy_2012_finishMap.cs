using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_kathy_2012_finishMap : EntityTypeConfiguration<tmp_kathy_2012_finish>
    {
        public tmp_kathy_2012_finishMap()
        {
            // Primary Key
            this.HasKey(t => t.newmarket);

            // Properties
            this.Property(t => t.Channel_Partner)
                .HasMaxLength(255);

            this.Property(t => t.Market)
                .HasMaxLength(255);

            this.Property(t => t.Product_Description)
                .HasMaxLength(255);

            this.Property(t => t.en_item_key)
                .HasMaxLength(255);

            this.Property(t => t.Customer)
                .HasMaxLength(255);

            this.Property(t => t.Location)
                .HasMaxLength(255);

            this.Property(t => t.newmarket)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tmp_kathy_2012_finish");
            this.Property(t => t.Channel_Partner).HasColumnName("Channel Partner");
            this.Property(t => t.Market).HasColumnName("Market");
            this.Property(t => t.Product_Description).HasColumnName("Product Description");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.July_2011_YTD_Pounds).HasColumnName("July 2011 YTD Pounds");
            this.Property(t => t.C2010_Pounds).HasColumnName("2010 Pounds");
            this.Property(t => t.C12_Month_Rolling_Pounds).HasColumnName("12 Month Rolling Pounds");
            this.Property(t => t.July_2011_YTD_Dollars).HasColumnName("July 2011 YTD Dollars");
            this.Property(t => t.C2010_Dollars).HasColumnName("2010 Dollars");
            this.Property(t => t.C12_Month_Rolling_Pounds1).HasColumnName("12 Month Rolling Pounds1");
            this.Property(t => t.SMC_Single_Drum_Price).HasColumnName("SMC Single Drum Price");
            this.Property(t => t.AVG_Price_lb).HasColumnName("AVG Price/lb");
            this.Property(t => t.C2012_Forecast_Pounds).HasColumnName("2012 Forecast Pounds");
            this.Property(t => t.Pre_Increase_Forecast__).HasColumnName("Pre-Increase Forecast $");
            this.Property(t => t.C__INCREASE).HasColumnName("% INCREASE");
            this.Property(t => t.C__INCREASE1).HasColumnName("$ INCREASE");
            this.Property(t => t.Forecast_Dollars_Total).HasColumnName("Forecast Dollars Total");
            this.Property(t => t.newmarket).HasColumnName("newmarket");
        }
    }
}
