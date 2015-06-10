using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_dtl_extMap : EntityTypeConfiguration<so_dtl_ext>
    {
        public so_dtl_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_hdr_key, t.so_dtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.so_dtl_instrux)
                .HasMaxLength(999);

            this.Property(t => t.so_dtl_product)
                .HasMaxLength(60);

            this.Property(t => t.so_dtl_lot)
                .HasMaxLength(25);

            this.Property(t => t.so_dtl_code)
                .HasMaxLength(15);

            this.Property(t => t.so_dtl_country)
                .HasMaxLength(20);

            this.Property(t => t.so_dtl_misc1)
                .HasMaxLength(30);

            this.Property(t => t.so_dtl_misc2)
                .HasMaxLength(30);

            this.Property(t => t.so_dtl_frtitm)
                .HasMaxLength(10);

            this.Property(t => t.shipping_location)
                .HasMaxLength(1);

            this.Property(t => t.w1st_qopcomments)
                .HasMaxLength(999);

            this.Property(t => t.w2nd_qopcomments)
                .HasMaxLength(999);

            this.Property(t => t.w3rd_qopcomments)
                .HasMaxLength(999);

            this.Property(t => t.w4th_qopcomments)
                .HasMaxLength(999);

            this.Property(t => t.w5th_qopcomments)
                .HasMaxLength(999);

            this.Property(t => t.w6th_qopcomments)
                .HasMaxLength(999);

            this.Property(t => t.w7th_qopcomments)
                .HasMaxLength(999);

            this.Property(t => t.w8th_qopcomments)
                .HasMaxLength(999);

            this.Property(t => t.w9th_qopcomments)
                .HasMaxLength(999);

            this.Property(t => t.wx10th_qopcomments)
                .HasMaxLength(999);

            this.Property(t => t.so_dtl_psmarket)
                .HasMaxLength(20);

            this.Property(t => t.zzcurr_rate)
                .HasMaxLength(30);

            this.Property(t => t.prmdateoverride)
                .HasMaxLength(1);

            this.Property(t => t.manualpricingreason)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("so_dtl_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.so_dtl_no_packs).HasColumnName("so_dtl_no_packs");
            this.Property(t => t.so_dtl_instrux).HasColumnName("so_dtl_instrux");
            this.Property(t => t.so_dtl_product).HasColumnName("so_dtl_product");
            this.Property(t => t.so_dtl_lot).HasColumnName("so_dtl_lot");
            this.Property(t => t.so_dtl_code).HasColumnName("so_dtl_code");
            this.Property(t => t.so_dtl_country).HasColumnName("so_dtl_country");
            this.Property(t => t.so_dtl_misc1).HasColumnName("so_dtl_misc1");
            this.Property(t => t.so_dtl_misc2).HasColumnName("so_dtl_misc2");
            this.Property(t => t.so_dtl_frtitm).HasColumnName("so_dtl_frtitm");
            this.Property(t => t.shipping_location).HasColumnName("shipping_location");
            this.Property(t => t.w1st_promisedate).HasColumnName("w1st_promisedate");
            this.Property(t => t.w1st_qopcomments).HasColumnName("w1st_qopcomments");
            this.Property(t => t.w2nd_promisedate).HasColumnName("w2nd_promisedate");
            this.Property(t => t.w2nd_qopcomments).HasColumnName("w2nd_qopcomments");
            this.Property(t => t.w3rd_promisedate).HasColumnName("w3rd_promisedate");
            this.Property(t => t.w3rd_qopcomments).HasColumnName("w3rd_qopcomments");
            this.Property(t => t.w4th_promisedate).HasColumnName("w4th_promisedate");
            this.Property(t => t.w4th_qopcomments).HasColumnName("w4th_qopcomments");
            this.Property(t => t.w5th_promisedate).HasColumnName("w5th_promisedate");
            this.Property(t => t.w5th_qopcomments).HasColumnName("w5th_qopcomments");
            this.Property(t => t.w6th_promisedate).HasColumnName("w6th_promisedate");
            this.Property(t => t.w6th_qopcomments).HasColumnName("w6th_qopcomments");
            this.Property(t => t.w7th_promisedate).HasColumnName("w7th_promisedate");
            this.Property(t => t.w7th_qopcomments).HasColumnName("w7th_qopcomments");
            this.Property(t => t.w8th_promisedate).HasColumnName("w8th_promisedate");
            this.Property(t => t.w8th_qopcomments).HasColumnName("w8th_qopcomments");
            this.Property(t => t.w9th_promisedate).HasColumnName("w9th_promisedate");
            this.Property(t => t.w9th_qopcomments).HasColumnName("w9th_qopcomments");
            this.Property(t => t.wx10th_promisedate).HasColumnName("wx10th_promisedate");
            this.Property(t => t.wx10th_qopcomments).HasColumnName("wx10th_qopcomments");
            this.Property(t => t.so_dtl_psmarket).HasColumnName("so_dtl_psmarket");
            this.Property(t => t.zzcurr_rate).HasColumnName("zzcurr_rate");
            this.Property(t => t.prmdateoverride).HasColumnName("prmdateoverride");
            this.Property(t => t.so_dtl_upcnt).HasColumnName("so_dtl_upcnt");
            this.Property(t => t.manualpricingreason).HasColumnName("manualpricingreason");
            this.Property(t => t.grossweight).HasColumnName("grossweight");
            this.Property(t => t.netweight).HasColumnName("netweight");
            this.Property(t => t.tareweight).HasColumnName("tareweight");
        }
    }
}
