using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sa_strdstring_tblMap : EntityTypeConfiguration<sa_strdstring_tbl>
    {
        public sa_strdstring_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.string_id, t.row_sequence });

            // Properties
            this.Property(t => t.string_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.row_sequence)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.text_value)
                .IsRequired()
                .HasMaxLength(1786);

            // Table & Column Mappings
            this.ToTable("sa_strdstring_tbl");
            this.Property(t => t.string_id).HasColumnName("string_id");
            this.Property(t => t.row_sequence).HasColumnName("row_sequence");
            this.Property(t => t.text_total).HasColumnName("text_total");
            this.Property(t => t.text_value).HasColumnName("text_value");
        }
    }
}
