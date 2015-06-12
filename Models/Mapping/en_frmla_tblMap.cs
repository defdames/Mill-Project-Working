using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_frmla_tblMap : EntityTypeConfiguration<en_frmla_tbl>
    {
        public en_frmla_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_frmla_key, t.en_frmla_ver });

            // Properties
            this.Property(t => t.en_frmla_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_frmla_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_frmla_buom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_frmla_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_frmla_stat)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frmla_chgdby)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_frmla_chgrsn)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_frmla_cust)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frmlatype_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_frmla_tbl");
            this.Property(t => t.en_frmla_key).HasColumnName("en_frmla_key");
            this.Property(t => t.en_frmla_ver).HasColumnName("en_frmla_ver");
            this.Property(t => t.en_frmla_bchsz).HasColumnName("en_frmla_bchsz");
            this.Property(t => t.en_frmla_buom).HasColumnName("en_frmla_buom");
            this.Property(t => t.en_frmla_desc).HasColumnName("en_frmla_desc");
            this.Property(t => t.en_frmla_effdt).HasColumnName("en_frmla_effdt");
            this.Property(t => t.en_frmla_inadt).HasColumnName("en_frmla_inadt");
            this.Property(t => t.en_frmla_stat).HasColumnName("en_frmla_stat");
            this.Property(t => t.en_frmla_yld).HasColumnName("en_frmla_yld");
            this.Property(t => t.en_frmla_chgdby).HasColumnName("en_frmla_chgdby");
            this.Property(t => t.en_frmla_chgddt).HasColumnName("en_frmla_chgddt");
            this.Property(t => t.en_frmla_chgrsn).HasColumnName("en_frmla_chgrsn");
            this.Property(t => t.en_frmla_upcnt).HasColumnName("en_frmla_upcnt");
            this.Property(t => t.en_frmla_cust).HasColumnName("en_frmla_cust");
            this.Property(t => t.en_frmlatype_key).HasColumnName("en_frmlatype_key");
            this.Property(t => t.en_frmla_plmf).HasColumnName("en_frmla_plmf");
            this.Property(t => t.en_frmla_mfgtyp).HasColumnName("en_frmla_mfgtyp");
            this.Property(t => t.en_frmla_allowsubf).HasColumnName("en_frmla_allowsubf");
        }
    }
}
