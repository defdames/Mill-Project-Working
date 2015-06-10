using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pc_tmppl_tblMap : EntityTypeConfiguration<pc_tmppl_tbl>
    {
        public pc_tmppl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pc_tmplt_key, t.pc_tmppl_obtype, t.pc_tmppl_attach, t.pc_tmppl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_tmplt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_tmppl_obtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pc_tmppl_attach)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pc_tmppl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pc_tmppl_val1)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pc_tmppl_val2)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pc_tmppl_val3)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pc_tmppl_val4)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pc_tmppl_val5)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pc_tmppl_val6)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("pc_tmppl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pc_tmplt_key).HasColumnName("pc_tmplt_key");
            this.Property(t => t.pc_tmppl_obtype).HasColumnName("pc_tmppl_obtype");
            this.Property(t => t.pc_tmppl_attach).HasColumnName("pc_tmppl_attach");
            this.Property(t => t.pc_tmppl_key).HasColumnName("pc_tmppl_key");
            this.Property(t => t.pc_tmppl_val1).HasColumnName("pc_tmppl_val1");
            this.Property(t => t.pc_tmppl_val2).HasColumnName("pc_tmppl_val2");
            this.Property(t => t.pc_tmppl_val3).HasColumnName("pc_tmppl_val3");
            this.Property(t => t.pc_tmppl_val4).HasColumnName("pc_tmppl_val4");
            this.Property(t => t.pc_tmppl_val5).HasColumnName("pc_tmppl_val5");
            this.Property(t => t.pc_tmppl_val6).HasColumnName("pc_tmppl_val6");
            this.Property(t => t.pc_tmppl_upcnt).HasColumnName("pc_tmppl_upcnt");
            this.Property(t => t.pc_tmppl_crtdt).HasColumnName("pc_tmppl_crtdt");
            this.Property(t => t.pc_tmppl_chgdt).HasColumnName("pc_tmppl_chgdt");
        }
    }
}
