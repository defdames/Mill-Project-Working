using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class s1_report_card_monthlyMap : EntityTypeConfiguration<s1_report_card_monthly>
    {
        public s1_report_card_monthlyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.s1_year, t.s1_month, t.region, t.customer });

            // Properties
            this.Property(t => t.s1_year)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.s1_month)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.customer)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.acctshr_region_cmp_1)
                .HasMaxLength(50);

            this.Property(t => t.acctshr_region_cmp_2)
                .HasMaxLength(50);

            this.Property(t => t.acctshr_region_cmp_3)
                .HasMaxLength(50);

            this.Property(t => t.acctshr_uom)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("s1_report_card_monthly");
            this.Property(t => t.s1_year).HasColumnName("s1_year");
            this.Property(t => t.s1_month).HasColumnName("s1_month");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.customer_update).HasColumnName("customer_update");
            this.Property(t => t.acctshr_region_cmp_1).HasColumnName("acctshr_region_cmp_1");
            this.Property(t => t.acctshr_tam_lbs_1).HasColumnName("acctshr_tam_lbs_1");
            this.Property(t => t.acctshr_silb_lbs_1).HasColumnName("acctshr_silb_lbs_1");
            this.Property(t => t.acctshr_comp_lbs_1).HasColumnName("acctshr_comp_lbs_1");
            this.Property(t => t.acctshr_region_cmp_2).HasColumnName("acctshr_region_cmp_2");
            this.Property(t => t.acctshr_tam_lbs_2).HasColumnName("acctshr_tam_lbs_2");
            this.Property(t => t.acctshr_silb_lbs_2).HasColumnName("acctshr_silb_lbs_2");
            this.Property(t => t.acctshr_comp_lbs_2).HasColumnName("acctshr_comp_lbs_2");
            this.Property(t => t.acctshr_region_cmp_3).HasColumnName("acctshr_region_cmp_3");
            this.Property(t => t.acctshr_tam_lbs_3).HasColumnName("acctshr_tam_lbs_3");
            this.Property(t => t.acctshr_silb_lbs_3).HasColumnName("acctshr_silb_lbs_3");
            this.Property(t => t.acctshr_comp_lbs_3).HasColumnName("acctshr_comp_lbs_3");
            this.Property(t => t.product_needs_issues).HasColumnName("product_needs_issues");
            this.Property(t => t.acctshr_uom).HasColumnName("acctshr_uom");
        }
    }
}
