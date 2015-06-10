using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class backorder_by_classMap : EntityTypeConfiguration<backorder_by_class>
    {
        public backorder_by_classMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_hdr_typec, t.Order_No_, t.Product, t.so_dtl_stats, t.so_dtl_shsdt, t.so_prod_shipf, t.so_dtl_key, t.EN_PROD_DESC, t.so_dtl_prmdt, t.so_dtl_reqdt, t.ITEMSTATUS, t.LineStatus, t.OrderDate, t.gl_cmp_key });

            // Properties
            this.Property(t => t.so_hdr_typec)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Order_No_)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Customer)
                .HasMaxLength(30);

            this.Property(t => t.Customer_Class)
                .HasMaxLength(11);

            this.Property(t => t.Product)
                .IsRequired()
                .HasMaxLength(27);

            this.Property(t => t.Product_Class)
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_stats)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_prod_shipf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EN_PROD_DESC)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ITEMSTATUS)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.IN_ABCC)
                .HasMaxLength(2);

            this.Property(t => t.LineStatus)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("backorder_by_class");
            this.Property(t => t.so_hdr_typec).HasColumnName("so_hdr_typec");
            this.Property(t => t.Order_No_).HasColumnName("Order No.");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.Customer_Class).HasColumnName("Customer Class");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.Product_Class).HasColumnName("Product Class");
            this.Property(t => t.openqty).HasColumnName("openqty");
            this.Property(t => t.so_dtl_stats).HasColumnName("so_dtl_stats");
            this.Property(t => t.so_dtl_shsdt).HasColumnName("so_dtl_shsdt");
            this.Property(t => t.so_dtl_shpdt).HasColumnName("so_dtl_shpdt");
            this.Property(t => t.so_prod_shipf).HasColumnName("so_prod_shipf");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.opendollars).HasColumnName("opendollars");
            this.Property(t => t.EN_PROD_DESC).HasColumnName("EN_PROD_DESC");
            this.Property(t => t.so_dtl_prmdt).HasColumnName("so_dtl_prmdt");
            this.Property(t => t.so_dtl_reqdt).HasColumnName("so_dtl_reqdt");
            this.Property(t => t.ITEMSTATUS).HasColumnName("ITEMSTATUS");
            this.Property(t => t.IN_ABCC).HasColumnName("IN_ABCC");
            this.Property(t => t.datedifference).HasColumnName("datedifference");
            this.Property(t => t.LineStatus).HasColumnName("LineStatus");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
        }
    }
}
