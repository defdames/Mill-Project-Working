using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class bm_excess_inventory_summaryMap : EntityTypeConfiguration<bm_excess_inventory_summary>
    {
        public bm_excess_inventory_summaryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_item_key, t.gl_perod_year, t.gl_perod_id });

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("bm_excess_inventory_summary");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
            this.Property(t => t.OnHand).HasColumnName("OnHand");
        }
    }
}
