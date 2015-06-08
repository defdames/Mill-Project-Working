namespace Mill_Project.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<gl_cmp_tbl> gl_cmp_tbl { get; set; }
        public virtual DbSet<mill_Mills> mill_Mills { get; set; }
        public virtual DbSet<mill_Mills_Utilization> mill_Mills_Utilization { get; set; }
        public virtual DbSet<mill_Shift_Categories> mill_Shift_Categories { get; set; }
        public virtual DbSet<mill_Shift_Patterns> mill_Shift_Patterns { get; set; }
        public virtual DbSet<mill_Stoppage_Reasons> mill_Stoppage_Reasons { get; set; }
        public virtual DbSet<mill_Sys_Mills_Combo> mill_Sys_Mills_Combo { get; set; }
        public virtual DbSet<mill_Systems> mill_Systems { get; set; }
        public virtual DbSet<sf_plant_tbl> sf_plant_tbl { get; set; }
        public virtual DbSet<web_sa_cmp_tbl> web_sa_cmp_tbl { get; set; }
        public virtual DbSet<web_sa_user_tbl> web_sa_user_tbl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_key)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_desc)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_adr1)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_adr2)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_city)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_state)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_postc)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.en_cntry_key)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_tel)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_fax)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_telex)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_cont1)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_posn1)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_cont2)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_posn2)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_cont3)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_posn3)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_acnno)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_crncy_key)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_retac)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_ppsac)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_rndac)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_taxfn)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_defbr)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_defpl)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_parnt)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.sa_user_key)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_cur3)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_vatreg)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_exon)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_vatcd_key)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.en_mfrid_key)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_bkcd_key)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.en_uom_wgt)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.en_uom_vol)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.en_uom_key)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_acct_susp)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_acct_cdvadj)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_adjreason)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_gln)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_hazmattel)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_hazmatshipername)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_hazmatshipertitle)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_dlotfrmt)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_plotfrmt)
                .IsUnicode(false);

            modelBuilder.Entity<gl_cmp_tbl>()
                .Property(e => e.gl_cmp_mlotfrmt)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills>()
                .Property(e => e.Mill_ID)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills>()
                .Property(e => e.Active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills>()
                .Property(e => e.gl_cmp_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills>()
                .Property(e => e.sf_plant_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills>()
                .Property(e => e.Created_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills>()
                .Property(e => e.Modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.Mill_ID)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.System)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.RunCode)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.Shift)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.sa_user_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.Item_Number)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.Shift_Category)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.gl_cmp_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.sf_plant_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.Created_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Mills_Utilization>()
                .Property(e => e.Modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Categories>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Categories>()
                .Property(e => e.Category_Description)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Categories>()
                .Property(e => e.gl_cmp_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Categories>()
                .Property(e => e.sf_plant_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Categories>()
                .Property(e => e.Created_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Categories>()
                .Property(e => e.Modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Patterns>()
                .Property(e => e.Shift_ID)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Patterns>()
                .Property(e => e.Shift_Active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Patterns>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Patterns>()
                .Property(e => e.Shift_Hours_Cross_Days)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Patterns>()
                .Property(e => e.gl_cmp_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Patterns>()
                .Property(e => e.sf_plant_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Patterns>()
                .Property(e => e.Created_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Shift_Patterns>()
                .Property(e => e.Modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Stoppage_Reasons>()
                .Property(e => e.Stop_Reason)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Stoppage_Reasons>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Stoppage_Reasons>()
                .Property(e => e.gl_cmp_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Stoppage_Reasons>()
                .Property(e => e.sf_plant_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Stoppage_Reasons>()
                .Property(e => e.Created_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Stoppage_Reasons>()
                .Property(e => e.Modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Sys_Mills_Combo>()
                .Property(e => e.System)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Sys_Mills_Combo>()
                .Property(e => e.Mill_ID)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Sys_Mills_Combo>()
                .Property(e => e.Active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mill_Sys_Mills_Combo>()
                .Property(e => e.gl_cmp_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Sys_Mills_Combo>()
                .Property(e => e.sf_plant_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Sys_Mills_Combo>()
                .Property(e => e.Created_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Sys_Mills_Combo>()
                .Property(e => e.Modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Systems>()
                .Property(e => e.System_Name)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Systems>()
                .Property(e => e.Active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mill_Systems>()
                .Property(e => e.Force_Mill_Test_Data_Entry)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mill_Systems>()
                .Property(e => e.gl_cmp_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Systems>()
                .Property(e => e.sf_plant_key)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Systems>()
                .Property(e => e.Created_by)
                .IsUnicode(false);

            modelBuilder.Entity<mill_Systems>()
                .Property(e => e.Modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.gl_cmp_key)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_key)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_name)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_adr1)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_adr2)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_postc)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_city)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_state)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_cntry)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_tel)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_fax)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_cont)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_telex)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_defwh)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_wdays_key)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sa_user_key)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.gl_bkcd_key)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_sact)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.gl_bunit_key)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_rvdadjac)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_rvoadjac)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_plant_mvadjac)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_lotfrmt_key)
                .IsUnicode(false);

            modelBuilder.Entity<sf_plant_tbl>()
                .Property(e => e.sf_mfgrp_key)
                .IsUnicode(false);

            modelBuilder.Entity<web_sa_cmp_tbl>()
                .Property(e => e.sa_user_key)
                .IsUnicode(false);

            modelBuilder.Entity<web_sa_cmp_tbl>()
                .Property(e => e.gl_cmp_key)
                .IsUnicode(false);

            modelBuilder.Entity<web_sa_cmp_tbl>()
                .Property(e => e._default)
                .IsUnicode(false);

            modelBuilder.Entity<web_sa_user_tbl>()
                .Property(e => e.sa_user_key)
                .IsUnicode(false);

            modelBuilder.Entity<web_sa_user_tbl>()
                .Property(e => e.sa_user_name)
                .IsUnicode(false);
        }
    }
}
