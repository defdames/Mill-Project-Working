using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_2012_SM_temp2_1Map : EntityTypeConfiguration<mis_cube_salesfcst_2012_SM_temp2_1>
    {
        public mis_cube_salesfcst_2012_SM_temp2_1Map()
        {
            // Primary Key
            this.HasKey(t => t.product_type);

            // Properties
            this.Property(t => t.region)
                .HasMaxLength(200);

            this.Property(t => t.product_type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sales_type)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_2012_SM_temp2_1");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.product_type).HasColumnName("product type");
            this.Property(t => t.sales_type).HasColumnName("sales type");
            this.Property(t => t.dollars).HasColumnName("dollars");
            this.Property(t => t.pounds).HasColumnName("pounds");
        }
    }
}
