using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_paydtl_tblMap : EntityTypeConfiguration<ap_paydtl_tbl>
    {
        public ap_paydtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ap_payhdr_key, t.ap_paydtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ap_payhdr_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ap_paydtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ap_paydtl_docbr)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ap_paydtl_docty)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ap_paydtl_docno)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_paydtl_ref)
                .HasMaxLength(30);

            this.Property(t => t.ap_paydtl_stats)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_cmp_doc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_paydtl_clmcrncy)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("ap_paydtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ap_payhdr_key).HasColumnName("ap_payhdr_key");
            this.Property(t => t.ap_paydtl_key).HasColumnName("ap_paydtl_key");
            this.Property(t => t.ap_paydtl_docbr).HasColumnName("ap_paydtl_docbr");
            this.Property(t => t.ap_paydtl_docty).HasColumnName("ap_paydtl_docty");
            this.Property(t => t.ap_paydtl_docno).HasColumnName("ap_paydtl_docno");
            this.Property(t => t.ap_paydtl_ref).HasColumnName("ap_paydtl_ref");
            this.Property(t => t.ap_paydtl_eldsamt).HasColumnName("ap_paydtl_eldsamt");
            this.Property(t => t.ap_paydtl_eldsamtf).HasColumnName("ap_paydtl_eldsamtf");
            this.Property(t => t.ap_paydtl_eldsdt).HasColumnName("ap_paydtl_eldsdt");
            this.Property(t => t.ap_paydtl_amt).HasColumnName("ap_paydtl_amt");
            this.Property(t => t.ap_paydtl_amtf).HasColumnName("ap_paydtl_amtf");
            this.Property(t => t.ap_paydtl_stats).HasColumnName("ap_paydtl_stats");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.ap_vchr_rate).HasColumnName("ap_vchr_rate");
            this.Property(t => t.ap_paydtl_rate).HasColumnName("ap_paydtl_rate");
            this.Property(t => t.ap_paydtl_crtdt).HasColumnName("ap_paydtl_crtdt");
            this.Property(t => t.ap_paydtl_chgdt).HasColumnName("ap_paydtl_chgdt");
            this.Property(t => t.ap_paydtl_upcnt).HasColumnName("ap_paydtl_upcnt");
            this.Property(t => t.ap_paydtl_origto3).HasColumnName("ap_paydtl_origto3");
            this.Property(t => t.ap_paydtl_tobase).HasColumnName("ap_paydtl_tobase");
            this.Property(t => t.ap_paydtl_asofdt).HasColumnName("ap_paydtl_asofdt");
            this.Property(t => t.gl_cmp_doc).HasColumnName("gl_cmp_doc");
            this.Property(t => t.ap_paydtl_dcmprate).HasColumnName("ap_paydtl_dcmprate");
            this.Property(t => t.ap_paydtl_dorigto3).HasColumnName("ap_paydtl_dorigto3");
            this.Property(t => t.ap_paydtl_dtobase).HasColumnName("ap_paydtl_dtobase");
            this.Property(t => t.ap_paydtl_clmamtf).HasColumnName("ap_paydtl_clmamtf");
            this.Property(t => t.ap_paydtl_clmamt).HasColumnName("ap_paydtl_clmamt");
            this.Property(t => t.ap_paydtl_clmcrncy).HasColumnName("ap_paydtl_clmcrncy");
            this.Property(t => t.ap_paydtl_ctobase).HasColumnName("ap_paydtl_ctobase");
            this.Property(t => t.ap_paydtl_ctopay).HasColumnName("ap_paydtl_ctopay");
        }
    }
}
