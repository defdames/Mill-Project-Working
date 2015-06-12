using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_ship_extMap : EntityTypeConfiguration<en_ship_ext>
    {
        public en_ship_extMap()
        {
            // Primary Key
            this.HasKey(t => t.en_ship_key);

            // Properties
            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.target)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.whseacct)
                .HasMaxLength(10);

            this.Property(t => t.top_customer_name)
                .HasMaxLength(30);

            this.Property(t => t.city)
                .HasMaxLength(80);

            this.Property(t => t.state)
                .HasMaxLength(2);

            this.Property(t => t.customer_whse)
                .HasMaxLength(10);

            this.Property(t => t.f1direct)
                .HasMaxLength(1);

            this.Property(t => t.zmsds_addr_1)
                .HasMaxLength(60);

            this.Property(t => t.zmsds_addr_2)
                .HasMaxLength(60);

            this.Property(t => t.zmsds_addr_3)
                .HasMaxLength(60);

            this.Property(t => t.zmsds_addr_4)
                .HasMaxLength(60);

            this.Property(t => t.market_primary)
                .HasMaxLength(1);

            this.Property(t => t.market_secondary)
                .HasMaxLength(1);

            this.Property(t => t.zmsds_email)
                .HasMaxLength(255);

            this.Property(t => t.xconsignment)
                .HasMaxLength(10);

            this.Property(t => t.aextended_ship_name)
                .HasMaxLength(80);

            this.Property(t => t.xref_ship_to_name)
                .HasMaxLength(20);

            this.Property(t => t.salesmgr)
                .HasMaxLength(30);

            this.Property(t => t.sample_en_ship_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_ship_ext");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.target).HasColumnName("target");
            this.Property(t => t.whseacct).HasColumnName("whseacct");
            this.Property(t => t.top_customer_name).HasColumnName("top_customer_name");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.customer_whse).HasColumnName("customer_whse");
            this.Property(t => t.f1direct).HasColumnName("f1direct");
            this.Property(t => t.zmsds_addr_1).HasColumnName("zmsds_addr_1");
            this.Property(t => t.zmsds_addr_2).HasColumnName("zmsds_addr_2");
            this.Property(t => t.zmsds_addr_3).HasColumnName("zmsds_addr_3");
            this.Property(t => t.zmsds_addr_4).HasColumnName("zmsds_addr_4");
            this.Property(t => t.market_primary).HasColumnName("market_primary");
            this.Property(t => t.market_secondary).HasColumnName("market_secondary");
            this.Property(t => t.zmsds_email).HasColumnName("zmsds_email");
            this.Property(t => t.xconsignment).HasColumnName("xconsignment");
            this.Property(t => t.aextended_ship_name).HasColumnName("aextended_ship_name");
            this.Property(t => t.xref_ship_to_name).HasColumnName("xref_ship_to_name");
            this.Property(t => t.en_ship_upcnt).HasColumnName("en_ship_upcnt");
            this.Property(t => t.salesmgr).HasColumnName("salesmgr");
            this.Property(t => t.sample_en_ship_key).HasColumnName("sample_en_ship_key");
        }
    }
}
