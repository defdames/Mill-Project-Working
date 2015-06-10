using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class channelpartner_product_crossrefMap : EntityTypeConfiguration<channelpartner_product_crossref>
    {
        public channelpartner_product_crossrefMap()
        {
            // Primary Key
            this.HasKey(t => t.en_prod_desc);

            // Properties
            this.Property(t => t.en_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("channelpartner_product_crossref");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
        }
    }
}
