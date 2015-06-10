using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_insmst_tblMap : EntityTypeConfiguration<im_insmst_tbl>
    {
        public im_insmst_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.im_insmst_key);

            // Properties
            this.Property(t => t.im_insmst_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_incls_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_insmst_name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_insmst_inttxt)
                .IsRequired()
                .HasMaxLength(76);

            this.Property(t => t.im_insmst_extfile)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("im_insmst_tbl");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.im_incls_key).HasColumnName("im_incls_key");
            this.Property(t => t.im_insmst_txtflg).HasColumnName("im_insmst_txtflg");
            this.Property(t => t.im_insmst_name).HasColumnName("im_insmst_name");
            this.Property(t => t.im_insmst_inttxt).HasColumnName("im_insmst_inttxt");
            this.Property(t => t.im_insmst_extfile).HasColumnName("im_insmst_extfile");
            this.Property(t => t.im_insmst_upcnt).HasColumnName("im_insmst_upcnt");
            this.Property(t => t.im_insmst_effdt).HasColumnName("im_insmst_effdt");
            this.Property(t => t.im_insmst_inadt).HasColumnName("im_insmst_inadt");
            this.Property(t => t.im_cppmst_key).HasColumnName("im_cppmst_key");
            this.Property(t => t.im_prpmst_key).HasColumnName("im_prpmst_key");
        }
    }
}
