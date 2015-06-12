using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class blend_on_hand_mainMap : EntityTypeConfiguration<blend_on_hand_main>
    {
        public blend_on_hand_mainMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_whs_key, t.in_item_key, t.gl_perod_year, t.gl_perod_id });

            // Properties
            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("blend_on_hand_main");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
            this.Property(t => t.in_stkmv_boh).HasColumnName("in_stkmv_boh");
            this.Property(t => t.in_stkmv_eoh).HasColumnName("in_stkmv_eoh");
            this.Property(t => t.in_stkmv_rcpt).HasColumnName("in_stkmv_rcpt");
            this.Property(t => t.in_stkmv_iss).HasColumnName("in_stkmv_iss");
            this.Property(t => t.n_stkmv_adj).HasColumnName("n_stkmv_adj");
            this.Property(t => t.in_stkmv_ordtpib).HasColumnName("in_stkmv_ordtpib");
            this.Property(t => t.in_stkmv_ordtpii).HasColumnName("in_stkmv_ordtpii");
            this.Property(t => t.in_stkmv_ordtpri).HasColumnName("in_stkmv_ordtpri");
            this.Property(t => t.in_stkmv_ordtprb).HasColumnName("in_stkmv_ordtprb");
            this.Property(t => t.boh).HasColumnName("boh");
            this.Property(t => t.in_stkmv_ordtprx).HasColumnName("in_stkmv_ordtprx");
            this.Property(t => t.in_stkmv_ordtprc).HasColumnName("in_stkmv_ordtprc");
            this.Property(t => t.in_stkmv_ordtpix).HasColumnName("in_stkmv_ordtpix");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
