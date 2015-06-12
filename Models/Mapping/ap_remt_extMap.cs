using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_remt_extMap : EntityTypeConfiguration<ap_remt_ext>
    {
        public ap_remt_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ap_remt_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.bank)
                .HasMaxLength(30);

            this.Property(t => t.bank_sort)
                .HasMaxLength(30);

            this.Property(t => t.companytaxid)
                .HasMaxLength(10);

            this.Property(t => t.recvbankroutnumber)
                .HasMaxLength(10);

            this.Property(t => t.recvbankaccountnumber)
                .HasMaxLength(16);

            this.Property(t => t.individualname)
                .HasMaxLength(22);

            // Table & Column Mappings
            this.ToTable("ap_remt_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.bank).HasColumnName("bank");
            this.Property(t => t.bank_sort).HasColumnName("bank_sort");
            this.Property(t => t.ap_remt_upcnt).HasColumnName("ap_remt_upcnt");
            this.Property(t => t.companytaxid).HasColumnName("companytaxid");
            this.Property(t => t.recvbankroutnumber).HasColumnName("recvbankroutnumber");
            this.Property(t => t.recvbankaccountnumber).HasColumnName("recvbankaccountnumber");
            this.Property(t => t.individualname).HasColumnName("individualname");
        }
    }
}
