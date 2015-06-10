using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Confidentiality_TableMap : EntityTypeConfiguration<Confidentiality_Table>
    {
        public Confidentiality_TableMap()
        {
            // Primary Key
            this.HasKey(t => t.AgreeID);

            // Properties
            this.Property(t => t.Silberline_Entity)
                .HasMaxLength(50);

            this.Property(t => t.Term_of_Agreement)
                .HasMaxLength(50);

            this.Property(t => t.Company_Name)
                .HasMaxLength(50);

            this.Property(t => t.Disclosee)
                .HasMaxLength(50);

            this.Property(t => t.Disclosee_Title)
                .HasMaxLength(50);

            this.Property(t => t.Type_of_Agreement)
                .HasMaxLength(50);

            this.Property(t => t.Silberline_Rep)
                .HasMaxLength(50);

            this.Property(t => t.Special_Notes)
                .HasMaxLength(50);

            this.Property(t => t.Agreement_Status)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Confidentiality_Table");
            this.Property(t => t.AgreeID).HasColumnName("AgreeID");
            this.Property(t => t.Silberline_Entity).HasColumnName("Silberline Entity");
            this.Property(t => t.Execution_Date).HasColumnName("Execution Date");
            this.Property(t => t.Term_of_Agreement).HasColumnName("Term of Agreement");
            this.Property(t => t.Expiration_Date).HasColumnName("Expiration Date");
            this.Property(t => t.Purpose).HasColumnName("Purpose");
            this.Property(t => t.Company_Name).HasColumnName("Company Name");
            this.Property(t => t.Company_Address).HasColumnName("Company Address");
            this.Property(t => t.Disclosee).HasColumnName("Disclosee");
            this.Property(t => t.Disclosee_Title).HasColumnName("Disclosee Title");
            this.Property(t => t.Type_of_Agreement).HasColumnName("Type of Agreement");
            this.Property(t => t.Silberline_Rep).HasColumnName("Silberline Rep");
            this.Property(t => t.Special_Notes).HasColumnName("Special Notes");
            this.Property(t => t.Agreement_Status).HasColumnName("Agreement_Status");
        }
    }
}
