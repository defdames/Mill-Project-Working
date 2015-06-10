using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class generic_label_ctr_tbl_usrMap : EntityTypeConfiguration<generic_label_ctr_tbl_usr>
    {
        public generic_label_ctr_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.loc_id);

            // Properties
            this.Property(t => t.loc_key)
                .HasMaxLength(4);

            this.Property(t => t.loc_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("generic_label_ctr_tbl_usr");
            this.Property(t => t.loc_key).HasColumnName("loc_key");
            this.Property(t => t.loc_id).HasColumnName("loc_id");
            this.Property(t => t.loc_ctr).HasColumnName("loc_ctr");
        }
    }
}
