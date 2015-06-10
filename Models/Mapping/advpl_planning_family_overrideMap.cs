using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_planning_family_overrideMap : EntityTypeConfiguration<advpl_planning_family_override>
    {
        public advpl_planning_family_overrideMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_whs_key, t.in_item_Key });

            // Properties
            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_Key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_planfam_desc)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("advpl_planning_family_override");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_Key).HasColumnName("in_item_Key");
            this.Property(t => t.en_planfam_desc).HasColumnName("en_planfam_desc");
        }
    }
}
