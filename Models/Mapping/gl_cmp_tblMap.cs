using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_cmp_tblMap : EntityTypeConfiguration<gl_cmp_tbl>
    {
        public gl_cmp_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.gl_cmp_key);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_adr1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_adr2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_postc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cntry_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_fax)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_telex)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_cont1)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_posn1)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_cont2)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_posn2)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_cont3)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_posn3)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_acnno)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_cmp_retac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_cmp_ppsac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_cmp_rndac)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_cmp_taxfn)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.gl_cmp_defbr)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_defpl)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_parnt)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_cmp_cur3)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_cmp_vatreg)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_exon)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mfrid_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_uom_wgt)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_uom_vol)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_uom_key)
                .HasMaxLength(2);

            this.Property(t => t.gl_acct_susp)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_cdvadj)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_cmp_adjreason)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_gln)
                .HasMaxLength(13);

            this.Property(t => t.gl_cmp_hazmattel)
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_hazmatshipername)
                .HasMaxLength(50);

            this.Property(t => t.gl_cmp_hazmatshipertitle)
                .HasMaxLength(100);

            this.Property(t => t.gl_cmp_dlotfrmt)
                .HasMaxLength(250);

            this.Property(t => t.gl_cmp_plotfrmt)
                .HasMaxLength(250);

            this.Property(t => t.gl_cmp_mlotfrmt)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("gl_cmp_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_cmp_desc).HasColumnName("gl_cmp_desc");
            this.Property(t => t.gl_cmp_adr1).HasColumnName("gl_cmp_adr1");
            this.Property(t => t.gl_cmp_adr2).HasColumnName("gl_cmp_adr2");
            this.Property(t => t.gl_cmp_city).HasColumnName("gl_cmp_city");
            this.Property(t => t.gl_cmp_state).HasColumnName("gl_cmp_state");
            this.Property(t => t.gl_cmp_postc).HasColumnName("gl_cmp_postc");
            this.Property(t => t.en_cntry_key).HasColumnName("en_cntry_key");
            this.Property(t => t.gl_cmp_tel).HasColumnName("gl_cmp_tel");
            this.Property(t => t.gl_cmp_fax).HasColumnName("gl_cmp_fax");
            this.Property(t => t.gl_cmp_telex).HasColumnName("gl_cmp_telex");
            this.Property(t => t.gl_cmp_cont1).HasColumnName("gl_cmp_cont1");
            this.Property(t => t.gl_cmp_posn1).HasColumnName("gl_cmp_posn1");
            this.Property(t => t.gl_cmp_cont2).HasColumnName("gl_cmp_cont2");
            this.Property(t => t.gl_cmp_posn2).HasColumnName("gl_cmp_posn2");
            this.Property(t => t.gl_cmp_cont3).HasColumnName("gl_cmp_cont3");
            this.Property(t => t.gl_cmp_posn3).HasColumnName("gl_cmp_posn3");
            this.Property(t => t.gl_cmp_acnno).HasColumnName("gl_cmp_acnno");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.gl_cmp_retac).HasColumnName("gl_cmp_retac");
            this.Property(t => t.gl_cmp_ppsac).HasColumnName("gl_cmp_ppsac");
            this.Property(t => t.gl_cmp_rndac).HasColumnName("gl_cmp_rndac");
            this.Property(t => t.gl_cmp_taxfn).HasColumnName("gl_cmp_taxfn");
            this.Property(t => t.gl_cmp_defbr).HasColumnName("gl_cmp_defbr");
            this.Property(t => t.gl_cmp_defpl).HasColumnName("gl_cmp_defpl");
            this.Property(t => t.gl_cmp_onebr).HasColumnName("gl_cmp_onebr");
            this.Property(t => t.gl_cmp_onepl).HasColumnName("gl_cmp_onepl");
            this.Property(t => t.gl_cmp_parnt).HasColumnName("gl_cmp_parnt");
            this.Property(t => t.gl_cmp_upcnt).HasColumnName("gl_cmp_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_cmp_chgdt).HasColumnName("gl_cmp_chgdt");
            this.Property(t => t.gl_cmp_crtdt).HasColumnName("gl_cmp_crtdt");
            this.Property(t => t.gl_cmp_wtmsf).HasColumnName("gl_cmp_wtmsf");
            this.Property(t => t.gl_cmp_posttol).HasColumnName("gl_cmp_posttol");
            this.Property(t => t.gl_cmp_taxenv).HasColumnName("gl_cmp_taxenv");
            this.Property(t => t.gl_cmp_opt3).HasColumnName("gl_cmp_opt3");
            this.Property(t => t.gl_cmp_cur3).HasColumnName("gl_cmp_cur3");
            this.Property(t => t.gl_cmp_taxcalc).HasColumnName("gl_cmp_taxcalc");
            this.Property(t => t.gl_cmp_recalc).HasColumnName("gl_cmp_recalc");
            this.Property(t => t.gl_cmp_taxincl).HasColumnName("gl_cmp_taxincl");
            this.Property(t => t.gl_cmp_vatreg).HasColumnName("gl_cmp_vatreg");
            this.Property(t => t.gl_cmp_exon).HasColumnName("gl_cmp_exon");
            this.Property(t => t.gl_vatcd_qlf).HasColumnName("gl_vatcd_qlf");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_cmp_lmtamtc).HasColumnName("gl_cmp_lmtamtc");
            this.Property(t => t.gl_cmp_lmtdt).HasColumnName("gl_cmp_lmtdt");
            this.Property(t => t.gl_cmp_ytdlmtc).HasColumnName("gl_cmp_ytdlmtc");
            this.Property(t => t.en_mfrid_key).HasColumnName("en_mfrid_key");
            this.Property(t => t.gl_cmp_crdttol).HasColumnName("gl_cmp_crdttol");
            this.Property(t => t.gl_cmp_crdttolf).HasColumnName("gl_cmp_crdttolf");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.en_uom_wgt).HasColumnName("en_uom_wgt");
            this.Property(t => t.en_uom_vol).HasColumnName("en_uom_vol");
            this.Property(t => t.gl_cmp_pctolbasis).HasColumnName("gl_cmp_pctolbasis");
            this.Property(t => t.gl_cmp_pcundtol).HasColumnName("gl_cmp_pcundtol");
            this.Property(t => t.gl_cmp_pcovrtol).HasColumnName("gl_cmp_pcovrtol");
            this.Property(t => t.en_uom_key).HasColumnName("en_uom_key");
            this.Property(t => t.gl_cmp_enhprcf).HasColumnName("gl_cmp_enhprcf");
            this.Property(t => t.gl_acct_susp).HasColumnName("gl_acct_susp");
            this.Property(t => t.gl_acct_cdvadj).HasColumnName("gl_acct_cdvadj");
            this.Property(t => t.gl_cmp_adjlimit).HasColumnName("gl_cmp_adjlimit");
            this.Property(t => t.gl_cmp_csttol).HasColumnName("gl_cmp_csttol");
            this.Property(t => t.gl_cmp_adjreason).HasColumnName("gl_cmp_adjreason");
            this.Property(t => t.gl_cmp_gln).HasColumnName("gl_cmp_gln");
            this.Property(t => t.gl_cmp_csttoltyp).HasColumnName("gl_cmp_csttoltyp");
            this.Property(t => t.gl_cmp_hazmattel).HasColumnName("gl_cmp_hazmattel");
            this.Property(t => t.gl_cmp_hazmatshipername).HasColumnName("gl_cmp_hazmatshipername");
            this.Property(t => t.gl_cmp_hazmatshipertitle).HasColumnName("gl_cmp_hazmatshipertitle");
            this.Property(t => t.gl_cmp_dlotfrmt).HasColumnName("gl_cmp_dlotfrmt");
            this.Property(t => t.gl_cmp_plotfrmt).HasColumnName("gl_cmp_plotfrmt");
            this.Property(t => t.gl_cmp_mlotfrmt).HasColumnName("gl_cmp_mlotfrmt");
        }
    }
}
