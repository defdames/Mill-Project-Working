using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_wtdtl_extMap : EntityTypeConfiguration<in_wtdtl_ext>
    {
        public in_wtdtl_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_wthdr_towhs, t.in_wthdr_key, t.in_wtdtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_wthdr_towhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_wthdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_wtdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_wtdtl_prodid)
                .HasMaxLength(20);

            this.Property(t => t.in_wtdtl_prodlot1)
                .HasMaxLength(30);

            this.Property(t => t.in_wtdtl_prodlot1q)
                .HasMaxLength(30);

            this.Property(t => t.in_wtdtl_prodlot2)
                .HasMaxLength(30);

            this.Property(t => t.in_wtdtl_prodlot2q)
                .HasMaxLength(30);

            this.Property(t => t.in_wtdtl_prodlot3)
                .HasMaxLength(30);

            this.Property(t => t.in_wtdtl_prodlot3q)
                .HasMaxLength(30);

            this.Property(t => t.in_wtdtl_prodlot4)
                .HasMaxLength(30);

            this.Property(t => t.in_wtdtl_prodlot4q)
                .HasMaxLength(30);

            this.Property(t => t.in_wtdtl_prodlot5)
                .HasMaxLength(30);

            this.Property(t => t.in_wtdtl_prodlot5q)
                .HasMaxLength(30);

            this.Property(t => t.in_wtdtl_cust)
                .HasMaxLength(10);

            this.Property(t => t.in_wtdtl_po)
                .HasMaxLength(60);

            this.Property(t => t.in_wtdtl_instrux)
                .HasMaxLength(255);

            this.Property(t => t.in_wtdtl_cprtn)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("in_wtdtl_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_wthdr_towhs).HasColumnName("in_wthdr_towhs");
            this.Property(t => t.in_wthdr_key).HasColumnName("in_wthdr_key");
            this.Property(t => t.in_wtdtl_key).HasColumnName("in_wtdtl_key");
            this.Property(t => t.in_wtdtl_prodid).HasColumnName("in_wtdtl_prodid");
            this.Property(t => t.in_wtdtl_prodlot1).HasColumnName("in_wtdtl_prodlot1");
            this.Property(t => t.in_wtdtl_prodlot1q).HasColumnName("in_wtdtl_prodlot1q");
            this.Property(t => t.in_wtdtl_prodlot2).HasColumnName("in_wtdtl_prodlot2");
            this.Property(t => t.in_wtdtl_prodlot2q).HasColumnName("in_wtdtl_prodlot2q");
            this.Property(t => t.in_wtdtl_prodlot3).HasColumnName("in_wtdtl_prodlot3");
            this.Property(t => t.in_wtdtl_prodlot3q).HasColumnName("in_wtdtl_prodlot3q");
            this.Property(t => t.in_wtdtl_prodlot4).HasColumnName("in_wtdtl_prodlot4");
            this.Property(t => t.in_wtdtl_prodlot4q).HasColumnName("in_wtdtl_prodlot4q");
            this.Property(t => t.in_wtdtl_prodlot5).HasColumnName("in_wtdtl_prodlot5");
            this.Property(t => t.in_wtdtl_prodlot5q).HasColumnName("in_wtdtl_prodlot5q");
            this.Property(t => t.in_wtdtl_cust).HasColumnName("in_wtdtl_cust");
            this.Property(t => t.in_wtdtl_po).HasColumnName("in_wtdtl_po");
            this.Property(t => t.in_wtdtl_instrux).HasColumnName("in_wtdtl_instrux");
            this.Property(t => t.in_unit_price).HasColumnName("in_unit_price");
            this.Property(t => t.in_wtdtl_upcnt).HasColumnName("in_wtdtl_upcnt");
            this.Property(t => t.in_wtdtl_cprtn).HasColumnName("in_wtdtl_cprtn");
        }
    }
}
