using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_whs_tblMap : EntityTypeConfiguration<en_whs_tbl>
    {
        public en_whs_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_whs_key);

            // Properties
            this.Property(t => t.en_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_whs_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_whs_type)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_comp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_whs_shppt)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_whs_glid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_frtzone_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_sltyp_key)
                .HasMaxLength(10);

            this.Property(t => t.en_whs_tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_whs_telex)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_geocode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_whs_adr1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_whs_adr2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_whs_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_whs_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_whs_fax)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_whs_cont)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_whs_postc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_whs_cntry)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_tax_salestaxkey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_tax_usetaxkey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mfrid_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_whs_tbl");
            this.Property(t => t.en_whs_key).HasColumnName("en_whs_key");
            this.Property(t => t.en_whs_name).HasColumnName("en_whs_name");
            this.Property(t => t.en_whs_sqsiz).HasColumnName("en_whs_sqsiz");
            this.Property(t => t.en_whs_cusiz).HasColumnName("en_whs_cusiz");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.en_whs_type).HasColumnName("en_whs_type");
            this.Property(t => t.en_comp_key).HasColumnName("en_comp_key");
            this.Property(t => t.en_whs_mnchg).HasColumnName("en_whs_mnchg");
            this.Property(t => t.en_whs_actf).HasColumnName("en_whs_actf");
            this.Property(t => t.en_whs_extf).HasColumnName("en_whs_extf");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_whs_shppt).HasColumnName("en_whs_shppt");
            this.Property(t => t.en_whs_glid).HasColumnName("en_whs_glid");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_whs_chgdt).HasColumnName("en_whs_chgdt");
            this.Property(t => t.en_whs_crtdt).HasColumnName("en_whs_crtdt");
            this.Property(t => t.en_frtzone_key).HasColumnName("en_frtzone_key");
            this.Property(t => t.en_sltyp_key).HasColumnName("en_sltyp_key");
            this.Property(t => t.en_whs_tel).HasColumnName("en_whs_tel");
            this.Property(t => t.en_whs_telex).HasColumnName("en_whs_telex");
            this.Property(t => t.en_geocode_key).HasColumnName("en_geocode_key");
            this.Property(t => t.en_whs_adr1).HasColumnName("en_whs_adr1");
            this.Property(t => t.en_whs_adr2).HasColumnName("en_whs_adr2");
            this.Property(t => t.en_whs_city).HasColumnName("en_whs_city");
            this.Property(t => t.en_whs_state).HasColumnName("en_whs_state");
            this.Property(t => t.en_whs_fax).HasColumnName("en_whs_fax");
            this.Property(t => t.en_whs_cont).HasColumnName("en_whs_cont");
            this.Property(t => t.en_whs_postc).HasColumnName("en_whs_postc");
            this.Property(t => t.en_whs_cntry).HasColumnName("en_whs_cntry");
            this.Property(t => t.en_tax_salestaxkey).HasColumnName("en_tax_salestaxkey");
            this.Property(t => t.en_tax_usetaxkey).HasColumnName("en_tax_usetaxkey");
            this.Property(t => t.en_mfrid_key).HasColumnName("en_mfrid_key");
            this.Property(t => t.en_whs_upcnt).HasColumnName("en_whs_upcnt");
            this.Property(t => t.en_whs_cnsgnf).HasColumnName("en_whs_cnsgnf");
        }
    }
}
