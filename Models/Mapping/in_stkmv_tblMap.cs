using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_stkmv_tblMap : EntityTypeConfiguration<in_stkmv_tbl>
    {
        public in_stkmv_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_item_key, t.im_pack_key, t.gl_perod_year, t.gl_perod_id });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("in_stkmv_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
            this.Property(t => t.in_stkmv_boh).HasColumnName("in_stkmv_boh");
            this.Property(t => t.in_stkmv_eoh).HasColumnName("in_stkmv_eoh");
            this.Property(t => t.in_stkmv_iss).HasColumnName("in_stkmv_iss");
            this.Property(t => t.in_stkmv_rcpt).HasColumnName("in_stkmv_rcpt");
            this.Property(t => t.in_stkmv_adj).HasColumnName("in_stkmv_adj");
            this.Property(t => t.in_stkmv_bohc).HasColumnName("in_stkmv_bohc");
            this.Property(t => t.in_stkmv_eohc).HasColumnName("in_stkmv_eohc");
            this.Property(t => t.in_stkmv_issc).HasColumnName("in_stkmv_issc");
            this.Property(t => t.in_stkmv_rcptc).HasColumnName("in_stkmv_rcptc");
            this.Property(t => t.in_stkmv_adjc).HasColumnName("in_stkmv_adjc");
            this.Property(t => t.in_stkmv_ordtpib).HasColumnName("in_stkmv_ordtpib");
            this.Property(t => t.in_stkmv_ordtpic).HasColumnName("in_stkmv_ordtpic");
            this.Property(t => t.in_stkmv_ordtpii).HasColumnName("in_stkmv_ordtpii");
            this.Property(t => t.in_stkmv_ordtpip).HasColumnName("in_stkmv_ordtpip");
            this.Property(t => t.in_stkmv_ordtpis).HasColumnName("in_stkmv_ordtpis");
            this.Property(t => t.in_stkmv_ordtpix).HasColumnName("in_stkmv_ordtpix");
            this.Property(t => t.in_stkmv_ordtpiv).HasColumnName("in_stkmv_ordtpiv");
            this.Property(t => t.in_stkmv_ordtpiw).HasColumnName("in_stkmv_ordtpiw");
            this.Property(t => t.in_stkmv_ordtpiy).HasColumnName("in_stkmv_ordtpiy");
            this.Property(t => t.in_stkmv_ordtpiz).HasColumnName("in_stkmv_ordtpiz");
            this.Property(t => t.in_stkmv_ordtprb).HasColumnName("in_stkmv_ordtprb");
            this.Property(t => t.in_stkmv_ordtprc).HasColumnName("in_stkmv_ordtprc");
            this.Property(t => t.in_stkmv_ordtpri).HasColumnName("in_stkmv_ordtpri");
            this.Property(t => t.in_stkmv_ordtprp).HasColumnName("in_stkmv_ordtprp");
            this.Property(t => t.in_stkmv_ordtprs).HasColumnName("in_stkmv_ordtprs");
            this.Property(t => t.in_stkmv_ordtprx).HasColumnName("in_stkmv_ordtprx");
            this.Property(t => t.in_stkmv_ordtprv).HasColumnName("in_stkmv_ordtprv");
            this.Property(t => t.in_stkmv_ordtprw).HasColumnName("in_stkmv_ordtprw");
            this.Property(t => t.in_stkmv_ordtpry).HasColumnName("in_stkmv_ordtpry");
            this.Property(t => t.in_stkmv_ordtprz).HasColumnName("in_stkmv_ordtprz");
            this.Property(t => t.in_stkmv_ordtpibc).HasColumnName("in_stkmv_ordtpibc");
            this.Property(t => t.in_stkmv_ordtpicc).HasColumnName("in_stkmv_ordtpicc");
            this.Property(t => t.in_stkmv_ordtpiic).HasColumnName("in_stkmv_ordtpiic");
            this.Property(t => t.in_stkmv_ordtpipc).HasColumnName("in_stkmv_ordtpipc");
            this.Property(t => t.in_stkmv_ordtpisc).HasColumnName("in_stkmv_ordtpisc");
            this.Property(t => t.in_stkmv_ordtpixc).HasColumnName("in_stkmv_ordtpixc");
            this.Property(t => t.in_stkmv_ordtpivc).HasColumnName("in_stkmv_ordtpivc");
            this.Property(t => t.in_stkmv_ordtpiwc).HasColumnName("in_stkmv_ordtpiwc");
            this.Property(t => t.in_stkmv_ordtpiyc).HasColumnName("in_stkmv_ordtpiyc");
            this.Property(t => t.in_stkmv_ordtpizc).HasColumnName("in_stkmv_ordtpizc");
            this.Property(t => t.in_stkmv_ordtprbc).HasColumnName("in_stkmv_ordtprbc");
            this.Property(t => t.in_stkmv_ordtprcc).HasColumnName("in_stkmv_ordtprcc");
            this.Property(t => t.in_stkmv_ordtpric).HasColumnName("in_stkmv_ordtpric");
            this.Property(t => t.in_stkmv_ordtprpc).HasColumnName("in_stkmv_ordtprpc");
            this.Property(t => t.in_stkmv_ordtprsc).HasColumnName("in_stkmv_ordtprsc");
            this.Property(t => t.in_stkmv_ordtprxc).HasColumnName("in_stkmv_ordtprxc");
            this.Property(t => t.in_stkmv_ordtprvc).HasColumnName("in_stkmv_ordtprvc");
            this.Property(t => t.in_stkmv_ordtprwc).HasColumnName("in_stkmv_ordtprwc");
            this.Property(t => t.in_stkmv_ordtpryc).HasColumnName("in_stkmv_ordtpryc");
            this.Property(t => t.in_stkmv_ordtprzc).HasColumnName("in_stkmv_ordtprzc");
            this.Property(t => t.in_stkmv_cadjc).HasColumnName("in_stkmv_cadjc");
            this.Property(t => t.in_stkmv_upcnt).HasColumnName("in_stkmv_upcnt");
        }
    }
}
