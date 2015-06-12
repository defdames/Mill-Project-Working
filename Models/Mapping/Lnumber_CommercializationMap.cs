using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Lnumber_CommercializationMap : EntityTypeConfiguration<Lnumber_Commercialization>
    {
        public Lnumber_CommercializationMap()
        {
            // Primary Key
            this.HasKey(t => t.Lnumber);

            // Properties
            this.Property(t => t.Lnumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Commercialized)
                .HasMaxLength(50);

            this.Property(t => t.Promoted)
                .HasMaxLength(50);

            this.Property(t => t.Sampling)
                .HasMaxLength(50);

            this.Property(t => t.Target_Market)
                .HasMaxLength(50);

            this.Property(t => t.Market_Manager)
                .HasMaxLength(50);

            this.Property(t => t.Technical_Contact)
                .HasMaxLength(50);

            this.Property(t => t.PDS_Initiated)
                .HasMaxLength(50);

            this.Property(t => t.PDS_Complete)
                .HasMaxLength(50);

            this.Property(t => t.Price_Initiated)
                .HasMaxLength(50);

            this.Property(t => t.Price_Complete)
                .HasMaxLength(50);

            this.Property(t => t.Single_Drum_List)
                .HasMaxLength(50);

            this.Property(t => t.In_Adage)
                .HasMaxLength(50);

            this.Property(t => t.Affiliates)
                .HasMaxLength(50);

            this.Property(t => t.Scale_up)
                .HasMaxLength(50);

            this.Property(t => t.Promote)
                .HasMaxLength(50);

            this.Property(t => t.Trade_Name)
                .HasMaxLength(50);

            this.Property(t => t.Announcement)
                .HasMaxLength(50);

            this.Property(t => t.Commercially_Avail)
                .HasMaxLength(50);

            this.Property(t => t.Display_Reqs)
                .HasMaxLength(50);

            this.Property(t => t.secondary_market)
                .HasMaxLength(50);

            this.Property(t => t.commercial_position)
                .HasMaxLength(50);

            this.Property(t => t.Adage_Item_Code)
                .HasMaxLength(50);

            this.Property(t => t.accepting_orders)
                .HasMaxLength(50);

            this.Property(t => t.initial_sample_stock)
                .HasMaxLength(50);

            this.Property(t => t.display_created)
                .HasMaxLength(50);

            this.Property(t => t.Flyer)
                .HasMaxLength(50);

            this.Property(t => t.trade_journal)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Lnumber Commercialization");
            this.Property(t => t.Lnumber).HasColumnName("Lnumber");
            this.Property(t => t.Commercialized).HasColumnName("Commercialized");
            this.Property(t => t.Promoted).HasColumnName("Promoted");
            this.Property(t => t.Sampling).HasColumnName("Sampling");
            this.Property(t => t.GenDescrption).HasColumnName("GenDescrption");
            this.Property(t => t.Target_Market).HasColumnName("Target_Market");
            this.Property(t => t.Market_Manager).HasColumnName("Market_Manager");
            this.Property(t => t.Technical_Contact).HasColumnName("Technical_Contact");
            this.Property(t => t.PDS_Initiated).HasColumnName("PDS_Initiated");
            this.Property(t => t.PDS_Complete).HasColumnName("PDS_Complete");
            this.Property(t => t.Price_Initiated).HasColumnName("Price_Initiated");
            this.Property(t => t.Price_Complete).HasColumnName("Price_Complete");
            this.Property(t => t.Single_Drum_List).HasColumnName("Single_Drum_List");
            this.Property(t => t.In_Adage).HasColumnName("In_Adage");
            this.Property(t => t.Affiliates).HasColumnName("Affiliates");
            this.Property(t => t.Scale_up).HasColumnName("Scale-up");
            this.Property(t => t.Scale_up_Status).HasColumnName("Scale-up Status");
            this.Property(t => t.Promote).HasColumnName("Promote");
            this.Property(t => t.Trade_Name).HasColumnName("Trade_Name");
            this.Property(t => t.Announcement).HasColumnName("Announcement");
            this.Property(t => t.Commercially_Avail).HasColumnName("Commercially_Avail");
            this.Property(t => t.Display_Reqs).HasColumnName("Display_Reqs");
            this.Property(t => t.Display_Desc).HasColumnName("Display_Desc");
            this.Property(t => t.Silberflash).HasColumnName("Silberflash");
            this.Property(t => t.Prod_Brochure).HasColumnName("Prod_Brochure");
            this.Property(t => t.Literature_Desc).HasColumnName("Literature_Desc");
            this.Property(t => t.sample_restriction).HasColumnName("sample_restriction");
            this.Property(t => t.promotion_guidlines).HasColumnName("promotion_guidlines");
            this.Property(t => t.secondary_market).HasColumnName("secondary_market");
            this.Property(t => t.commercial_position).HasColumnName("commercial_position");
            this.Property(t => t.Adage_Item_Code).HasColumnName("Adage_Item_Code");
            this.Property(t => t.accepting_orders).HasColumnName("accepting_orders");
            this.Property(t => t.initial_sample_stock).HasColumnName("initial_sample_stock");
            this.Property(t => t.display_created).HasColumnName("display_created");
            this.Property(t => t.Flyer).HasColumnName("Flyer");
            this.Property(t => t.trade_journal).HasColumnName("trade_journal");
            this.Property(t => t.change_date).HasColumnName("change_date");
        }
    }
}
