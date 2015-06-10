using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class customer_bill_ship_address_listMap : EntityTypeConfiguration<customer_bill_ship_address_list>
    {
        public customer_bill_ship_address_listMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ar_stats_key, t.en_cust_key, t.custname, t.custline1, t.custline2, t.custline3, t.custcity, t.custstate, t.custcntry, t.custzip, t.ar_bill_key, t.billname, t.billline1, t.billline2, t.billline3, t.billcity, t.billstate, t.billcntry, t.billzip, t.ar_ship_key, t.shipname, t.shipline1, t.shipline2, t.shipline3, t.shipcity, t.shipstate, t.shipcntry, t.shipzip });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.ar_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.custname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.custline1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.custline2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.custline3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.custcity)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.custstate)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.custcntry)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.custzip)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.billname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.billline1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.billline2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.billline3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.billcity)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.billstate)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.billcntry)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.billzip)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.shipname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.shipline1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.shipline2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.shipline3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.shipcity)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.shipstate)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.shipcntry)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.shipzip)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("customer_bill_ship_address_list");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_stats_key).HasColumnName("ar_stats_key");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.custname).HasColumnName("custname");
            this.Property(t => t.custline1).HasColumnName("custline1");
            this.Property(t => t.custline2).HasColumnName("custline2");
            this.Property(t => t.custline3).HasColumnName("custline3");
            this.Property(t => t.custcity).HasColumnName("custcity");
            this.Property(t => t.custstate).HasColumnName("custstate");
            this.Property(t => t.custcntry).HasColumnName("custcntry");
            this.Property(t => t.custzip).HasColumnName("custzip");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.billname).HasColumnName("billname");
            this.Property(t => t.billline1).HasColumnName("billline1");
            this.Property(t => t.billline2).HasColumnName("billline2");
            this.Property(t => t.billline3).HasColumnName("billline3");
            this.Property(t => t.billcity).HasColumnName("billcity");
            this.Property(t => t.billstate).HasColumnName("billstate");
            this.Property(t => t.billcntry).HasColumnName("billcntry");
            this.Property(t => t.billzip).HasColumnName("billzip");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.shipname).HasColumnName("shipname");
            this.Property(t => t.shipline1).HasColumnName("shipline1");
            this.Property(t => t.shipline2).HasColumnName("shipline2");
            this.Property(t => t.shipline3).HasColumnName("shipline3");
            this.Property(t => t.shipcity).HasColumnName("shipcity");
            this.Property(t => t.shipstate).HasColumnName("shipstate");
            this.Property(t => t.shipcntry).HasColumnName("shipcntry");
            this.Property(t => t.shipzip).HasColumnName("shipzip");
        }
    }
}
