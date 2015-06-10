using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class MSsnapshotdeliveryprogressMap : EntityTypeConfiguration<MSsnapshotdeliveryprogress>
    {
        public MSsnapshotdeliveryprogressMap()
        {
            // Primary Key
            this.HasKey(t => new { t.session_token, t.progress_token_hash, t.progress_token });

            // Properties
            this.Property(t => t.session_token)
                .IsRequired()
                .HasMaxLength(260);

            this.Property(t => t.progress_token_hash)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.progress_token)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MSsnapshotdeliveryprogress");
            this.Property(t => t.session_token).HasColumnName("session_token");
            this.Property(t => t.progress_token_hash).HasColumnName("progress_token_hash");
            this.Property(t => t.progress_token).HasColumnName("progress_token");
            this.Property(t => t.progress_timestamp).HasColumnName("progress_timestamp");
        }
    }
}
