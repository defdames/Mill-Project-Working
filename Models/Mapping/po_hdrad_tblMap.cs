using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_hdrad_tblMap : EntityTypeConfiguration<po_hdrad_tbl>
    {
        public po_hdrad_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_hdr_key, t.po_hdrad_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_hdrad_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_hdrad_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.po_hdrad_adr1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.po_hdrad_adr2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.po_hdrad_adr3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.po_hdrad_cty)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_hdrad_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_hdrad_pczip)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_hdrad_tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_hdrad_telex)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_hdrad_fax)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_cntry_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.po_hdrad_cmnts)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("po_hdrad_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_hdrad_key).HasColumnName("po_hdrad_key");
            this.Property(t => t.po_hdrad_name).HasColumnName("po_hdrad_name");
            this.Property(t => t.po_hdrad_adr1).HasColumnName("po_hdrad_adr1");
            this.Property(t => t.po_hdrad_adr2).HasColumnName("po_hdrad_adr2");
            this.Property(t => t.po_hdrad_adr3).HasColumnName("po_hdrad_adr3");
            this.Property(t => t.po_hdrad_cty).HasColumnName("po_hdrad_cty");
            this.Property(t => t.po_hdrad_state).HasColumnName("po_hdrad_state");
            this.Property(t => t.po_hdrad_pczip).HasColumnName("po_hdrad_pczip");
            this.Property(t => t.po_hdrad_tel).HasColumnName("po_hdrad_tel");
            this.Property(t => t.po_hdrad_telex).HasColumnName("po_hdrad_telex");
            this.Property(t => t.po_hdrad_fax).HasColumnName("po_hdrad_fax");
            this.Property(t => t.en_cntry_key).HasColumnName("en_cntry_key");
            this.Property(t => t.po_hdrad_crtdt).HasColumnName("po_hdrad_crtdt");
            this.Property(t => t.po_hdrad_chgdt).HasColumnName("po_hdrad_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.po_hdrad_cmnts).HasColumnName("po_hdrad_cmnts");
            this.Property(t => t.po_hdrad_upcnt).HasColumnName("po_hdrad_upcnt");
        }
    }
}
