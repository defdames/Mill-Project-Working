using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pr_promo_tblMap : EntityTypeConfiguration<pr_promo_tbl>
    {
        public pr_promo_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pr_promo_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pr_promo_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pr_promo_desc)
                .HasMaxLength(30);

            this.Property(t => t.pr_promo_situation)
                .HasMaxLength(255);

            this.Property(t => t.pr_promo_comment)
                .HasMaxLength(255);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.pr_cmpgn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pr_promo_crtby)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.pr_promo_appby)
                .HasMaxLength(8);

            this.Property(t => t.ar_terms_key)
                .HasMaxLength(2);

            this.Property(t => t.pr_promo_libac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.pr_promo_expac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.pr_promo_acckey)
                .HasMaxLength(10);

            this.Property(t => t.pr_promo_chgby)
                .HasMaxLength(8);

            this.Property(t => t.pr_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.so_enduse_key)
                .HasMaxLength(10);

            this.Property(t => t.en_sltyp_key)
                .HasMaxLength(10);

            this.Property(t => t.so_brand_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("pr_promo_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pr_promo_key).HasColumnName("pr_promo_key");
            this.Property(t => t.pr_promo_desc).HasColumnName("pr_promo_desc");
            this.Property(t => t.pr_promo_type).HasColumnName("pr_promo_type");
            this.Property(t => t.pr_promo_prec).HasColumnName("pr_promo_prec");
            this.Property(t => t.pr_promo_situation).HasColumnName("pr_promo_situation");
            this.Property(t => t.pr_promo_comment).HasColumnName("pr_promo_comment");
            this.Property(t => t.pr_promo_budget).HasColumnName("pr_promo_budget");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.pr_cmpgn_key).HasColumnName("pr_cmpgn_key");
            this.Property(t => t.pr_promo_crtby).HasColumnName("pr_promo_crtby");
            this.Property(t => t.pr_promo_crtdt).HasColumnName("pr_promo_crtdt");
            this.Property(t => t.pr_promo_appby).HasColumnName("pr_promo_appby");
            this.Property(t => t.pr_promo_appdt).HasColumnName("pr_promo_appdt");
            this.Property(t => t.pr_promo_inact).HasColumnName("pr_promo_inact");
            this.Property(t => t.pr_promo_method).HasColumnName("pr_promo_method");
            this.Property(t => t.pr_promo_addchnf).HasColumnName("pr_promo_addchnf");
            this.Property(t => t.pr_promo_offinv).HasColumnName("pr_promo_offinv");
            this.Property(t => t.pr_promo_accrued).HasColumnName("pr_promo_accrued");
            this.Property(t => t.pr_promo_maxamt).HasColumnName("pr_promo_maxamt");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
            this.Property(t => t.pr_promo_libac).HasColumnName("pr_promo_libac");
            this.Property(t => t.pr_promo_expac).HasColumnName("pr_promo_expac");
            this.Property(t => t.pr_promo_allow).HasColumnName("pr_promo_allow");
            this.Property(t => t.pr_promo_ordshp).HasColumnName("pr_promo_ordshp");
            this.Property(t => t.pr_promo_applyto).HasColumnName("pr_promo_applyto");
            this.Property(t => t.pr_promo_duration).HasColumnName("pr_promo_duration");
            this.Property(t => t.pr_promo_disperse).HasColumnName("pr_promo_disperse");
            this.Property(t => t.pr_promo_accrue).HasColumnName("pr_promo_accrue");
            this.Property(t => t.pr_promo_cashdisf).HasColumnName("pr_promo_cashdisf");
            this.Property(t => t.pr_promo_itemizef).HasColumnName("pr_promo_itemizef");
            this.Property(t => t.pr_promo_commf).HasColumnName("pr_promo_commf");
            this.Property(t => t.pr_promo_taxf).HasColumnName("pr_promo_taxf");
            this.Property(t => t.pr_promo_accsel).HasColumnName("pr_promo_accsel");
            this.Property(t => t.pr_promo_acckey).HasColumnName("pr_promo_acckey");
            this.Property(t => t.pr_promo_expdt).HasColumnName("pr_promo_expdt");
            this.Property(t => t.pr_promo_exptime).HasColumnName("pr_promo_exptime");
            this.Property(t => t.pr_promo_expint).HasColumnName("pr_promo_expint");
            this.Property(t => t.pr_promo_lastdt).HasColumnName("pr_promo_lastdt");
            this.Property(t => t.pr_promo_lasttime).HasColumnName("pr_promo_lasttime");
            this.Property(t => t.pr_promo_lastint).HasColumnName("pr_promo_lastint");
            this.Property(t => t.pr_promo_chgdt).HasColumnName("pr_promo_chgdt");
            this.Property(t => t.pr_promo_upcnt).HasColumnName("pr_promo_upcnt");
            this.Property(t => t.pr_promo_chgby).HasColumnName("pr_promo_chgby");
            this.Property(t => t.pr_promo_useavailf).HasColumnName("pr_promo_useavailf");
            this.Property(t => t.pr_promo_cncldt).HasColumnName("pr_promo_cncldt");
            this.Property(t => t.pr_resn_key).HasColumnName("pr_resn_key");
            this.Property(t => t.pr_promo_appvf).HasColumnName("pr_promo_appvf");
            this.Property(t => t.pr_promo_appseq).HasColumnName("pr_promo_appseq");
            this.Property(t => t.pr_promo_ordefdt).HasColumnName("pr_promo_ordefdt");
            this.Property(t => t.pr_promo_ordiadt).HasColumnName("pr_promo_ordiadt");
            this.Property(t => t.pr_promo_shpefdt).HasColumnName("pr_promo_shpefdt");
            this.Property(t => t.pr_promo_shpiadt).HasColumnName("pr_promo_shpiadt");
            this.Property(t => t.pr_promo_ordefff).HasColumnName("pr_promo_ordefff");
            this.Property(t => t.pr_promo_shpefff).HasColumnName("pr_promo_shpefff");
            this.Property(t => t.pr_promo_multicmpf).HasColumnName("pr_promo_multicmpf");
            this.Property(t => t.pr_promo_incicprcf).HasColumnName("pr_promo_incicprcf");
            this.Property(t => t.so_enduse_key).HasColumnName("so_enduse_key");
            this.Property(t => t.en_sltyp_key).HasColumnName("en_sltyp_key");
            this.Property(t => t.pr_promo_reprchgf).HasColumnName("pr_promo_reprchgf");
            this.Property(t => t.so_brand_key).HasColumnName("so_brand_key");
        }
    }
}
