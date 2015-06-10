using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Phone_Log_Tbl_oldMap : EntityTypeConfiguration<Phone_Log_Tbl_old>
    {
        public Phone_Log_Tbl_oldMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Silberline_contact)
                .HasMaxLength(255);

            this.Property(t => t.Contact_Name)
                .HasMaxLength(255);

            this.Property(t => t.Contact_Address)
                .HasMaxLength(255);

            this.Property(t => t.Contact_Phone_No)
                .HasMaxLength(255);

            this.Property(t => t.Contact_Company)
                .HasMaxLength(255);

            this.Property(t => t.Market_Segment)
                .HasMaxLength(255);

            this.Property(t => t.Grades_Requested)
                .HasMaxLength(255);

            this.Property(t => t.Quantity_Requested)
                .HasMaxLength(255);

            this.Property(t => t.Literature_Requested)
                .HasMaxLength(255);

            this.Property(t => t.Ship_When)
                .HasMaxLength(255);

            this.Property(t => t.Ship_Via)
                .HasMaxLength(255);

            this.Property(t => t.Fax_Number)
                .HasMaxLength(20);

            this.Property(t => t.Email_Address)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Phone Log Tbl old");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.Silberline_contact).HasColumnName("Silberline contact");
            this.Property(t => t.Contact_Name).HasColumnName("Contact Name");
            this.Property(t => t.Contact_Address).HasColumnName("Contact Address");
            this.Property(t => t.Contact_Phone_No).HasColumnName("Contact Phone No");
            this.Property(t => t.Contact_Company).HasColumnName("Contact Company");
            this.Property(t => t.Market_Segment).HasColumnName("Market Segment");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.Samples_Requested_).HasColumnName("Samples Requested?");
            this.Property(t => t.Application_Notes).HasColumnName("Application Notes");
            this.Property(t => t.Grades_Requested).HasColumnName("Grades Requested");
            this.Property(t => t.Quantity_Requested).HasColumnName("Quantity Requested");
            this.Property(t => t.Literature_Requested).HasColumnName("Literature Requested");
            this.Property(t => t.Ship_When).HasColumnName("Ship When");
            this.Property(t => t.Ship_Via).HasColumnName("Ship Via");
            this.Property(t => t.Fax_Number).HasColumnName("Fax Number");
            this.Property(t => t.Email_Address).HasColumnName("Email Address");
        }
    }
}
