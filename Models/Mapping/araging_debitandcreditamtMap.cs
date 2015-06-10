using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class araging_debitandcreditamtMap : EntityTypeConfiguration<araging_debitandcreditamt>
    {
        public araging_debitandcreditamtMap()
        {
            // Primary Key
            this.HasKey(t => new { t.InvKey, t.gl_cmp_key });

            // Properties
            this.Property(t => t.InvKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.creditinc)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("araging_debitandcreditamt");
            this.Property(t => t.InvKey).HasColumnName("InvKey");
            this.Property(t => t.DebitAmt).HasColumnName("DebitAmt");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.DebitAmtf).HasColumnName("DebitAmtf");
            this.Property(t => t.creditinc).HasColumnName("creditinc");
        }
    }
}
