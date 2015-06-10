using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_brprd_tblMap : EntityTypeConfiguration<so_brprd_tbl>
    {
        public so_brprd_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_prod_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_ppc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_brprd_prcls)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.ar_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_brprd_cogs)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_sales)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_ptdsc)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retns)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_serv)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_prcvr)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.so_brprd_cprdad)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_pprdad)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogsbm)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogsbmo)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogspm)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogspmo)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogsbr)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogsbro)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogspr)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogspro)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogscd)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogsfrt)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogsmkt)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_cogsoth)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnsbm)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnsbmo)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnspm)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnspmo)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnsbr)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnsbro)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnspr)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnspro)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnscd)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnsfrt)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnsmkt)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_retnsoth)
                .HasMaxLength(40);

            this.Property(t => t.so_brprd_fillqtyvar)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("so_brprd_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.so_brprd_cuma).HasColumnName("so_brprd_cuma");
            this.Property(t => t.so_brprd_cums).HasColumnName("so_brprd_cums");
            this.Property(t => t.so_brprd_rwrkc).HasColumnName("so_brprd_rwrkc");
            this.Property(t => t.so_brprd_wslec).HasColumnName("so_brprd_wslec");
            this.Property(t => t.so_brprd_rstkc).HasColumnName("so_brprd_rstkc");
            this.Property(t => t.so_brprd_cst).HasColumnName("so_brprd_cst");
            this.Property(t => t.so_ppc_key).HasColumnName("so_ppc_key");
            this.Property(t => t.so_brprd_prcls).HasColumnName("so_brprd_prcls");
            this.Property(t => t.so_brprd_mpflag).HasColumnName("so_brprd_mpflag");
            this.Property(t => t.so_brprd_taxf).HasColumnName("so_brprd_taxf");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.so_brprd_mnmrg).HasColumnName("so_brprd_mnmrg");
            this.Property(t => t.so_brprd_cogs).HasColumnName("so_brprd_cogs");
            this.Property(t => t.so_brprd_sales).HasColumnName("so_brprd_sales");
            this.Property(t => t.so_brprd_ptdsc).HasColumnName("so_brprd_ptdsc");
            this.Property(t => t.so_brprd_retns).HasColumnName("so_brprd_retns");
            this.Property(t => t.so_brprd_serv).HasColumnName("so_brprd_serv");
            this.Property(t => t.so_brprd_prcvr).HasColumnName("so_brprd_prcvr");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.so_brprd_chgdt).HasColumnName("so_brprd_chgdt");
            this.Property(t => t.so_brprd_crtdt).HasColumnName("so_brprd_crtdt");
            this.Property(t => t.so_brprd_upcnt).HasColumnName("so_brprd_upcnt");
            this.Property(t => t.so_brprd_cprdad).HasColumnName("so_brprd_cprdad");
            this.Property(t => t.so_brprd_pprdad).HasColumnName("so_brprd_pprdad");
            this.Property(t => t.so_brprd_cogsbm).HasColumnName("so_brprd_cogsbm");
            this.Property(t => t.so_brprd_cogsbmo).HasColumnName("so_brprd_cogsbmo");
            this.Property(t => t.so_brprd_cogspm).HasColumnName("so_brprd_cogspm");
            this.Property(t => t.so_brprd_cogspmo).HasColumnName("so_brprd_cogspmo");
            this.Property(t => t.so_brprd_cogsbr).HasColumnName("so_brprd_cogsbr");
            this.Property(t => t.so_brprd_cogsbro).HasColumnName("so_brprd_cogsbro");
            this.Property(t => t.so_brprd_cogspr).HasColumnName("so_brprd_cogspr");
            this.Property(t => t.so_brprd_cogspro).HasColumnName("so_brprd_cogspro");
            this.Property(t => t.so_brprd_cogscd).HasColumnName("so_brprd_cogscd");
            this.Property(t => t.so_brprd_cogsfrt).HasColumnName("so_brprd_cogsfrt");
            this.Property(t => t.so_brprd_cogsmkt).HasColumnName("so_brprd_cogsmkt");
            this.Property(t => t.so_brprd_cogsoth).HasColumnName("so_brprd_cogsoth");
            this.Property(t => t.so_brprd_retnsbm).HasColumnName("so_brprd_retnsbm");
            this.Property(t => t.so_brprd_retnsbmo).HasColumnName("so_brprd_retnsbmo");
            this.Property(t => t.so_brprd_retnspm).HasColumnName("so_brprd_retnspm");
            this.Property(t => t.so_brprd_retnspmo).HasColumnName("so_brprd_retnspmo");
            this.Property(t => t.so_brprd_retnsbr).HasColumnName("so_brprd_retnsbr");
            this.Property(t => t.so_brprd_retnsbro).HasColumnName("so_brprd_retnsbro");
            this.Property(t => t.so_brprd_retnspr).HasColumnName("so_brprd_retnspr");
            this.Property(t => t.so_brprd_retnspro).HasColumnName("so_brprd_retnspro");
            this.Property(t => t.so_brprd_retnscd).HasColumnName("so_brprd_retnscd");
            this.Property(t => t.so_brprd_retnsfrt).HasColumnName("so_brprd_retnsfrt");
            this.Property(t => t.so_brprd_retnsmkt).HasColumnName("so_brprd_retnsmkt");
            this.Property(t => t.so_brprd_retnsoth).HasColumnName("so_brprd_retnsoth");
            this.Property(t => t.so_brprd_fillqtyvar).HasColumnName("so_brprd_fillqtyvar");
        }
    }
}
