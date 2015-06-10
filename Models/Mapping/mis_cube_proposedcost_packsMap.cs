using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_proposedcost_packsMap : EntityTypeConfiguration<mis_cube_proposedcost_packs>
    {
        public mis_cube_proposedcost_packsMap()
        {
            // Primary Key
            this.HasKey(t => t.im_pack_key);

            // Properties
            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("mis_cube_proposedcost_packs");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
        }
    }
}
