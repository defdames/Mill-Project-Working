using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_sll_promotion_activityMap : EntityTypeConfiguration<tmp_sll_promotion_activity>
    {
        public tmp_sll_promotion_activityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pr_accrue_hdr, t.pr_accrue_dtl, t.pr_accrue_seq, t.pr_accrue_type, t.pr_accrue_amtdisb, t.so_brnch_key, t.en_bill_key, t.en_bill_name });

            // Properties
            this.Property(t => t.pr_accrue_hdr)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pr_accrue_dtl)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pr_accrue_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_cmp_ship)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_ship)
                .HasMaxLength(4);

            this.Property(t => t.pr_accrue_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pr_promo_acckey)
                .HasMaxLength(10);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_ivhdr_key)
                .HasMaxLength(10);

            this.Property(t => t.pr_elmnt_key)
                .HasMaxLength(20);

            this.Property(t => t.so_prod_desc)
                .HasMaxLength(60);

            this.Property(t => t.en_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_bill_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_key)
                .HasMaxLength(10);

            this.Property(t => t.so_salsm_name)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("tmp_sll_promotion_activity");
            this.Property(t => t.pr_accrue_hdr).HasColumnName("pr_accrue_hdr");
            this.Property(t => t.pr_accrue_dtl).HasColumnName("pr_accrue_dtl");
            this.Property(t => t.pr_accrue_seq).HasColumnName("pr_accrue_seq");
            this.Property(t => t.gl_cmp_ship).HasColumnName("gl_cmp_ship");
            this.Property(t => t.so_brnch_ship).HasColumnName("so_brnch_ship");
            this.Property(t => t.pr_accrue_type).HasColumnName("pr_accrue_type");
            this.Property(t => t.pr_promo_acckey).HasColumnName("pr_promo_acckey");
            this.Property(t => t.pr_promo_accsel).HasColumnName("pr_promo_accsel");
            this.Property(t => t.pr_accrue_crtdt).HasColumnName("pr_accrue_crtdt");
            this.Property(t => t.pr_accrue_offinv).HasColumnName("pr_accrue_offinv");
            this.Property(t => t.pr_accrue_amt).HasColumnName("pr_accrue_amt");
            this.Property(t => t.pr_accrue_amtdisb).HasColumnName("pr_accrue_amtdisb");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.ar_ivdtl_key).HasColumnName("ar_ivdtl_key");
            this.Property(t => t.pr_elmnt_key).HasColumnName("pr_elmnt_key");
            this.Property(t => t.so_prod_desc).HasColumnName("so_prod_desc");
            this.Property(t => t.en_bill_key).HasColumnName("en_bill_key");
            this.Property(t => t.en_bill_name).HasColumnName("en_bill_name");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.so_salsm_name).HasColumnName("so_salsm_name");
        }
    }
}
