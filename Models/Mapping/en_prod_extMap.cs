using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_prod_extMap : EntityTypeConfiguration<en_prod_ext>
    {
        public en_prod_extMap()
        {
            // Primary Key
            this.HasKey(t => t.en_prod_key);

            // Properties
            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_prod_lnumber)
                .HasMaxLength(60);

            this.Property(t => t.en_prod_category)
                .HasMaxLength(1);

            this.Property(t => t.en_prod_newreport)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("en_prod_ext");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.en_prod_lnumcrtdt).HasColumnName("en_prod_lnumcrtdt");
            this.Property(t => t.en_prod_lnumber).HasColumnName("en_prod_lnumber");
            this.Property(t => t.en_prod_category).HasColumnName("en_prod_category");
            this.Property(t => t.en_prod_catnum).HasColumnName("en_prod_catnum");
            this.Property(t => t.en_prod_newreport).HasColumnName("en_prod_newreport");
            this.Property(t => t.en_prod_upcnt).HasColumnName("en_prod_upcnt");
        }
    }
}
