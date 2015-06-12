using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_2012_SM_temp3Map : EntityTypeConfiguration<mis_cube_salesfcst_2012_SM_temp3>
    {
        public mis_cube_salesfcst_2012_SM_temp3Map()
        {
            // Primary Key
            this.HasKey(t => t.item);

            // Properties
            this.Property(t => t.datesold)
                .HasMaxLength(50);

            this.Property(t => t.region)
                .HasMaxLength(200);

            this.Property(t => t.product)
                .HasMaxLength(200);

            this.Property(t => t.salestype)
                .HasMaxLength(200);

            this.Property(t => t.item)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_2012_SM_temp3");
            this.Property(t => t.datesold).HasColumnName("datesold");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.salestype).HasColumnName("salestype");
            this.Property(t => t.dollars).HasColumnName("dollars");
            this.Property(t => t.pounds).HasColumnName("pounds");
            this.Property(t => t.item).HasColumnName("item");
        }
    }
}
