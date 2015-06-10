using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class LnumberMap : EntityTypeConfiguration<Lnumber>
    {
        public LnumberMap()
        {
            // Primary Key
            this.HasKey(t => new { t.key_number, t.Product_Name_, t.Registration_Date_, t.source });

            // Properties
            this.Property(t => t.key_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Product_Name_)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Prefix)
                .HasMaxLength(50);

            this.Property(t => t.Suffix)
                .HasMaxLength(50);

            this.Property(t => t.Brief_description)
                .HasMaxLength(255);

            this.Property(t => t.This_Product_is_Similar_to_)
                .HasMaxLength(50);

            this.Property(t => t.This_product_was_previously_known_as_)
                .HasMaxLength(50);

            this.Property(t => t.Metal_Powder_Type_)
                .HasMaxLength(50);

            this.Property(t => t.Metal_Pigment_Feed_)
                .HasMaxLength(50);

            this.Property(t => t.Solvent_Type1)
                .HasMaxLength(50);

            this.Property(t => t.Solvent_Type2)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.Solvent_Type3)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.Carrier_Type1)
                .HasMaxLength(50);

            this.Property(t => t.Carrier_Type2)
                .HasMaxLength(50);

            this.Property(t => t.Carrier_Type3)
                .HasMaxLength(50);

            this.Property(t => t.Main_Application_)
                .HasMaxLength(50);

            this.Property(t => t.Comments)
                .HasMaxLength(255);

            this.Property(t => t.Old_MSDS_)
                .HasMaxLength(50);

            this.Property(t => t.Sales_Code)
                .HasMaxLength(50);

            this.Property(t => t.Comments2)
                .HasMaxLength(255);

            this.Property(t => t.Comments3)
                .HasMaxLength(255);

            this.Property(t => t.source)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Customer)
                .HasMaxLength(50);

            this.Property(t => t.Agent)
                .HasMaxLength(50);

            this.Property(t => t.Other_Treatment1)
                .HasMaxLength(50);

            this.Property(t => t.Plastisizer_Resin)
                .HasMaxLength(50);

            this.Property(t => t.Other_Treatment2)
                .HasMaxLength(50);

            this.Property(t => t.Other_Treatment3)
                .HasMaxLength(50);

            this.Property(t => t.Per)
                .HasMaxLength(50);

            this.Property(t => t.Rename)
                .HasMaxLength(50);

            this.Property(t => t.Reference)
                .HasMaxLength(50);

            this.Property(t => t.Competative_Offset)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Lnumber");
            this.Property(t => t.key_number).HasColumnName("key number");
            this.Property(t => t.Product_Name_).HasColumnName("Product Name:");
            this.Property(t => t.Prefix).HasColumnName("Prefix");
            this.Property(t => t.Suffix).HasColumnName("Suffix");
            this.Property(t => t.Registration_Date_).HasColumnName("Registration Date:");
            this.Property(t => t.Brief_description).HasColumnName("Brief description");
            this.Property(t => t.Operations_Product_Type_).HasColumnName("Operations Product Type:");
            this.Property(t => t.This_Product_is_Similar_to_).HasColumnName("This Product is Similar to:");
            this.Property(t => t.This_product_was_previously_known_as_).HasColumnName("This product was previously known as:");
            this.Property(t => t.Metal_Powder_Type_).HasColumnName("Metal Powder Type:");
            this.Property(t => t.Metal_Pigment_Feed_).HasColumnName("Metal Pigment Feed:");
            this.Property(t => t.Metal_Pigment_Content_____).HasColumnName("Metal Pigment Content (%):");
            this.Property(t => t.Solvent_Type1).HasColumnName("Solvent Type1");
            this.Property(t => t.Total_Solvent_Content_1).HasColumnName("Total Solvent Content 1");
            this.Property(t => t.Solvent_Type2).HasColumnName("Solvent Type2");
            this.Property(t => t.Total_Solvent_Content2).HasColumnName("Total Solvent Content2");
            this.Property(t => t.Solvent_Type3).HasColumnName("Solvent Type3");
            this.Property(t => t.Total_Solvent_Content3).HasColumnName("Total Solvent Content3");
            this.Property(t => t.Carrier_Type1).HasColumnName("Carrier Type1");
            this.Property(t => t.Total_Carrier_Content1).HasColumnName("Total Carrier Content1");
            this.Property(t => t.Carrier_Type2).HasColumnName("Carrier Type2");
            this.Property(t => t.Total_Carrier_Content2).HasColumnName("Total Carrier Content2");
            this.Property(t => t.Carrier_Type3).HasColumnName("Carrier Type3");
            this.Property(t => t.Total_Carrier_Content3).HasColumnName("Total Carrier Content3");
            this.Property(t => t.Pigment_Median_Particle_Size__µ__).HasColumnName("Pigment Median Particle Size (µ):");
            this.Property(t => t.Main_Application_).HasColumnName("Main Application:");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.Old_MSDS_).HasColumnName("Old MSDS:");
            this.Property(t => t.Sales_Code).HasColumnName("Sales Code");
            this.Property(t => t.Profitability_index).HasColumnName("Profitability index");
            this.Property(t => t.Comments2).HasColumnName("Comments2");
            this.Property(t => t.Comments3).HasColumnName("Comments3");
            this.Property(t => t.source).HasColumnName("source");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.Agent).HasColumnName("Agent");
            this.Property(t => t.Other_Treatment1).HasColumnName("Other Treatment1");
            this.Property(t => t.Plastisizer_Resin).HasColumnName("Plastisizer/Resin");
            this.Property(t => t.Non_Volatile_Content_____).HasColumnName("Non Volatile Content (%):");
            this.Property(t => t.Plastic_Content_____).HasColumnName("Plastic Content (%):");
            this.Property(t => t.Other_Content1).HasColumnName("Other Content1");
            this.Property(t => t.Other_Treatment2).HasColumnName("Other Treatment2");
            this.Property(t => t.Other_Content2).HasColumnName("Other Content2");
            this.Property(t => t.Other_Treatment3).HasColumnName("Other Treatment3");
            this.Property(t => t.Other_Content3).HasColumnName("Other Content3");
            this.Property(t => t.Per).HasColumnName("Per");
            this.Property(t => t.Rename).HasColumnName("Rename");
            this.Property(t => t.Reference).HasColumnName("Reference");
            this.Property(t => t.Competative_Offset).HasColumnName("Competative Offset");
        }
    }
}
