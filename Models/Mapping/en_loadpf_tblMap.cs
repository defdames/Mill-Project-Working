using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_loadpf_tblMap : EntityTypeConfiguration<en_loadpf_tbl>
    {
        public en_loadpf_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_loadpf_key);

            // Properties
            this.Property(t => t.en_loadpf_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_loadpf_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_loadpf_wtuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_loadpf_voluom)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("en_loadpf_tbl");
            this.Property(t => t.en_loadpf_key).HasColumnName("en_loadpf_key");
            this.Property(t => t.en_loadpf_desc).HasColumnName("en_loadpf_desc");
            this.Property(t => t.en_loadpf_maxwt).HasColumnName("en_loadpf_maxwt");
            this.Property(t => t.en_loadpf_wtuom).HasColumnName("en_loadpf_wtuom");
            this.Property(t => t.en_loadpf_maxvol).HasColumnName("en_loadpf_maxvol");
            this.Property(t => t.en_loadpf_voluom).HasColumnName("en_loadpf_voluom");
            this.Property(t => t.en_loadpf_upcnt).HasColumnName("en_loadpf_upcnt");
        }
    }
}
