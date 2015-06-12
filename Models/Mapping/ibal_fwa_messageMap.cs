using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ibal_fwa_messageMap : EntityTypeConfiguration<ibal_fwa_message>
    {
        public ibal_fwa_messageMap()
        {
            // Primary Key
            this.HasKey(t => t.counterline);

            // Properties
            this.Property(t => t.messageline)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ibal_fwa_message");
            this.Property(t => t.messageline).HasColumnName("messageline");
            this.Property(t => t.counterline).HasColumnName("counterline");
        }
    }
}
