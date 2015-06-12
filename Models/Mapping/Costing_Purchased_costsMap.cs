using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Costing_Purchased_costsMap : EntityTypeConfiguration<Costing_Purchased_costs>
    {
        public Costing_Purchased_costsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_item_key, t.in_whitm_sourc, t.uom_key, t.in_whitm_pcst, t.in_whitm_scst, t.gl_acct_key, t.in_desc });

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_whitm_sourc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_desc)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("Costing_Purchased_costs");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_whitm_sourc).HasColumnName("in_whitm_sourc");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.in_whitm_pcst).HasColumnName("in_whitm_pcst");
            this.Property(t => t.in_whitm_scst).HasColumnName("in_whitm_scst");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.in_desc).HasColumnName("in_desc");
        }
    }
}
