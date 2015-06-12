using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_20131213_allow_inactive_jinan_ss_shiptosMap : EntityTypeConfiguration<tmp_20131213_allow_inactive_jinan_ss_shiptos>
    {
        public tmp_20131213_allow_inactive_jinan_ss_shiptosMap()
        {
            // Primary Key
            this.HasKey(t => t.sj_ar_ship_key);

            // Properties
            this.Property(t => t.sj_ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("tmp_20131213_allow_inactive_jinan_ss_shiptos");
            this.Property(t => t.sj_ar_ship_key).HasColumnName("sj_ar_ship_key");
        }
    }
}
