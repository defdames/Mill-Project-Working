using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class web_sa_view_changes_tblMap : EntityTypeConfiguration<web_sa_view_changes_tbl>
    {
        public web_sa_view_changes_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CreateDate, t.ViewName });

            // Properties
            this.Property(t => t.ViewName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Initials)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("web_sa_view_changes_tbl");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ViewName).HasColumnName("ViewName");
            this.Property(t => t.ViewCode).HasColumnName("ViewCode");
            this.Property(t => t.Initials).HasColumnName("Initials");
            this.Property(t => t.ChangeDescription).HasColumnName("ChangeDescription");
            this.Property(t => t.LargeText).HasColumnName("LargeText");
        }
    }
}
