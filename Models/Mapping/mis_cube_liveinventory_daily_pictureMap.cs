using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_liveinventory_daily_pictureMap : EntityTypeConfiguration<mis_cube_liveinventory_daily_picture>
    {
        public mis_cube_liveinventory_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Company, t.Item, t.Pack, t.GLAcct, t.Lot, t.Location, t.ItemSource, t.Commodity, t.ABCCode, t.MinOQ, t.ROPT, t.SSTK, t.COMinOQ, t.COROPT, t.COSSTK, t.NettablePacks, t.NonNettablePacks, t.TotalPacks, t.QOHExtendedPriceSING, t.QOHEA });

            // Properties
            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Warehouse)
                .HasMaxLength(35);

            this.Property(t => t.Item)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Pack)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.GLAcct)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Lot)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Location)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.ItemSource)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Commodity)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ABCCode)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ROPT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.COROPT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MfgDate)
                .HasMaxLength(40);

            this.Property(t => t.qc_stats_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("mis_cube_liveinventory_daily_picture");
            this.Property(t => t.yearcapture).HasColumnName("yearcapture");
            this.Property(t => t.weekcapture).HasColumnName("weekcapture");
            this.Property(t => t.monthcapture).HasColumnName("monthcapture");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Warehouse).HasColumnName("Warehouse");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.Pack).HasColumnName("Pack");
            this.Property(t => t.GLAcct).HasColumnName("GLAcct");
            this.Property(t => t.Lot).HasColumnName("Lot");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.ItemSource).HasColumnName("ItemSource");
            this.Property(t => t.Commodity).HasColumnName("Commodity");
            this.Property(t => t.ABCCode).HasColumnName("ABCCode");
            this.Property(t => t.MinOQ).HasColumnName("MinOQ");
            this.Property(t => t.ROPT).HasColumnName("ROPT");
            this.Property(t => t.SSTK).HasColumnName("SSTK");
            this.Property(t => t.COMinOQ).HasColumnName("COMinOQ");
            this.Property(t => t.COROPT).HasColumnName("COROPT");
            this.Property(t => t.COSSTK).HasColumnName("COSSTK");
            this.Property(t => t.NettablePacks).HasColumnName("NettablePacks");
            this.Property(t => t.NonNettablePacks).HasColumnName("NonNettablePacks");
            this.Property(t => t.TotalPacks).HasColumnName("TotalPacks");
            this.Property(t => t.NettableQOHLBS).HasColumnName("NettableQOHLBS");
            this.Property(t => t.NettableQOHKGS).HasColumnName("NettableQOHKGS");
            this.Property(t => t.NonNettableQOHLBS).HasColumnName("NonNettableQOHLBS");
            this.Property(t => t.NonNettableQOHKGS).HasColumnName("NonNettableQOHKGS");
            this.Property(t => t.QOHLBS).HasColumnName("QOHLBS");
            this.Property(t => t.QOHKGS).HasColumnName("QOHKGS");
            this.Property(t => t.QOHGAL).HasColumnName("QOHGAL");
            this.Property(t => t.Cost).HasColumnName("Cost");
            this.Property(t => t.NettableExtendedPriceBC).HasColumnName("NettableExtendedPriceBC");
            this.Property(t => t.NonNettableExtendedPriceBC).HasColumnName("NonNettableExtendedPriceBC");
            this.Property(t => t.QOHExtendedPriceBC).HasColumnName("QOHExtendedPriceBC");
            this.Property(t => t.QOHExtendedPriceSING).HasColumnName("QOHExtendedPriceSING");
            this.Property(t => t.MfgDate).HasColumnName("MfgDate");
            this.Property(t => t.qc_stats_key).HasColumnName("qc_stats_key");
            this.Property(t => t.QOHEA).HasColumnName("QOHEA");
        }
    }
}
