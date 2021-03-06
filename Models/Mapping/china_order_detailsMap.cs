using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class china_order_detailsMap : EntityTypeConfiguration<china_order_details>
    {
        public china_order_detailsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_hdr_key, t.so_dtl_key });

            // Properties
            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_mktseg_key)
                .HasMaxLength(20);

            this.Property(t => t.en_application_key)
                .HasMaxLength(30);

            this.Property(t => t.en_enduser_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("china_order_details");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.en_mktseg_key).HasColumnName("en_mktseg_key");
            this.Property(t => t.en_application_key).HasColumnName("en_application_key");
            this.Property(t => t.en_enduser_key).HasColumnName("en_enduser_key");

            // Relationships
            this.HasOptional(t => t.china_application)
                .WithMany(t => t.china_order_details)
                .HasForeignKey(d => d.en_application_key);
            this.HasOptional(t => t.china_enduser)
                .WithMany(t => t.china_order_details)
                .HasForeignKey(d => d.en_enduser_key);
            this.HasOptional(t => t.china_market)
                .WithMany(t => t.china_order_details)
                .HasForeignKey(d => d.en_mktseg_key);

        }
    }
}
