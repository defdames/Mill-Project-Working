using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tblSCST_Data_Entry_SLLMap : EntityTypeConfiguration<tblSCST_Data_Entry_SLL>
    {
        public tblSCST_Data_Entry_SLLMap()
        {
            // Primary Key
            this.HasKey(t => t.in_item_key);

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.uom_key)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("tblSCST_Data_Entry_SLL");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.C2009_Std_Costs1).HasColumnName("2009_Std_Costs1");
            this.Property(t => t.C2010_GOLive_Costs).HasColumnName("2010_GOLive_Costs");
            this.Property(t => t.C2010_Purchased_Costs_Notes).HasColumnName("2010_Purchased_Costs_Notes");
            this.Property(t => t.C2011_GOLive_Costs).HasColumnName("2011_GOLive_Costs");
            this.Property(t => t.C2011_Purchased_Costs_Notes).HasColumnName("2011_Purchased_Costs_Notes");
            this.Property(t => t.C2012_GOLive_Costs).HasColumnName("2012_GOLive_Costs");
            this.Property(t => t.C2012_Purchased_Costs_Notes).HasColumnName("2012_Purchased_Costs_Notes");
            this.Property(t => t.C2013_GOLive_Costs).HasColumnName("2013_GOLive_Costs");
            this.Property(t => t.C2013_Purchased_Costs_Notes).HasColumnName("2013_Purchased_Costs_Notes");
            this.Property(t => t.C2014_GOLive_Costs).HasColumnName("2014_GOLive_Costs");
            this.Property(t => t.C2014_Purchased_Costs_Notes).HasColumnName("2014_Purchased_Costs_Notes");
            this.Property(t => t.C2015_GOLive_Costs).HasColumnName("2015_GOLive_Costs");
            this.Property(t => t.C2015_Purchased_Costs_Notes).HasColumnName("2015_Purchased_Costs_Notes");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
        }
    }
}
