using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Price_Deviation_Authorization_Data_TableMap : EntityTypeConfiguration<Price_Deviation_Authorization_Data_Table>
    {
        public Price_Deviation_Authorization_Data_TableMap()
        {
            // Primary Key
            this.HasKey(t => t.Request_No);

            // Properties
            this.Property(t => t.Requested_By)
                .HasMaxLength(50);

            this.Property(t => t.Approved_By)
                .HasMaxLength(50);

            this.Property(t => t.Declined_By)
                .HasMaxLength(50);

            this.Property(t => t.Market)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Product_Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UOM)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Currency)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Rebate_Program)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Payment_Terms)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Freight_Terms)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Competitor)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Competitive_Product)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Customer_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ship_To_City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Bill_To_City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ship_To_State)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Bill_To_State)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Multi_National)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Zone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Channel_Partner)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Channel_Partner_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Commision)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Contact_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Contact_Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Freight_Support)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Customer_Ship_To_Country)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Customer_Bill_To_Country)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustPhone)
                .HasMaxLength(50);

            this.Property(t => t.CustEmail)
                .HasMaxLength(50);

            this.Property(t => t.Entity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Break_Pallet)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Freight_Allowance)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Repack)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Price Deviation Authorization Data Table");
            this.Property(t => t.Request_No).HasColumnName("Request No");
            this.Property(t => t.Requested_By).HasColumnName("Requested By");
            this.Property(t => t.Request_Date).HasColumnName("Request Date");
            this.Property(t => t.Approved_By).HasColumnName("Approved By");
            this.Property(t => t.Declined_By).HasColumnName("Declined By");
            this.Property(t => t.Approved_Date).HasColumnName("Approved Date");
            this.Property(t => t.Declined_Date).HasColumnName("Declined Date");
            this.Property(t => t.Market).HasColumnName("Market");
            this.Property(t => t.Product_Code).HasColumnName("Product Code");
            this.Property(t => t.UOM).HasColumnName("UOM");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.Rebate_Program).HasColumnName("Rebate Program");
            this.Property(t => t.List_Price).HasColumnName("List Price");
            this.Property(t => t.Current_Price).HasColumnName("Current Price");
            this.Property(t => t.New_Requested_Price).HasColumnName("New Requested Price");
            this.Property(t => t.Minimum_Order_Quantity).HasColumnName("Minimum Order Quantity");
            this.Property(t => t.Payment_Terms).HasColumnName("Payment Terms");
            this.Property(t => t.Effective_Date).HasColumnName("Effective Date");
            this.Property(t => t.Expiration_Date).HasColumnName("Expiration Date");
            this.Property(t => t.Freight_Terms).HasColumnName("Freight Terms");
            this.Property(t => t.Competitor).HasColumnName("Competitor");
            this.Property(t => t.Competitive_Product).HasColumnName("Competitive Product");
            this.Property(t => t.Competitive_Price).HasColumnName("Competitive Price");
            this.Property(t => t.Customer_Name).HasColumnName("Customer Name");
            this.Property(t => t.Ship_To_City).HasColumnName("Ship To City");
            this.Property(t => t.Bill_To_City).HasColumnName("Bill To City");
            this.Property(t => t.Ship_To_State).HasColumnName("Ship To State");
            this.Property(t => t.Bill_To_State).HasColumnName("Bill To State");
            this.Property(t => t.Multi_National).HasColumnName("Multi National");
            this.Property(t => t.Zone).HasColumnName("Zone");
            this.Property(t => t.Channel_Partner).HasColumnName("Channel Partner");
            this.Property(t => t.Channel_Partner_Name).HasColumnName("Channel Partner Name");
            this.Property(t => t.Commision).HasColumnName("Commision");
            this.Property(t => t.Commission_Percent).HasColumnName("Commission Percent");
            this.Property(t => t.Additional_Information).HasColumnName("Additional Information");
            this.Property(t => t.Contact_Name).HasColumnName("Contact Name");
            this.Property(t => t.Contact_Title).HasColumnName("Contact Title");
            this.Property(t => t.Freight_Support).HasColumnName("Freight Support");
            this.Property(t => t.Customer_Ship_To_Country).HasColumnName("Customer Ship To Country");
            this.Property(t => t.Customer_Bill_To_Country).HasColumnName("Customer Bill To Country");
            this.Property(t => t.CustPhone).HasColumnName("CustPhone");
            this.Property(t => t.CustEmail).HasColumnName("CustEmail");
            this.Property(t => t.Entity).HasColumnName("Entity");
            this.Property(t => t.Break_Pallet).HasColumnName("Break_Pallet");
            this.Property(t => t.Freight_Allowance).HasColumnName("Freight_Allowance");
            this.Property(t => t.Repack).HasColumnName("Repack");
        }
    }
}
