using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_lotqc_tblMap : EntityTypeConfiguration<en_lotqc_tbl>
    {
        public en_lotqc_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_item_key, t.en_lot_key, t.en_qcmst_key, t.en_lotqc_seqno, t.im_pack_key, t.en_itqct_effdt, t.qc_sample_key });

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.en_qcmst_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_lotqc_seqno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_lotqc_reslt)
                .HasMaxLength(60);

            this.Property(t => t.en_lotqc_tstby)
                .HasMaxLength(20);

            this.Property(t => t.en_lotqc_text)
                .HasMaxLength(255);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_sppck_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.qc_sample_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.qc_disp_key)
                .HasMaxLength(10);

            this.Property(t => t.en_lotqc_dispnotes)
                .HasMaxLength(255);

            this.Property(t => t.en_lotqc_oresult)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("en_lotqc_tbl");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.en_lot_key).HasColumnName("en_lot_key");
            this.Property(t => t.en_qcmst_key).HasColumnName("en_qcmst_key");
            this.Property(t => t.en_lotqc_seqno).HasColumnName("en_lotqc_seqno");
            this.Property(t => t.en_lotqc_value).HasColumnName("en_lotqc_value");
            this.Property(t => t.en_lotqc_reslt).HasColumnName("en_lotqc_reslt");
            this.Property(t => t.en_lotqc_tstby).HasColumnName("en_lotqc_tstby");
            this.Property(t => t.en_lotqc_tstdt).HasColumnName("en_lotqc_tstdt");
            this.Property(t => t.en_lotqc_stats).HasColumnName("en_lotqc_stats");
            this.Property(t => t.en_lotqc_text).HasColumnName("en_lotqc_text");
            this.Property(t => t.en_lotqc_upcnt).HasColumnName("en_lotqc_upcnt");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_itqct_effdt).HasColumnName("en_itqct_effdt");
            this.Property(t => t.en_sppck_key).HasColumnName("en_sppck_key");
            this.Property(t => t.qc_sample_key).HasColumnName("qc_sample_key");
            this.Property(t => t.qc_disp_key).HasColumnName("qc_disp_key");
            this.Property(t => t.en_lotqc_dispnotes).HasColumnName("en_lotqc_dispnotes");
            this.Property(t => t.en_lotqc_ovalue).HasColumnName("en_lotqc_ovalue");
            this.Property(t => t.en_lotqc_oresult).HasColumnName("en_lotqc_oresult");
            this.Property(t => t.en_lotqc_mnmxop).HasColumnName("en_lotqc_mnmxop");
        }
    }
}
