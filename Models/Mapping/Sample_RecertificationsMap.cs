using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Sample_RecertificationsMap : EntityTypeConfiguration<Sample_Recertifications>
    {
        public Sample_RecertificationsMap()
        {
            // Primary Key
            this.HasKey(t => t.Request_Number);

            // Properties
            this.Property(t => t.Requestor)
                .HasMaxLength(255);

            this.Property(t => t.Customer_Name)
                .HasMaxLength(255);

            this.Property(t => t.Address_Line_1)
                .HasMaxLength(255);

            this.Property(t => t.Address_Line_2)
                .HasMaxLength(255);

            this.Property(t => t.State)
                .HasMaxLength(255);

            this.Property(t => t.City)
                .HasMaxLength(255);

            this.Property(t => t.Zip)
                .HasMaxLength(255);

            this.Property(t => t.Country)
                .HasMaxLength(255);

            this.Property(t => t.Product_for_Recertification)
                .HasMaxLength(255);

            this.Property(t => t.Lot_Number)
                .HasMaxLength(255);

            this.Property(t => t.QA_Representative)
                .HasMaxLength(255);

            this.Property(t => t.Shipment_Tracking_Info)
                .HasMaxLength(255);

            this.Property(t => t.Original_Urea)
                .HasMaxLength(255);

            this.Property(t => t.Master_Standard_Lot)
                .HasMaxLength(255);

            this.Property(t => t.Retain_Urea)
                .HasMaxLength(255);

            this.Property(t => t.Retain_DLM110)
                .HasMaxLength(255);

            this.Property(t => t.Return_Urea)
                .HasMaxLength(255);

            this.Property(t => t.Affilliate_Urea)
                .HasMaxLength(255);

            this.Property(t => t.en_ship_key)
                .HasMaxLength(10);

            this.Property(t => t.TGA_Original)
                .HasMaxLength(255);

            this.Property(t => t.TGA_Retain)
                .HasMaxLength(255);

            this.Property(t => t.TGA_Return)
                .HasMaxLength(255);

            this.Property(t => t.TGA_Stock)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Sample_Recertifications");
            this.Property(t => t.Request_Number).HasColumnName("Request Number");
            this.Property(t => t.Date_Submitted).HasColumnName("Date Submitted");
            this.Property(t => t.Requestor).HasColumnName("Requestor");
            this.Property(t => t.Customer_Name).HasColumnName("Customer Name");
            this.Property(t => t.Address_Line_1).HasColumnName("Address Line 1");
            this.Property(t => t.Address_Line_2).HasColumnName("Address Line 2");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Sample_Sent_from_Affilliate).HasColumnName("Sample Sent from Affilliate");
            this.Property(t => t.Sample_Received_from_Affilliate).HasColumnName("Sample Received from Affilliate");
            this.Property(t => t.Product_for_Recertification).HasColumnName("Product for Recertification");
            this.Property(t => t.Lot_Number).HasColumnName("Lot Number");
            this.Property(t => t.Original_NV).HasColumnName("Original NV");
            this.Property(t => t.Retain_NV).HasColumnName("Retain NV");
            this.Property(t => t.Return_NV).HasColumnName("Return NV");
            this.Property(t => t.Affilliate_Stock_NV).HasColumnName("Affilliate Stock NV");
            this.Property(t => t.Original___Leafing).HasColumnName("Original % Leafing");
            this.Property(t => t.Retain___Leafing).HasColumnName("Retain % Leafing");
            this.Property(t => t.Return___Leafing).HasColumnName("Return % Leafing");
            this.Property(t => t.Affilliate_Stock___Leafing).HasColumnName("Affilliate Stock % Leafing");
            this.Property(t => t.Original_D10).HasColumnName("Original D10");
            this.Property(t => t.Retain_D10).HasColumnName("Retain D10");
            this.Property(t => t.Return_D10).HasColumnName("Return D10");
            this.Property(t => t.Affilliate_Stock_D10).HasColumnName("Affilliate Stock D10");
            this.Property(t => t.Original_D50).HasColumnName("Original D50");
            this.Property(t => t.Retain_D50).HasColumnName("Retain D50");
            this.Property(t => t.Return_D50).HasColumnName("Return D50");
            this.Property(t => t.Affilliate_Stock_D50).HasColumnName("Affilliate Stock D50");
            this.Property(t => t.Original_D90).HasColumnName("Original D90");
            this.Property(t => t.Retain_D90).HasColumnName("Retain D90");
            this.Property(t => t.Return_D90).HasColumnName("Return D90");
            this.Property(t => t.Affilliate_Stock_D90).HasColumnName("Affilliate Stock D90");
            this.Property(t => t.Original_200_Mesh).HasColumnName("Original 200 Mesh");
            this.Property(t => t.Retain_200_Mesh).HasColumnName("Retain 200 Mesh");
            this.Property(t => t.Return_200_Mesh).HasColumnName("Return 200 Mesh");
            this.Property(t => t.Affilliate_Stock_200_Mesh).HasColumnName("Affilliate Stock 200 Mesh");
            this.Property(t => t.Original_325_Mesh).HasColumnName("Original 325 Mesh");
            this.Property(t => t.Retain_325_Mesh).HasColumnName("Retain 325 Mesh");
            this.Property(t => t.Return_325_Mesh).HasColumnName("Return 325 Mesh");
            this.Property(t => t.Affilliate_Stock_325_Mesh).HasColumnName("Affilliate Stock 325 Mesh");
            this.Property(t => t.Original_400_Mesh).HasColumnName("Original 400 Mesh");
            this.Property(t => t.Retain_400_Mesh).HasColumnName("Retain 400 Mesh");
            this.Property(t => t.Return_400_Mesh).HasColumnName("Return 400 Mesh");
            this.Property(t => t.Affilliate_Stock_400_Mesh).HasColumnName("Affilliate Stock 400 Mesh");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.Retain_Sample_in_Spec_).HasColumnName("Retain Sample in Spec?");
            this.Property(t => t.Return_Sample_in_Spec_).HasColumnName("Return Sample in Spec?");
            this.Property(t => t.Affilliate_Sample_in_Spec_).HasColumnName("Affilliate Sample in Spec?");
            this.Property(t => t.QA_Representative).HasColumnName("QA Representative");
            this.Property(t => t.QA_Rep_Date).HasColumnName("QA Rep Date");
            this.Property(t => t.Good_to_Use_Until_Date).HasColumnName("Good to Use Until Date");
            this.Property(t => t.Shipment_Tracking_Info).HasColumnName("Shipment Tracking Info");
            this.Property(t => t.Original_H2O).HasColumnName("Original H2O");
            this.Property(t => t.Original_Urea).HasColumnName("Original Urea");
            this.Property(t => t.Original_Hegman).HasColumnName("Original Hegman");
            this.Property(t => t.Original_DLM25).HasColumnName("Original DLM25");
            this.Property(t => t.Original_DLM45).HasColumnName("Original DLM45");
            this.Property(t => t.Original_DLM75).HasColumnName("Original DLM75");
            this.Property(t => t.Original_DLM110).HasColumnName("Original DLM110");
            this.Property(t => t.Original_DLT25).HasColumnName("Original DLT25");
            this.Property(t => t.Original_DLT45).HasColumnName("Original DLT45");
            this.Property(t => t.Original_DLT75).HasColumnName("Original DLT75");
            this.Property(t => t.Original_DLT110).HasColumnName("Original DLT110");
            this.Property(t => t.Master_Standard_Lot).HasColumnName("Master Standard Lot");
            this.Property(t => t.Retain_H2O).HasColumnName("Retain H2O");
            this.Property(t => t.Retain_Urea).HasColumnName("Retain Urea");
            this.Property(t => t.Retain_Hegman).HasColumnName("Retain Hegman");
            this.Property(t => t.Retain_DLM25).HasColumnName("Retain DLM25");
            this.Property(t => t.Retain_DLM45).HasColumnName("Retain DLM45");
            this.Property(t => t.Retain_DLM75).HasColumnName("Retain DLM75");
            this.Property(t => t.Retain_DLM110).HasColumnName("Retain DLM110");
            this.Property(t => t.Retain_DLT25).HasColumnName("Retain DLT25");
            this.Property(t => t.Retain_DLT45).HasColumnName("Retain DLT45");
            this.Property(t => t.Retain_DLT75).HasColumnName("Retain DLT75");
            this.Property(t => t.Retain_DLT110).HasColumnName("Retain DLT110");
            this.Property(t => t.Return_H2O).HasColumnName("Return H2O");
            this.Property(t => t.Return_Urea).HasColumnName("Return Urea");
            this.Property(t => t.Return_Hegman).HasColumnName("Return Hegman");
            this.Property(t => t.Return_DLM25).HasColumnName("Return DLM25");
            this.Property(t => t.Return_DLM45).HasColumnName("Return DLM45");
            this.Property(t => t.Return_DLM75).HasColumnName("Return DLM75");
            this.Property(t => t.Return_DLM110).HasColumnName("Return DLM110");
            this.Property(t => t.Return_DLT25).HasColumnName("Return DLT25");
            this.Property(t => t.Return_DLT45).HasColumnName("Return DLT45");
            this.Property(t => t.Return_DLT75).HasColumnName("Return DLT75");
            this.Property(t => t.Return_DLT110).HasColumnName("Return DLT110");
            this.Property(t => t.Affilliate_H2O).HasColumnName("Affilliate H2O");
            this.Property(t => t.Affilliate_Urea).HasColumnName("Affilliate Urea");
            this.Property(t => t.Affilliate_Hegman).HasColumnName("Affilliate Hegman");
            this.Property(t => t.Affilliate_DLM25).HasColumnName("Affilliate DLM25");
            this.Property(t => t.Affilliate_DLM45).HasColumnName("Affilliate DLM45");
            this.Property(t => t.Affilliate_DLM75).HasColumnName("Affilliate DLM75");
            this.Property(t => t.Affilliate_DLM_110).HasColumnName("Affilliate DLM 110");
            this.Property(t => t.Affilliate_DLT25).HasColumnName("Affilliate DLT25");
            this.Property(t => t.Affilliate_DLT45).HasColumnName("Affilliate DLT45");
            this.Property(t => t.Affilliate_DLT75).HasColumnName("Affilliate DLT75");
            this.Property(t => t.Affilliate_DLT_110).HasColumnName("Affilliate DLT 110");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.TGA_Original).HasColumnName("TGA Original");
            this.Property(t => t.TGA_Retain).HasColumnName("TGA Retain");
            this.Property(t => t.TGA_Return).HasColumnName("TGA Return");
            this.Property(t => t.TGA_Stock).HasColumnName("TGA Stock");

            // Relationships
            this.HasOptional(t => t.en_ship_tbl)
                .WithMany(t => t.Sample_Recertifications)
                .HasForeignKey(d => d.en_ship_key);

        }
    }
}
