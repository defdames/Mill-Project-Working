using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pr_prdgrp_tblMap : EntityTypeConfiguration<pr_prdgrp_tbl>
    {
        public pr_prdgrp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_prod_key, t.en_prgrp_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_prgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pr_prdgrp_comment)
                .HasMaxLength(255);

            this.Property(t => t.sa_user_key)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("pr_prdgrp_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.en_prgrp_key).HasColumnName("en_prgrp_key");
            this.Property(t => t.pr_prdgrp_comment).HasColumnName("pr_prdgrp_comment");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.pr_prdgrp_crtdt).HasColumnName("pr_prdgrp_crtdt");
            this.Property(t => t.pr_prdgrp_chgdt).HasColumnName("pr_prdgrp_chgdt");
            this.Property(t => t.pr_prdgrp_upcnt).HasColumnName("pr_prdgrp_upcnt");
        }
    }
}
