using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class TSRMap : EntityTypeConfiguration<TSR>
    {
        public TSRMap()
        {
            // Primary Key
            this.HasKey(t => t.TSR_Number);

            // Properties
            this.Property(t => t.Submitter)
                .HasMaxLength(25);

            this.Property(t => t.Agent)
                .HasMaxLength(25);

            this.Property(t => t.Regional_Manager)
                .HasMaxLength(50);

            this.Property(t => t.Customer)
                .HasMaxLength(255);

            this.Property(t => t.Address)
                .HasMaxLength(50);

            this.Property(t => t.Address1)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .HasMaxLength(20);

            this.Property(t => t.Customer_Contact)
                .HasMaxLength(25);

            this.Property(t => t.Phone)
                .HasMaxLength(20);

            this.Property(t => t.fax)
                .HasMaxLength(20);

            this.Property(t => t.Grade_Number)
                .HasMaxLength(20);

            this.Property(t => t.Discussed_with)
                .HasMaxLength(50);

            this.Property(t => t.Vehical_Type)
                .HasMaxLength(50);

            this.Property(t => t.Product_End_Use)
                .HasMaxLength(20);

            this.Property(t => t.Market)
                .HasMaxLength(20);

            this.Property(t => t.Tech_Service_Assigned)
                .HasMaxLength(50);

            this.Property(t => t.Request_Fully_Complete)
                .HasMaxLength(25);

            this.Property(t => t.Number)
                .HasMaxLength(20);

            this.Property(t => t.Respond_To)
                .HasMaxLength(50);

            this.Property(t => t.reason)
                .HasMaxLength(50);

            this.Property(t => t.vehicle)
                .HasMaxLength(25);

            this.Property(t => t.potential_market_size__lb_)
                .HasMaxLength(50);

            this.Property(t => t.price_ceiling_target)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TSR");
            this.Property(t => t.TSR_Number).HasColumnName("TSR Number");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Request_Complete_).HasColumnName("Request Complete?");
            this.Property(t => t.Submitter).HasColumnName("Submitter");
            this.Property(t => t.Agent).HasColumnName("Agent");
            this.Property(t => t.Regional_Manager).HasColumnName("Regional Manager");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Customer_Contact).HasColumnName("Customer Contact");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.Requested_Completion_Date).HasColumnName("Requested Completion Date");
            this.Property(t => t.Grade_Number).HasColumnName("Grade Number");
            this.Property(t => t.Competitive_Analysis).HasColumnName("Competitive Analysis");
            this.Property(t => t.Product_Modification).HasColumnName("Product Modification");
            this.Property(t => t.New_Product).HasColumnName("New Product");
            this.Property(t => t.New_Customer).HasColumnName("New Customer");
            this.Property(t => t.Performance_Assistance).HasColumnName("Performance Assistance");
            this.Property(t => t.Application_Assistance).HasColumnName("Application Assistance");
            this.Property(t => t.Formulation_Assistance).HasColumnName("Formulation Assistance");
            this.Property(t => t.Sales_Aids).HasColumnName("Sales Aids");
            this.Property(t => t.Master_Standard).HasColumnName("Master Standard");
            this.Property(t => t.Experimental_Request).HasColumnName("Experimental Request");
            this.Property(t => t.Panels_Chips).HasColumnName("Panels/Chips");
            this.Property(t => t.Others).HasColumnName("Others");
            this.Property(t => t.Describe_Objective).HasColumnName("Describe Objective");
            this.Property(t => t.Request_from_Tech_Service).HasColumnName("Request from Tech Service");
            this.Property(t => t.Discussed_with).HasColumnName("Discussed with");
            this.Property(t => t.MSDS).HasColumnName("MSDS");
            this.Property(t => t.Vehical_Type).HasColumnName("Vehical Type");
            this.Property(t => t.Product_End_Use).HasColumnName("Product End Use");
            this.Property(t => t.Market).HasColumnName("Market");
            this.Property(t => t.Tech_Service_Assigned).HasColumnName("Tech Service Assigned");
            this.Property(t => t.Date_Tech_Service_Assigned).HasColumnName("Date Tech Service Assigned");
            this.Property(t => t.Request_Fully_Complete).HasColumnName("Request Fully Complete");
            this.Property(t => t.Date_Request_Fully_Complete).HasColumnName("Date Request Fully Complete");
            this.Property(t => t.Customer_Tech_Comlaint_Form_Filed).HasColumnName("Customer Tech Comlaint Form Filed");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.Respond_To).HasColumnName("Respond To");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.hold).HasColumnName("hold");
            this.Property(t => t.hold_date).HasColumnName("hold_date");
            this.Property(t => t.reopen_date).HasColumnName("reopen_date");
            this.Property(t => t.reason).HasColumnName("reason");
            this.Property(t => t.vehicle).HasColumnName("vehicle");
            this.Property(t => t.complaints).HasColumnName("complaints");
            this.Property(t => t.production_support).HasColumnName("production support");
            this.Property(t => t.potential_market_size__lb_).HasColumnName("potential market size (lb)");
            this.Property(t => t.price_ceiling_target).HasColumnName("price ceiling/target");
        }
    }
}
