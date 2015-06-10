using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_comp_tblMap : EntityTypeConfiguration<en_comp_tbl>
    {
        public en_comp_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_comp_key);

            // Properties
            this.Property(t => t.en_comp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_comp_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_comp_remk)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.en_comp_catgy)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_sicc_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_corp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_comp_crdtrep)
                .HasMaxLength(20);

            this.Property(t => t.en_riskcode_key)
                .HasMaxLength(20);

            this.Property(t => t.en_comp_dbnumber)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.en_comp_dbrating)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.en_comp_crdtcrncy)
                .HasMaxLength(3);

            this.Property(t => t.en_comp_holdresn)
                .HasMaxLength(30);

            this.Property(t => t.en_comp_ccaudit)
                .HasMaxLength(76);

            // Table & Column Mappings
            this.ToTable("en_comp_tbl");
            this.Property(t => t.en_comp_key).HasColumnName("en_comp_key");
            this.Property(t => t.en_comp_name).HasColumnName("en_comp_name");
            this.Property(t => t.en_comp_holdf).HasColumnName("en_comp_holdf");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_comp_fstat).HasColumnName("en_comp_fstat");
            this.Property(t => t.en_comp_crddt).HasColumnName("en_comp_crddt");
            this.Property(t => t.en_comp_chgdt).HasColumnName("en_comp_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_comp_clmtc).HasColumnName("en_comp_clmtc");
            this.Property(t => t.en_comp_stdsc).HasColumnName("en_comp_stdsc");
            this.Property(t => t.en_comp_remk).HasColumnName("en_comp_remk");
            this.Property(t => t.en_comp_catgy).HasColumnName("en_comp_catgy");
            this.Property(t => t.en_sicc_key).HasColumnName("en_sicc_key");
            this.Property(t => t.en_comp_empls).HasColumnName("en_comp_empls");
            this.Property(t => t.en_comp_tovrc).HasColumnName("en_comp_tovrc");
            this.Property(t => t.en_comp_proft).HasColumnName("en_comp_proft");
            this.Property(t => t.en_corp_key).HasColumnName("en_corp_key");
            this.Property(t => t.en_comp_crtdt).HasColumnName("en_comp_crtdt");
            this.Property(t => t.en_comp_crdtlimit).HasColumnName("en_comp_crdtlimit");
            this.Property(t => t.en_comp_crdtlmtwng).HasColumnName("en_comp_crdtlmtwng");
            this.Property(t => t.en_comp_crdtrep).HasColumnName("en_comp_crdtrep");
            this.Property(t => t.en_riskcode_key).HasColumnName("en_riskcode_key");
            this.Property(t => t.en_comp_dbnumber).HasColumnName("en_comp_dbnumber");
            this.Property(t => t.en_comp_dbrating).HasColumnName("en_comp_dbrating");
            this.Property(t => t.en_comp_lcrdtrevdt).HasColumnName("en_comp_lcrdtrevdt");
            this.Property(t => t.en_comp_incrdtmgtf).HasColumnName("en_comp_incrdtmgtf");
            this.Property(t => t.en_comp_crdtcrncy).HasColumnName("en_comp_crdtcrncy");
            this.Property(t => t.en_comp_crdtexp).HasColumnName("en_comp_crdtexp");
            this.Property(t => t.en_comp_crdtexpdt).HasColumnName("en_comp_crdtexpdt");
            this.Property(t => t.en_comp_ncrdtrevdt).HasColumnName("en_comp_ncrdtrevdt");
            this.Property(t => t.en_comp_holdresn).HasColumnName("en_comp_holdresn");
            this.Property(t => t.en_comp_holdefctdt).HasColumnName("en_comp_holdefctdt");
            this.Property(t => t.en_comp_upcnt).HasColumnName("en_comp_upcnt");
            this.Property(t => t.en_comp_ccaudit).HasColumnName("en_comp_ccaudit");
        }
    }
}
