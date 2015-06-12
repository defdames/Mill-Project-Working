using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tr_multilang_tblMap : EntityTypeConfiguration<tr_multilang_tbl>
    {
        public tr_multilang_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.tr_multilang_sgid);

            // Properties
            this.Property(t => t.tr_multilang_sgid)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.tr_multilang_basetbl)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.tr_multilang_basecol)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.tr_multilang_key1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.tr_multilang_key2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.tr_multilang_key3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.tr_multilang_key4)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.tr_multilang_key5)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.tr_multilang_key6)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.tr_multilang_basedata)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.tr_multilang_value1)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.tr_multilang_value2)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.tr_multilang_value3)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.tr_multilang_value4)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.tr_multilang_value5)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.tr_multilang_value6)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.tr_multilang_transdata)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.tr_multilang_crtusr)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.tr_multilang_chgusr)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("tr_multilang_tbl");
            this.Property(t => t.tr_multilang_sgid).HasColumnName("tr_multilang_sgid");
            this.Property(t => t.tr_multilang_basetbl).HasColumnName("tr_multilang_basetbl");
            this.Property(t => t.tr_multilang_basecol).HasColumnName("tr_multilang_basecol");
            this.Property(t => t.tr_multilang_key1).HasColumnName("tr_multilang_key1");
            this.Property(t => t.tr_multilang_key2).HasColumnName("tr_multilang_key2");
            this.Property(t => t.tr_multilang_key3).HasColumnName("tr_multilang_key3");
            this.Property(t => t.tr_multilang_key4).HasColumnName("tr_multilang_key4");
            this.Property(t => t.tr_multilang_key5).HasColumnName("tr_multilang_key5");
            this.Property(t => t.tr_multilang_key6).HasColumnName("tr_multilang_key6");
            this.Property(t => t.tr_multilang_basedata).HasColumnName("tr_multilang_basedata");
            this.Property(t => t.tr_multilang_value1).HasColumnName("tr_multilang_value1");
            this.Property(t => t.tr_multilang_value2).HasColumnName("tr_multilang_value2");
            this.Property(t => t.tr_multilang_value3).HasColumnName("tr_multilang_value3");
            this.Property(t => t.tr_multilang_value4).HasColumnName("tr_multilang_value4");
            this.Property(t => t.tr_multilang_value5).HasColumnName("tr_multilang_value5");
            this.Property(t => t.tr_multilang_value6).HasColumnName("tr_multilang_value6");
            this.Property(t => t.en_lang_key).HasColumnName("en_lang_key");
            this.Property(t => t.tr_multilang_transdata).HasColumnName("tr_multilang_transdata");
            this.Property(t => t.tr_multilang_crtdt).HasColumnName("tr_multilang_crtdt");
            this.Property(t => t.tr_multilang_crtusr).HasColumnName("tr_multilang_crtusr");
            this.Property(t => t.tr_multilang_chgdt).HasColumnName("tr_multilang_chgdt");
            this.Property(t => t.tr_multilang_chgusr).HasColumnName("tr_multilang_chgusr");
            this.Property(t => t.tr_multilang_upcnt).HasColumnName("tr_multilang_upcnt");
        }
    }
}
