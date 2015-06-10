using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class web_sa_output_type_tblMap : EntityTypeConfiguration<web_sa_output_type_tbl>
    {
        public web_sa_output_type_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.sa_paper_type);

            // Properties
            this.Property(t => t.sa_paper_type)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("web_sa_output_type_tbl");
            this.Property(t => t.sa_paper_type).HasColumnName("sa_paper_type");
        }
    }
}
