using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_cspxf_tblMap : EntityTypeConfiguration<en_cspxf_tbl>
    {
        public en_cspxf_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_cust_key, t.en_ship_key, t.en_prod_key, t.en_cspxf_cprtn });

            // Properties
            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_cspxf_cprtn)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_cspxf_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_cspxf_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_caryr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cspxf_cospf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_cspxf_certf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_cspxf_presf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_cspxf_swtcf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_cspxf_cmnts)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_cspxf_s1ltf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_cspxf_taxf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_cspxf_audno)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_cspxf_tluom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_sltyp_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_pricedef)
                .HasMaxLength(2);

            this.Property(t => t.en_uom_orderdef)
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_profit)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_profit)
                .HasMaxLength(4);

            this.Property(t => t.en_enduse_key)
                .HasMaxLength(10);

            this.Property(t => t.en_cspxf_hazmattel)
                .HasMaxLength(60);

            this.Property(t => t.en_cspxf_hazmatshipername)
                .HasMaxLength(100);

            this.Property(t => t.en_cspxf_hazmatshipertitle)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("en_cspxf_tbl");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.en_cspxf_upcnt).HasColumnName("en_cspxf_upcnt");
            this.Property(t => t.en_cspxf_cprtn).HasColumnName("en_cspxf_cprtn");
            this.Property(t => t.en_cspxf_desc).HasColumnName("en_cspxf_desc");
            this.Property(t => t.en_cspxf_remk).HasColumnName("en_cspxf_remk");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.en_caryr_key).HasColumnName("en_caryr_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_cspxf_cospf).HasColumnName("en_cspxf_cospf");
            this.Property(t => t.en_cspxf_certf).HasColumnName("en_cspxf_certf");
            this.Property(t => t.en_cspxf_presf).HasColumnName("en_cspxf_presf");
            this.Property(t => t.en_cspxf_swtcf).HasColumnName("en_cspxf_swtcf");
            this.Property(t => t.en_cspxf_cmnts).HasColumnName("en_cspxf_cmnts");
            this.Property(t => t.en_cspxf_dyely).HasColumnName("en_cspxf_dyely");
            this.Property(t => t.en_cspxf_s1ltf).HasColumnName("en_cspxf_s1ltf");
            this.Property(t => t.en_cspxf_taxf).HasColumnName("en_cspxf_taxf");
            this.Property(t => t.en_cspxf_crtdt).HasColumnName("en_cspxf_crtdt");
            this.Property(t => t.en_cspxf_chgdt).HasColumnName("en_cspxf_chgdt");
            this.Property(t => t.en_cspxf_auddt).HasColumnName("en_cspxf_auddt");
            this.Property(t => t.en_cspxf_audno).HasColumnName("en_cspxf_audno");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_cspxf_ptpkf).HasColumnName("en_cspxf_ptpkf");
            this.Property(t => t.en_cspxf_pshpf).HasColumnName("en_cspxf_pshpf");
            this.Property(t => t.en_cspxf_tlfcf).HasColumnName("en_cspxf_tlfcf");
            this.Property(t => t.en_cspxf_tlpcf).HasColumnName("en_cspxf_tlpcf");
            this.Property(t => t.en_cspxf_tludr).HasColumnName("en_cspxf_tludr");
            this.Property(t => t.en_cspxf_tlovr).HasColumnName("en_cspxf_tlovr");
            this.Property(t => t.en_cspxf_tluom).HasColumnName("en_cspxf_tluom");
            this.Property(t => t.en_tax_key).HasColumnName("en_tax_key");
            this.Property(t => t.en_sltyp_key).HasColumnName("en_sltyp_key");
            this.Property(t => t.en_cspxf_eprcactf).HasColumnName("en_cspxf_eprcactf");
            this.Property(t => t.en_cspxf_efrtactf).HasColumnName("en_cspxf_efrtactf");
            this.Property(t => t.en_uom_pricedef).HasColumnName("en_uom_pricedef");
            this.Property(t => t.en_uom_orderdef).HasColumnName("en_uom_orderdef");
            this.Property(t => t.gl_cmp_profit).HasColumnName("gl_cmp_profit");
            this.Property(t => t.so_brnch_profit).HasColumnName("so_brnch_profit");
            this.Property(t => t.en_cspxf_shelf).HasColumnName("en_cspxf_shelf");
            this.Property(t => t.en_enduse_key).HasColumnName("en_enduse_key");
            this.Property(t => t.en_cspxf_mktoordf).HasColumnName("en_cspxf_mktoordf");
            this.Property(t => t.en_cspxf_hazmattel).HasColumnName("en_cspxf_hazmattel");
            this.Property(t => t.en_cspxf_hazmatshipername).HasColumnName("en_cspxf_hazmatshipername");
            this.Property(t => t.en_cspxf_hazmatshipertitle).HasColumnName("en_cspxf_hazmatshipertitle");
            this.Property(t => t.en_cspxf_mktoordqtytp).HasColumnName("en_cspxf_mktoordqtytp");
        }
    }
}
