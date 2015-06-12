using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tblSCST_Data_EntryMap : EntityTypeConfiguration<tblSCST_Data_Entry>
    {
        public tblSCST_Data_EntryMap()
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
            this.ToTable("tblSCST_Data_Entry");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.C2004_GoLive_Cost).HasColumnName("2004_GoLive_Cost");
            this.Property(t => t.Purchased_Cost_Notes).HasColumnName("Purchased_Cost_Notes");
            this.Property(t => t.C2005_GOLive_Cost).HasColumnName("2005_GOLive_Cost");
            this.Property(t => t.C2005_Purchased_Costs_Notes).HasColumnName("2005_Purchased_Costs_Notes");
            this.Property(t => t.C2006_GoLive_Cost).HasColumnName("2006_GoLive_Cost");
            this.Property(t => t.C2006_Purchased_Costs_Notes).HasColumnName("2006_Purchased_Costs_Notes");
            this.Property(t => t.C2007_GoLive_Cost).HasColumnName("2007_GoLive_Cost");
            this.Property(t => t.C2007_Purchased_Costs_Notes).HasColumnName("2007_Purchased_Costs_Notes");
            this.Property(t => t.C2008_GoLive_Cost).HasColumnName("2008_GoLive_Cost");
            this.Property(t => t.C2008_Purchased_Costs_Notes).HasColumnName("2008_Purchased_Costs_Notes");
            this.Property(t => t.C2009_GoLive_Cost).HasColumnName("2009_GoLive_Cost");
            this.Property(t => t.C2009_Purchased_Costs_Notes).HasColumnName("2009_Purchased_Costs_Notes");
            this.Property(t => t.C2010_GoLive_Cost).HasColumnName("2010_GoLive_Cost");
            this.Property(t => t.C2010_Purchased_Costs_Notes).HasColumnName("2010_Purchased_Costs_Notes");
            this.Property(t => t.C2011_GoLive_Cost).HasColumnName("2011_GoLive_Cost");
            this.Property(t => t.C2011_Purchased_Costs_Notes).HasColumnName("2011_Purchased_Costs_Notes");
            this.Property(t => t.C2012_GoLive_Cost).HasColumnName("2012_GoLive_Cost");
            this.Property(t => t.C2012_Purchased_Costs_Notes).HasColumnName("2012_Purchased_Costs_Notes");
            this.Property(t => t.C2013_GoLive_Cost).HasColumnName("2013_GoLive_Cost");
            this.Property(t => t.C2013_Purchased_Costs_Notes).HasColumnName("2013_Purchased_Costs_Notes");
            this.Property(t => t.C2014_GoLive_Cost).HasColumnName("2014_GoLive_Cost");
            this.Property(t => t.C2014_Purchased_Costs_Notes).HasColumnName("2014_Purchased_Costs_Notes");
            this.Property(t => t.C2015_GoLive_Cost).HasColumnName("2015_GoLive_Cost");
            this.Property(t => t.C2015_Purchased_Costs_Notes).HasColumnName("2015_Purchased_Costs_Notes");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
        }
    }
}
