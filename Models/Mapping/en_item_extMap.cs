using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_item_extMap : EntityTypeConfiguration<en_item_ext>
    {
        public en_item_extMap()
        {
            // Primary Key
            this.HasKey(t => t.en_item_key);

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_acctgcost)
                .HasMaxLength(13);

            this.Property(t => t.en_acctgcostuom)
                .HasMaxLength(2);

            this.Property(t => t.en_cost1997q1)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1997q2)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1997q3)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1997q4)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1998q1)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1998q2)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1998q3)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1998q4)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1999q1)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1999q2)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1999q3)
                .HasMaxLength(13);

            this.Property(t => t.en_cost1999q4)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2000q1)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2000q2)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2000q3)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2000q4)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2001q1)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2001q2)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2001q3)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2001q4)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2002q1)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2002q2)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2002q3)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2002q4)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2003q1)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2003q2)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2003q3)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2003q4)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2004q1)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2004q2)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2004q3)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2004q4)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2005q1)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2005q2)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2005q3)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2005q4)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2006q1)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2006q2)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2006q3)
                .HasMaxLength(13);

            this.Property(t => t.en_cost2006q4)
                .HasMaxLength(13);

            this.Property(t => t.en_origcost)
                .HasMaxLength(13);

            // Table & Column Mappings
            this.ToTable("en_item_ext");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.en_acctgcost).HasColumnName("en_acctgcost");
            this.Property(t => t.en_acctgcostuom).HasColumnName("en_acctgcostuom");
            this.Property(t => t.en_cost1997q1).HasColumnName("en_cost1997q1");
            this.Property(t => t.en_cost1997q2).HasColumnName("en_cost1997q2");
            this.Property(t => t.en_cost1997q3).HasColumnName("en_cost1997q3");
            this.Property(t => t.en_cost1997q4).HasColumnName("en_cost1997q4");
            this.Property(t => t.en_cost1998q1).HasColumnName("en_cost1998q1");
            this.Property(t => t.en_cost1998q2).HasColumnName("en_cost1998q2");
            this.Property(t => t.en_cost1998q3).HasColumnName("en_cost1998q3");
            this.Property(t => t.en_cost1998q4).HasColumnName("en_cost1998q4");
            this.Property(t => t.en_cost1999q1).HasColumnName("en_cost1999q1");
            this.Property(t => t.en_cost1999q2).HasColumnName("en_cost1999q2");
            this.Property(t => t.en_cost1999q3).HasColumnName("en_cost1999q3");
            this.Property(t => t.en_cost1999q4).HasColumnName("en_cost1999q4");
            this.Property(t => t.en_cost2000q1).HasColumnName("en_cost2000q1");
            this.Property(t => t.en_cost2000q2).HasColumnName("en_cost2000q2");
            this.Property(t => t.en_cost2000q3).HasColumnName("en_cost2000q3");
            this.Property(t => t.en_cost2000q4).HasColumnName("en_cost2000q4");
            this.Property(t => t.en_cost2001q1).HasColumnName("en_cost2001q1");
            this.Property(t => t.en_cost2001q2).HasColumnName("en_cost2001q2");
            this.Property(t => t.en_cost2001q3).HasColumnName("en_cost2001q3");
            this.Property(t => t.en_cost2001q4).HasColumnName("en_cost2001q4");
            this.Property(t => t.en_cost2002q1).HasColumnName("en_cost2002q1");
            this.Property(t => t.en_cost2002q2).HasColumnName("en_cost2002q2");
            this.Property(t => t.en_cost2002q3).HasColumnName("en_cost2002q3");
            this.Property(t => t.en_cost2002q4).HasColumnName("en_cost2002q4");
            this.Property(t => t.en_cost2003q1).HasColumnName("en_cost2003q1");
            this.Property(t => t.en_cost2003q2).HasColumnName("en_cost2003q2");
            this.Property(t => t.en_cost2003q3).HasColumnName("en_cost2003q3");
            this.Property(t => t.en_cost2003q4).HasColumnName("en_cost2003q4");
            this.Property(t => t.en_cost2004q1).HasColumnName("en_cost2004q1");
            this.Property(t => t.en_cost2004q2).HasColumnName("en_cost2004q2");
            this.Property(t => t.en_cost2004q3).HasColumnName("en_cost2004q3");
            this.Property(t => t.en_cost2004q4).HasColumnName("en_cost2004q4");
            this.Property(t => t.en_cost2005q1).HasColumnName("en_cost2005q1");
            this.Property(t => t.en_cost2005q2).HasColumnName("en_cost2005q2");
            this.Property(t => t.en_cost2005q3).HasColumnName("en_cost2005q3");
            this.Property(t => t.en_cost2005q4).HasColumnName("en_cost2005q4");
            this.Property(t => t.en_cost2006q1).HasColumnName("en_cost2006q1");
            this.Property(t => t.en_cost2006q2).HasColumnName("en_cost2006q2");
            this.Property(t => t.en_cost2006q3).HasColumnName("en_cost2006q3");
            this.Property(t => t.en_cost2006q4).HasColumnName("en_cost2006q4");
            this.Property(t => t.en_inv_sstk).HasColumnName("en_inv_sstk");
            this.Property(t => t.en_inv_min).HasColumnName("en_inv_min");
            this.Property(t => t.en_inv_ropt).HasColumnName("en_inv_ropt");
            this.Property(t => t.en_inv_max).HasColumnName("en_inv_max");
            this.Property(t => t.en_origcost).HasColumnName("en_origcost");
            this.Property(t => t.en_item_upcnt).HasColumnName("en_item_upcnt");
        }
    }
}
