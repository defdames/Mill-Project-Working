using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class suggestionMap : EntityTypeConfiguration<suggestion>
    {
        public suggestionMap()
        {
            // Primary Key
            this.HasKey(t => t.Sug_Num);

            // Properties
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

            this.Property(t => t.Nature_of_Suggestion)
                .HasMaxLength(50);

            this.Property(t => t.Grade)
                .HasMaxLength(50);

            this.Property(t => t.Affected_Department)
                .HasMaxLength(50);

            this.Property(t => t.Suggestion_Taken_By)
                .HasMaxLength(50);

            this.Property(t => t.Written_Response_to_Customer_Required)
                .HasMaxLength(50);

            this.Property(t => t.Silberline_Company)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("suggestion");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Sug_Num).HasColumnName("Sug Num");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.Address_1).HasColumnName("Address 1");
            this.Property(t => t.Address_2).HasColumnName("Address 2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip_Code).HasColumnName("Zip Code");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Telephone_Number).HasColumnName("Telephone Number");
            this.Property(t => t.Spoke_To).HasColumnName("Spoke To");
            this.Property(t => t.Nature_of_Suggestion).HasColumnName("Nature of Suggestion");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.Affected_Department).HasColumnName("Affected Department");
            this.Property(t => t.Describe_Briefly).HasColumnName("Describe Briefly");
            this.Property(t => t.Suggestion_Taken_By).HasColumnName("Suggestion Taken By");
            this.Property(t => t.Written_Response_to_Customer_Required).HasColumnName("Written Response to Customer Required");
            this.Property(t => t.Closed).HasColumnName("Closed");
            this.Property(t => t.Completed_Date).HasColumnName("Completed Date");
            this.Property(t => t.Silberline_Company).HasColumnName("Silberline_Company");
        }
    }
}
