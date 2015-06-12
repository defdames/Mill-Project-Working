using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class cost_summary_rollupMap : EntityTypeConfiguration<cost_summary_rollup>
    {
        public cost_summary_rollupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_item_key, t.pack, t.sf_plant_key, t.sf_prcss_ver, t.ca_cstyp_id });

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pack)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_prcss_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ca_cstyp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("cost_summary_rollup");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pack).HasColumnName("pack");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_prcss_ver).HasColumnName("sf_prcss_ver");
            this.Property(t => t.ca_cstyp_id).HasColumnName("ca_cstyp_id");
            this.Property(t => t.basecost_perunit).HasColumnName("basecost_perunit");
            this.Property(t => t.bulkcost_perunit).HasColumnName("bulkcost_perunit");
            this.Property(t => t.matlcost_perunit).HasColumnName("matlcost_perunit");
            this.Property(t => t.rsrcecost_perunit).HasColumnName("rsrcecost_perunit");
            this.Property(t => t.standard_cost).HasColumnName("standard_cost");
        }
    }
}
