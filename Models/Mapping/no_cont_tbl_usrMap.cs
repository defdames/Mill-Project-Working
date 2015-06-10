using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class no_cont_tbl_usrMap : EntityTypeConfiguration<no_cont_tbl_usr>
    {
        public no_cont_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.no_cont_key, t.no_cont_pk });

            // Properties
            this.Property(t => t.no_cont_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.no_cont_pk)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.n_of_n)
                .HasMaxLength(10);

            this.Property(t => t.cust)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("no_cont_tbl_usr");
            this.Property(t => t.no_cont_key).HasColumnName("no_cont_key");
            this.Property(t => t.no_cont_pk).HasColumnName("no_cont_pk");
            this.Property(t => t.ctr_key).HasColumnName("ctr_key");
            this.Property(t => t.n_of_n).HasColumnName("n_of_n");
            this.Property(t => t.cust).HasColumnName("cust");
        }
    }
}
