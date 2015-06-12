using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class pds_ExtraProductProperties
    {
        public string Item { get; set; }
        public string Grade { get; set; }
        public string NonVolatileByVolume { get; set; }
        public string SpecificGravity1 { get; set; }
        public string Solvent { get; set; }
        public string FederalSpecification { get; set; }
        public string ASTMSpecification { get; set; }
        public string Composition1 { get; set; }
        public string Composition2 { get; set; }
        public string Carrier { get; set; }
        public string PercentCarrier { get; set; }
        public string ResinBinder { get; set; }
        public string FlashPoint1 { get; set; }
        public string AluminumFlakeContent { get; set; }
        public string StearicAcidContent { get; set; }
        public string WaterCoverage { get; set; }
        public string FattyAcidContent { get; set; }
        public string MoistureContent { get; set; }
        public Nullable<decimal> WeightVolumePounds { get; set; }
        public Nullable<decimal> WeightVolumeKilos { get; set; }
        public string ParticleSize { get; set; }
        public string ScreenAnalysis { get; set; }
        public string LeafingValue { get; set; }
        public string NonVolatileByWeight { get; set; }
        public string MSDS { get; set; }
        public Nullable<decimal> BulkingGallonsPounds { get; set; }
        public string MedianFlakeSize { get; set; }
    }
}
