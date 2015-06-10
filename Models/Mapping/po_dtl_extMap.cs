using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_dtl_extMap : EntityTypeConfiguration<po_dtl_ext>
    {
        public po_dtl_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_hdr_key, t.po_dtl_key });

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

            this.Property(t => t.po_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ltd_job_number)
                .HasMaxLength(10);

            this.Property(t => t.project_number)
                .HasMaxLength(20);

            this.Property(t => t.xen_prod_key)
                .HasMaxLength(20);

            this.Property(t => t.requisition_number)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("po_dtl_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.ltd_exp_disp_date).HasColumnName("ltd_exp_disp_date");
            this.Property(t => t.ltd_job_number).HasColumnName("ltd_job_number");
            this.Property(t => t.project_number).HasColumnName("project_number");
            this.Property(t => t.xen_prod_key).HasColumnName("xen_prod_key");
            this.Property(t => t.requisition_number).HasColumnName("requisition_number");
            this.Property(t => t.fullprice).HasColumnName("fullprice");
            this.Property(t => t.po_dtl_upcnt).HasColumnName("po_dtl_upcnt");
            this.Property(t => t.po_dtl_shsdt).HasColumnName("po_dtl_shsdt");
        }
    }
}
