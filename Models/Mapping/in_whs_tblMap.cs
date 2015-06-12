using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_whs_tblMap : EntityTypeConfiguration<in_whs_tbl>
    {
        public in_whs_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_whs_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.in_whs_type)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_adr1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.in_whs_adr2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.in_whs_postc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_whs_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cntry_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_whs_tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_whs_fax)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_whs_cont)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_whs_telex)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_pbrch)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_whs_nsloc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_invac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_scpac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_invvr)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_missa)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_mreca)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_invaj)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_sdcaj)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_stgac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_trnst)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_trnloc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_inspl)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_wofac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.in_whs_nnlocn)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_stdvr)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_stagl)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_loadl)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frtzone_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_geocode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_wostgl)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_fob_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_trnvarac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ar_tax_salestaxkey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_tax_usetaxkey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_acct_afillvar)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.en_mfrid_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_acct_icreturn)
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_suspense)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_ldfrmt)
                .HasMaxLength(255);

            this.Property(t => t.gl_acct_icppvar)
                .HasMaxLength(40);

            this.Property(t => t.gl_bunit_key)
                .HasMaxLength(38);

            this.Property(t => t.gl_acct_unallocsus)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_autoblend)
                .HasMaxLength(40);

            this.Property(t => t.in_whs_pprplnt)
                .HasMaxLength(4);

            this.Property(t => t.in_whs_vatreg)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_whs_blendac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_purOverHeadVar)
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_DistOverHeadVar)
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_invcostVar)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whs_holdlocation)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_wmsuser)
                .HasMaxLength(8);

            this.Property(t => t.in_whs_dlotfrmt)
                .HasMaxLength(250);

            this.Property(t => t.in_whs_plotfrmt)
                .HasMaxLength(250);

            this.Property(t => t.in_whs_mlotfrmt)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("in_whs_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_whs_upcnt).HasColumnName("in_whs_upcnt");
            this.Property(t => t.in_whs_name).HasColumnName("in_whs_name");
            this.Property(t => t.in_whs_type).HasColumnName("in_whs_type");
            this.Property(t => t.in_whs_adr1).HasColumnName("in_whs_adr1");
            this.Property(t => t.in_whs_adr2).HasColumnName("in_whs_adr2");
            this.Property(t => t.in_whs_postc).HasColumnName("in_whs_postc");
            this.Property(t => t.in_whs_city).HasColumnName("in_whs_city");
            this.Property(t => t.in_whs_state).HasColumnName("in_whs_state");
            this.Property(t => t.en_cntry_key).HasColumnName("en_cntry_key");
            this.Property(t => t.in_whs_tel).HasColumnName("in_whs_tel");
            this.Property(t => t.in_whs_fax).HasColumnName("in_whs_fax");
            this.Property(t => t.in_whs_cont).HasColumnName("in_whs_cont");
            this.Property(t => t.in_whs_telex).HasColumnName("in_whs_telex");
            this.Property(t => t.in_whs_sqsiz).HasColumnName("in_whs_sqsiz");
            this.Property(t => t.in_whs_mnchg).HasColumnName("in_whs_mnchg");
            this.Property(t => t.in_whs_cusiz).HasColumnName("in_whs_cusiz");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.in_whs_pbrch).HasColumnName("in_whs_pbrch");
            this.Property(t => t.in_whs_nsloc).HasColumnName("in_whs_nsloc");
            this.Property(t => t.in_whs_invac).HasColumnName("in_whs_invac");
            this.Property(t => t.in_whs_scpac).HasColumnName("in_whs_scpac");
            this.Property(t => t.in_whs_invvr).HasColumnName("in_whs_invvr");
            this.Property(t => t.in_whs_missa).HasColumnName("in_whs_missa");
            this.Property(t => t.in_whs_mreca).HasColumnName("in_whs_mreca");
            this.Property(t => t.in_whs_invaj).HasColumnName("in_whs_invaj");
            this.Property(t => t.in_whs_sdcaj).HasColumnName("in_whs_sdcaj");
            this.Property(t => t.in_whs_stgac).HasColumnName("in_whs_stgac");
            this.Property(t => t.in_whs_trnst).HasColumnName("in_whs_trnst");
            this.Property(t => t.in_whs_trnloc).HasColumnName("in_whs_trnloc");
            this.Property(t => t.in_whs_inspl).HasColumnName("in_whs_inspl");
            this.Property(t => t.in_whs_wofac).HasColumnName("in_whs_wofac");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_whs_chgdt).HasColumnName("in_whs_chgdt");
            this.Property(t => t.in_whs_crtdt).HasColumnName("in_whs_crtdt");
            this.Property(t => t.in_whs_nnlocn).HasColumnName("in_whs_nnlocn");
            this.Property(t => t.in_whs_stdvr).HasColumnName("in_whs_stdvr");
            this.Property(t => t.in_whs_ffltm).HasColumnName("in_whs_ffltm");
            this.Property(t => t.in_whs_piktm).HasColumnName("in_whs_piktm");
            this.Property(t => t.in_whs_rsrvtm).HasColumnName("in_whs_rsrvtm");
            this.Property(t => t.in_whs_stagl).HasColumnName("in_whs_stagl");
            this.Property(t => t.in_whs_loadl).HasColumnName("in_whs_loadl");
            this.Property(t => t.en_frtzone_key).HasColumnName("en_frtzone_key");
            this.Property(t => t.en_geocode_key).HasColumnName("en_geocode_key");
            this.Property(t => t.in_whs_wostgl).HasColumnName("in_whs_wostgl");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
            this.Property(t => t.in_whs_carrf).HasColumnName("in_whs_carrf");
            this.Property(t => t.in_whs_trnvarac).HasColumnName("in_whs_trnvarac");
            this.Property(t => t.ar_tax_salestaxkey).HasColumnName("ar_tax_salestaxkey");
            this.Property(t => t.ar_tax_usetaxkey).HasColumnName("ar_tax_usetaxkey");
            this.Property(t => t.gl_acct_afillvar).HasColumnName("gl_acct_afillvar");
            this.Property(t => t.en_mfrid_key).HasColumnName("en_mfrid_key");
            this.Property(t => t.in_whs_autoclspckf).HasColumnName("in_whs_autoclspckf");
            this.Property(t => t.in_whs_autoprtpckf).HasColumnName("in_whs_autoprtpckf");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.gl_acct_icreturn).HasColumnName("gl_acct_icreturn");
            this.Property(t => t.gl_acct_suspense).HasColumnName("gl_acct_suspense");
            this.Property(t => t.in_whs_ldfrmt).HasColumnName("in_whs_ldfrmt");
            this.Property(t => t.gl_acct_icppvar).HasColumnName("gl_acct_icppvar");
            this.Property(t => t.gl_bunit_key).HasColumnName("gl_bunit_key");
            this.Property(t => t.gl_acct_unallocsus).HasColumnName("gl_acct_unallocsus");
            this.Property(t => t.in_whs_shpdtf).HasColumnName("in_whs_shpdtf");
            this.Property(t => t.in_whs_shppcf).HasColumnName("in_whs_shppcf");
            this.Property(t => t.gl_acct_autoblend).HasColumnName("gl_acct_autoblend");
            this.Property(t => t.in_whs_cnsgnf).HasColumnName("in_whs_cnsgnf");
            this.Property(t => t.in_whs_usagecntf).HasColumnName("in_whs_usagecntf");
            this.Property(t => t.in_whs_pprplnt).HasColumnName("in_whs_pprplnt");
            this.Property(t => t.in_whs_pklstitm).HasColumnName("in_whs_pklstitm");
            this.Property(t => t.in_whs_sopriortime).HasColumnName("in_whs_sopriortime");
            this.Property(t => t.in_whs_autolotselectf).HasColumnName("in_whs_autolotselectf");
            this.Property(t => t.in_whs_vatreg).HasColumnName("in_whs_vatreg");
            this.Property(t => t.in_whs_blendac).HasColumnName("in_whs_blendac");
            this.Property(t => t.in_whs_wmsf).HasColumnName("in_whs_wmsf");
            this.Property(t => t.in_whs_picklistoption).HasColumnName("in_whs_picklistoption");
            this.Property(t => t.in_whs_shippreference).HasColumnName("in_whs_shippreference");
            this.Property(t => t.in_whs_shpdtpreference).HasColumnName("in_whs_shpdtpreference");
            this.Property(t => t.in_whs_pickupdefault).HasColumnName("in_whs_pickupdefault");
            this.Property(t => t.gl_acct_purOverHeadVar).HasColumnName("gl_acct_purOverHeadVar");
            this.Property(t => t.gl_acct_DistOverHeadVar).HasColumnName("gl_acct_DistOverHeadVar");
            this.Property(t => t.in_whs_eamflag).HasColumnName("in_whs_eamflag");
            this.Property(t => t.gl_acct_invcostVar).HasColumnName("gl_acct_invcostVar");
            this.Property(t => t.in_whs_allowshipmentf).HasColumnName("in_whs_allowshipmentf");
            this.Property(t => t.in_whs_autoreleaseshipf).HasColumnName("in_whs_autoreleaseshipf");
            this.Property(t => t.in_whs_holdlocation).HasColumnName("in_whs_holdlocation");
            this.Property(t => t.in_whs_wmsuser).HasColumnName("in_whs_wmsuser");
            this.Property(t => t.in_whs_dlotfrmt).HasColumnName("in_whs_dlotfrmt");
            this.Property(t => t.in_whs_plotfrmt).HasColumnName("in_whs_plotfrmt");
            this.Property(t => t.in_whs_mlotfrmt).HasColumnName("in_whs_mlotfrmt");
            this.Property(t => t.in_whs_scebackflushf).HasColumnName("in_whs_scebackflushf");
        }
    }
}
