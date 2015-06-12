using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class customer_codeMap : EntityTypeConfiguration<customer_code>
    {
        public customer_codeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_hdr_key, t.in_prod_key, t.so_dtl_shpws, t.so_dtl_cprtn, t.gl_cmp_key, t.en_cspxf_cprtn });

            // Properties
            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_dtl_shpws)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_dtl_cprtn)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_cspxf_cprtn)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("customer_code");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.in_prod_key).HasColumnName("in_prod_key");
            this.Property(t => t.so_dtl_shpws).HasColumnName("so_dtl_shpws");
            this.Property(t => t.so_dtl_cprtn).HasColumnName("so_dtl_cprtn");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_cspxf_cprtn).HasColumnName("en_cspxf_cprtn");
        }
    }
}
