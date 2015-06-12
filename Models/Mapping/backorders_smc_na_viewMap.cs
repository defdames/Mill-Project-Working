using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class backorders_smc_na_viewMap : EntityTypeConfiguration<backorders_smc_na_view>
    {
        public backorders_smc_na_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.order_no_, t.product, t.en_prod_desc, t.orderdate, t.so_dtl_reqdt, t.so_dtl_prmdt, t.gl_cmp_key, t.gl_crncy_key });

            // Properties
            this.Property(t => t.order_no_)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.customer)
                .HasMaxLength(30);

            this.Property(t => t.product)
                .IsRequired()
                .HasMaxLength(27);

            this.Property(t => t.en_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("backorders_smc_na_view");
            this.Property(t => t.order_no_).HasColumnName("order no.");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
            this.Property(t => t.openqty).HasColumnName("openqty");
            this.Property(t => t.opendollars).HasColumnName("opendollars");
            this.Property(t => t.orderdate).HasColumnName("orderdate");
            this.Property(t => t.so_dtl_reqdt).HasColumnName("so_dtl_reqdt");
            this.Property(t => t.so_dtl_prmdt).HasColumnName("so_dtl_prmdt");
            this.Property(t => t.datedifference).HasColumnName("datedifference");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
        }
    }
}
