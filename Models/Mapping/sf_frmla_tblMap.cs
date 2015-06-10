using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_frmla_tblMap : EntityTypeConfiguration<sf_frmla_tbl>
    {
        public sf_frmla_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_frmla_key, t.sf_frmla_ver });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_frmla_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_frmla_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_frmla_buom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_frmla_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sf_frmla_stat)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_frmla_chgdby)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sf_frmla_chgrsn)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sf_frmla_cust)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frmlatype_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("sf_frmla_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_frmla_key).HasColumnName("sf_frmla_key");
            this.Property(t => t.sf_frmla_ver).HasColumnName("sf_frmla_ver");
            this.Property(t => t.sf_frmla_bchsz).HasColumnName("sf_frmla_bchsz");
            this.Property(t => t.sf_frmla_buom).HasColumnName("sf_frmla_buom");
            this.Property(t => t.sf_frmla_desc).HasColumnName("sf_frmla_desc");
            this.Property(t => t.sf_frmla_effdt).HasColumnName("sf_frmla_effdt");
            this.Property(t => t.sf_frmla_inadt).HasColumnName("sf_frmla_inadt");
            this.Property(t => t.sf_frmla_stat).HasColumnName("sf_frmla_stat");
            this.Property(t => t.sf_frmla_yld).HasColumnName("sf_frmla_yld");
            this.Property(t => t.sf_frmla_chgdby).HasColumnName("sf_frmla_chgdby");
            this.Property(t => t.sf_frmla_chgddt).HasColumnName("sf_frmla_chgddt");
            this.Property(t => t.sf_frmla_chgrsn).HasColumnName("sf_frmla_chgrsn");
            this.Property(t => t.sf_frmla_upcnt).HasColumnName("sf_frmla_upcnt");
            this.Property(t => t.sf_frmla_cust).HasColumnName("sf_frmla_cust");
            this.Property(t => t.en_frmlatype_key).HasColumnName("en_frmlatype_key");
            this.Property(t => t.en_frmla_mfgtyp).HasColumnName("en_frmla_mfgtyp");
            this.Property(t => t.sf_frmla_allowsubf).HasColumnName("sf_frmla_allowsubf");
        }
    }
}
