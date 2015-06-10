using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_check_detail_v1_sapMap : EntityTypeConfiguration<ap_check_detail_v1_sap>
    {
        public ap_check_detail_v1_sapMap()
        {
            // Primary Key
            this.HasKey(t => t.gl_cmp_key);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_payhdr_tranref)
                .HasMaxLength(20);

            this.Property(t => t.ap_paydtl_docno)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ap_check_detail_v1_sap");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ap_payhdr_tranref).HasColumnName("ap_payhdr_tranref");
            this.Property(t => t.ap_paydtl_amt).HasColumnName("ap_paydtl_amt");
            this.Property(t => t.ap_paydtl_amtf).HasColumnName("ap_paydtl_amtf");
            this.Property(t => t.ap_paydtl_key).HasColumnName("ap_paydtl_key");
            this.Property(t => t.ap_paydtl_docno).HasColumnName("ap_paydtl_docno");
        }
    }
}
