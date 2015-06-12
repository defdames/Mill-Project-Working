using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ppg_label_ctr_tblMap : EntityTypeConfiguration<ppg_label_ctr_tbl>
    {
        public ppg_label_ctr_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.loc_key);

            // Properties
            this.Property(t => t.loc_key)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("ppg_label_ctr_tbl");
            this.Property(t => t.loc_key).HasColumnName("loc_key");
            this.Property(t => t.loc_id).HasColumnName("loc_id");
            this.Property(t => t.loc_ctr).HasColumnName("loc_ctr");
        }
    }
}
