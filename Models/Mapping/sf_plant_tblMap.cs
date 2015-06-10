using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_plant_tblMap : EntityTypeConfiguration<sf_plant_tbl>
    {
        public sf_plant_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_plant_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sf_plant_adr1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sf_plant_adr2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sf_plant_postc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_plant_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_plant_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_plant_cntry)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_plant_tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_plant_fax)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_plant_cont)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_plant_telex)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_plant_defwh)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_wdays_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_sact)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_bunit_key)
                .HasMaxLength(38);

            this.Property(t => t.sf_plant_rvdadjac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sf_plant_rvoadjac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sf_plant_mvadjac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sf_lotfrmt_key)
                .HasMaxLength(250);

            this.Property(t => t.sf_mfgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("sf_plant_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_plant_name).HasColumnName("sf_plant_name");
            this.Property(t => t.sf_plant_adr1).HasColumnName("sf_plant_adr1");
            this.Property(t => t.sf_plant_adr2).HasColumnName("sf_plant_adr2");
            this.Property(t => t.sf_plant_postc).HasColumnName("sf_plant_postc");
            this.Property(t => t.sf_plant_city).HasColumnName("sf_plant_city");
            this.Property(t => t.sf_plant_state).HasColumnName("sf_plant_state");
            this.Property(t => t.sf_plant_cntry).HasColumnName("sf_plant_cntry");
            this.Property(t => t.sf_plant_tel).HasColumnName("sf_plant_tel");
            this.Property(t => t.sf_plant_fax).HasColumnName("sf_plant_fax");
            this.Property(t => t.sf_plant_cont).HasColumnName("sf_plant_cont");
            this.Property(t => t.sf_plant_telex).HasColumnName("sf_plant_telex");
            this.Property(t => t.sf_plant_defwh).HasColumnName("sf_plant_defwh");
            this.Property(t => t.sf_wdays_key).HasColumnName("sf_wdays_key");
            this.Property(t => t.sf_plant_sdthr).HasColumnName("sf_plant_sdthr");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_plant_crtdt).HasColumnName("en_plant_crtdt");
            this.Property(t => t.en_plant_chgdt).HasColumnName("en_plant_chgdt");
            this.Property(t => t.sf_plant_advschf).HasColumnName("sf_plant_advschf");
            this.Property(t => t.sf_plant_prdtmbkt).HasColumnName("sf_plant_prdtmbkt");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.sf_plant_sact).HasColumnName("sf_plant_sact");
            this.Property(t => t.gl_bunit_key).HasColumnName("gl_bunit_key");
            this.Property(t => t.sf_plant_rvdadjac).HasColumnName("sf_plant_rvdadjac");
            this.Property(t => t.sf_plant_rvoadjac).HasColumnName("sf_plant_rvoadjac");
            this.Property(t => t.sf_plant_mvadjac).HasColumnName("sf_plant_mvadjac");
            this.Property(t => t.sf_plant_autprdtnf).HasColumnName("sf_plant_autprdtnf");
            this.Property(t => t.sf_plant_defqty).HasColumnName("sf_plant_defqty");
            this.Property(t => t.sf_lotfrmt_key).HasColumnName("sf_lotfrmt_key");
            this.Property(t => t.sf_plant_upcnt).HasColumnName("sf_plant_upcnt");
            this.Property(t => t.sf_mfgrp_key).HasColumnName("sf_mfgrp_key");
            this.Property(t => t.sf_plant_cmplttolr).HasColumnName("sf_plant_cmplttolr");
            this.Property(t => t.sf_plant_deptreqf).HasColumnName("sf_plant_deptreqf");
        }
    }
}
