using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_transfer_trajectoriesMap : EntityTypeConfiguration<advpl_transfer_trajectories>
    {
        public advpl_transfer_trajectoriesMap()
        {
            // Primary Key
            this.HasKey(t => t.company);

            // Properties
            this.Property(t => t.Source_Item)
                .HasMaxLength(34);

            this.Property(t => t.Destination_Item)
                .HasMaxLength(34);

            this.Property(t => t.Source_Destination_Concat)
                .HasMaxLength(45);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("advpl_transfer_trajectories");
            this.Property(t => t.Source_Item).HasColumnName("Source Item");
            this.Property(t => t.Destination_Item).HasColumnName("Destination Item");
            this.Property(t => t.Source_Destination_Concat).HasColumnName("Source Destination Concat");
            this.Property(t => t.company).HasColumnName("company");
        }
    }
}
