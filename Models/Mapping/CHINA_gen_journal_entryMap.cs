using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_gen_journal_entryMap : EntityTypeConfiguration<CHINA_gen_journal_entry>
    {
        public CHINA_gen_journal_entryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JournalEntry, t.PostDate, t.EntryDesc, t.AcctKey, t.PostedBy, t.Type, t.Line, t.Debit, t.Credit, t.gl_cmp_key });

            // Properties
            this.Property(t => t.JournalEntry)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EntryDesc)
                .IsRequired()
                .HasMaxLength(90);

            this.Property(t => t.AcctKey)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.PostedBy)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Line)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_gen_journal_entry");
            this.Property(t => t.JournalEntry).HasColumnName("JournalEntry");
            this.Property(t => t.PerYr).HasColumnName("PerYr");
            this.Property(t => t.PerMo).HasColumnName("PerMo");
            this.Property(t => t.PostDate).HasColumnName("PostDate");
            this.Property(t => t.EntryDesc).HasColumnName("EntryDesc");
            this.Property(t => t.AcctKey).HasColumnName("AcctKey");
            this.Property(t => t.Amt).HasColumnName("Amt");
            this.Property(t => t.PostedBy).HasColumnName("PostedBy");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Line).HasColumnName("Line");
            this.Property(t => t.Debit).HasColumnName("Debit");
            this.Property(t => t.Credit).HasColumnName("Credit");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
