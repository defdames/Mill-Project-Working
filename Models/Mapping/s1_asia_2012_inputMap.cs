using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class s1_asia_2012_inputMap : EntityTypeConfiguration<s1_asia_2012_input>
    {
        public s1_asia_2012_inputMap()
        {
            // Primary Key
            this.HasKey(t => new { t.customer, t.country, t.product });

            // Properties
            this.Property(t => t.customer)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.country)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.product)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.comments)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("s1_asia_2012_input");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.C2013_FCST_Qty).HasColumnName("2013 FCST Qty");
            this.Property(t => t.C2013_FCST____).HasColumnName("2013 FCST $$$");
            this.Property(t => t.comments).HasColumnName("comments");
        }
    }
}
