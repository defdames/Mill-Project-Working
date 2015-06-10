using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pss_list_masterMap : EntityTypeConfiguration<pss_list_master>
    {
        public pss_list_masterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.shipkey, t.en_prod_key });

            // Properties
            this.Property(t => t.shipkey)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("pss_list_master");
            this.Property(t => t.shipkey).HasColumnName("shipkey");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.remarks).HasColumnName("remarks");
        }
    }
}
