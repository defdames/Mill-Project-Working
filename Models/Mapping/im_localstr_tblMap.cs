using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_localstr_tblMap : EntityTypeConfiguration<im_localstr_tbl>
    {
        public im_localstr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.im_localins_key, t.im_localstr_rseq });

            // Properties
            this.Property(t => t.im_localins_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_localstr_rseq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_localstr_txt)
                .IsRequired()
                .HasMaxLength(999);

            // Table & Column Mappings
            this.ToTable("im_localstr_tbl");
            this.Property(t => t.im_localins_key).HasColumnName("im_localins_key");
            this.Property(t => t.im_localstr_rseq).HasColumnName("im_localstr_rseq");
            this.Property(t => t.im_localstr_ttot).HasColumnName("im_localstr_ttot");
            this.Property(t => t.im_localstr_txt).HasColumnName("im_localstr_txt");
        }
    }
}
