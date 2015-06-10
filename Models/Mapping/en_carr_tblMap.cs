using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_carr_tblMap : EntityTypeConfiguration<en_carr_tbl>
    {
        public en_carr_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_carr_key);

            // Properties
            this.Property(t => t.en_carr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_carr_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_carr_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_carr_scac)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_loadpf_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_service_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_carr_pronum)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_carr_ediind)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_carr_union)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_bank_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_bank_acctno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_carr_trkurl)
                .HasMaxLength(100);

            this.Property(t => t.en_carr_trkparm)
                .HasMaxLength(50);

            this.Property(t => t.en_carr_trkaddparm)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("en_carr_tbl");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.en_carr_avchrf).HasColumnName("en_carr_avchrf");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.en_remt_key).HasColumnName("en_remt_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_carr_desc).HasColumnName("en_carr_desc");
            this.Property(t => t.en_carr_remk).HasColumnName("en_carr_remk");
            this.Property(t => t.en_carr_scac).HasColumnName("en_carr_scac");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_loadpf_key).HasColumnName("en_loadpf_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.en_carr_pronum).HasColumnName("en_carr_pronum");
            this.Property(t => t.en_carr_ediind).HasColumnName("en_carr_ediind");
            this.Property(t => t.en_carr_union).HasColumnName("en_carr_union");
            this.Property(t => t.en_carr_upcnt).HasColumnName("en_carr_upcnt");
            this.Property(t => t.en_carr_remtad).HasColumnName("en_carr_remtad");
            this.Property(t => t.en_carr_adres).HasColumnName("en_carr_adres");
            this.Property(t => t.en_bank_key).HasColumnName("en_bank_key");
            this.Property(t => t.en_bank_acctno).HasColumnName("en_bank_acctno");
            this.Property(t => t.en_carr_trkurl).HasColumnName("en_carr_trkurl");
            this.Property(t => t.en_carr_trkparm).HasColumnName("en_carr_trkparm");
            this.Property(t => t.en_carr_trkaddparm).HasColumnName("en_carr_trkaddparm");
        }
    }
}
