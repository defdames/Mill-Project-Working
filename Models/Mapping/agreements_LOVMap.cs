using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class agreements_LOVMap : EntityTypeConfiguration<agreements_LOV>
    {
        public agreements_LOVMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pc_agrmt_key, t.pc_agrhdr_prod });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_agrmt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agrhdr_prod)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("agreements_LOV");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pc_agrmt_key).HasColumnName("pc_agrmt_key");
            this.Property(t => t.pc_agrhdr_prod).HasColumnName("pc_agrhdr_prod");
        }
    }
}
