using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_glb_overduepastMap : EntityTypeConfiguration<CHINA_glb_overduepast>
    {
        public CHINA_glb_overduepastMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillTo, t.SoldTo, t.IvhdrType, t.HdrKey, t.Date, t.Credit, t.gl_cmp_key });

            // Properties
            this.Property(t => t.BillTo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SoldTo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SoldName)
                .HasMaxLength(30);

            this.Property(t => t.SoldLine1)
                .HasMaxLength(67);

            this.Property(t => t.SoldLine2)
                .HasMaxLength(67);

            this.Property(t => t.SoldLine3)
                .HasMaxLength(67);

            this.Property(t => t.SoldCSZ)
                .HasMaxLength(67);

            this.Property(t => t.IvhdrType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.HdrKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Credit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Salsm)
                .HasMaxLength(10);

            this.Property(t => t.Int_)
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_cpono)
                .HasMaxLength(25);

            this.Property(t => t.en_terms_desc)
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_glb_overduepast");
            this.Property(t => t.BillTo).HasColumnName("BillTo");
            this.Property(t => t.SoldTo).HasColumnName("SoldTo");
            this.Property(t => t.SoldName).HasColumnName("SoldName");
            this.Property(t => t.SoldLine1).HasColumnName("SoldLine1");
            this.Property(t => t.SoldLine2).HasColumnName("SoldLine2");
            this.Property(t => t.SoldLine3).HasColumnName("SoldLine3");
            this.Property(t => t.SoldCSZ).HasColumnName("SoldCSZ");
            this.Property(t => t.IvhdrType).HasColumnName("IvhdrType");
            this.Property(t => t.HdrKey).HasColumnName("HdrKey");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Charge).HasColumnName("Charge");
            this.Property(t => t.Credit).HasColumnName("Credit");
            this.Property(t => t.Salsm).HasColumnName("Salsm");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.StartAT).HasColumnName("StartAT");
            this.Property(t => t.Int_).HasColumnName("Int#");
            this.Property(t => t.so_hdr_cpono).HasColumnName("so_hdr_cpono");
            this.Property(t => t.en_terms_desc).HasColumnName("en_terms_desc");
            this.Property(t => t.daysdue).HasColumnName("daysdue");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
