using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_rtstp_tblMap : EntityTypeConfiguration<sf_rtstp_tbl>
    {
        public sf_rtstp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_rout_key, t.sf_opseq_key, t.sf_step_seq });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_opseq_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_step_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_crew_key)
                .HasMaxLength(10);

            this.Property(t => t.sf_rsrce_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_rtstp_cappf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sf_rtstp_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sf_rtstp_ubflg)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sf_tool_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_rsrcgrp_key)
                .HasMaxLength(10);

            this.Property(t => t.sf_qctst_id)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("sf_rtstp_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.sf_step_seq).HasColumnName("sf_step_seq");
            this.Property(t => t.sf_crew_key).HasColumnName("sf_crew_key");
            this.Property(t => t.sf_rout_inadt).HasColumnName("sf_rout_inadt");
            this.Property(t => t.sf_rsrce_key).HasColumnName("sf_rsrce_key");
            this.Property(t => t.sf_rtstp_cappf).HasColumnName("sf_rtstp_cappf");
            this.Property(t => t.sf_rtstp_desc).HasColumnName("sf_rtstp_desc");
            this.Property(t => t.sf_rtstp_stdtm).HasColumnName("sf_rtstp_stdtm");
            this.Property(t => t.sf_rtstp_ubflg).HasColumnName("sf_rtstp_ubflg");
            this.Property(t => t.sf_step_id).HasColumnName("sf_step_id");
            this.Property(t => t.sf_tool_key).HasColumnName("sf_tool_key");
            this.Property(t => t.sf_rsrcgrp_key).HasColumnName("sf_rsrcgrp_key");
            this.Property(t => t.sf_rtstp_upcnt).HasColumnName("sf_rtstp_upcnt");
            this.Property(t => t.sf_opseq_type).HasColumnName("sf_opseq_type");
            this.Property(t => t.sf_crew_qty).HasColumnName("sf_crew_qty");
            this.Property(t => t.sf_rtstp_thrput).HasColumnName("sf_rtstp_thrput");
            this.Property(t => t.sf_rtstp_effncy).HasColumnName("sf_rtstp_effncy");
            this.Property(t => t.sf_rout_effdt).HasColumnName("sf_rout_effdt");
            this.Property(t => t.sf_qctst_id).HasColumnName("sf_qctst_id");
        }
    }
}
