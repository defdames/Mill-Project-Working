using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class NonTechnical_SummaryMap : EntityTypeConfiguration<NonTechnical_Summary>
    {
        public NonTechnical_SummaryMap()
        {
            // Primary Key
            this.HasKey(t => t.NTC_Num);

            // Properties
            this.Property(t => t.Agent)
                .HasMaxLength(255);

            this.Property(t => t.Agent_Involved)
                .HasMaxLength(50);

            this.Property(t => t.Customer)
                .HasMaxLength(50);

            this.Property(t => t.Address_1)
                .HasMaxLength(50);

            this.Property(t => t.Address_2)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.Zip_Code)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            this.Property(t => t.Telephone_Number)
                .HasMaxLength(50);

            this.Property(t => t.Spoke_To)
                .HasMaxLength(50);

            this.Property(t => t.Nature_of_Complaint)
                .HasMaxLength(50);

            this.Property(t => t.Grade)
                .HasMaxLength(50);

            this.Property(t => t.Lot_Number)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            this.Property(t => t.Complaint_Taken_By)
                .HasMaxLength(50);

            this.Property(t => t.Written_Response_to_Customer_Required)
                .HasMaxLength(50);

            this.Property(t => t.Root_Signature)
                .HasMaxLength(50);

            this.Property(t => t.Corrective_Signature)
                .HasMaxLength(50);

            this.Property(t => t.Corrective_Date)
                .HasMaxLength(50);

            this.Property(t => t.Preventative_Signature)
                .HasMaxLength(50);

            this.Property(t => t.Customer_Contacted_By)
                .HasMaxLength(50);

            this.Property(t => t.Valid)
                .HasMaxLength(50);

            this.Property(t => t.Signature)
                .HasMaxLength(50);

            this.Property(t => t.Company)
                .HasMaxLength(10);

            this.Property(t => t.Reason_Category)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NonTechnical Summary");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Agent).HasColumnName("Agent");
            this.Property(t => t.Agent_Involved).HasColumnName("Agent Involved");
            this.Property(t => t.NTC_Num).HasColumnName("NTC Num");
            this.Property(t => t.Estimated_Complete_Date).HasColumnName("Estimated Complete Date");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.Address_1).HasColumnName("Address 1");
            this.Property(t => t.Address_2).HasColumnName("Address 2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip_Code).HasColumnName("Zip Code");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Telephone_Number).HasColumnName("Telephone Number");
            this.Property(t => t.Spoke_To).HasColumnName("Spoke To");
            this.Property(t => t.Nature_of_Complaint).HasColumnName("Nature of Complaint");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.Lot_Number).HasColumnName("Lot Number");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Describe_Briefly).HasColumnName("Describe Briefly");
            this.Property(t => t.Complaint_Taken_By).HasColumnName("Complaint Taken By");
            this.Property(t => t.Written_Response_to_Customer_Required).HasColumnName("Written Response to Customer Required");
            this.Property(t => t.Root_Cause).HasColumnName("Root Cause");
            this.Property(t => t.Root_Signature).HasColumnName("Root Signature");
            this.Property(t => t.Root_Date).HasColumnName("Root Date");
            this.Property(t => t.Corrective_Action).HasColumnName("Corrective Action");
            this.Property(t => t.Corrective_Signature).HasColumnName("Corrective Signature");
            this.Property(t => t.Corrective_Date).HasColumnName("Corrective Date");
            this.Property(t => t.Preventative_Action).HasColumnName("Preventative Action");
            this.Property(t => t.Preventative_Signature).HasColumnName("Preventative Signature");
            this.Property(t => t.Preventative_Date).HasColumnName("Preventative Date");
            this.Property(t => t.Customer_Contacted_By).HasColumnName("Customer Contacted By");
            this.Property(t => t.Contacted_On).HasColumnName("Contacted On");
            this.Property(t => t.Valid).HasColumnName("Valid");
            this.Property(t => t.Closed).HasColumnName("Closed");
            this.Property(t => t.Signature).HasColumnName("Signature");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Reason_Category).HasColumnName("Reason Category");
            this.Property(t => t.Completed_Date).HasColumnName("Completed Date");
        }
    }
}
