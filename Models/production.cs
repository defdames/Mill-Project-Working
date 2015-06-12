using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class production
    {
        public System.DateTime date { get; set; }
        public string system { get; set; }
        public string item { get; set; }
        public string grade { get; set; }
        public Nullable<double> mtlpermillhr { get; set; }
        public Nullable<double> stdpermillhr { get; set; }
        public Nullable<double> percofstd { get; set; }
        public Nullable<double> avgpastepermillhr { get; set; }
        public Nullable<double> metalin { get; set; }
        public Nullable<double> metalout { get; set; }
        public Nullable<double> tothrsavail { get; set; }
        public Nullable<double> tothrsrun { get; set; }
        public Nullable<double> gain1 { get; set; }
        public Nullable<double> percruneff { get; set; }
        public Nullable<double> days { get; set; }
        public Nullable<double> percvol1 { get; set; }
        public Nullable<double> percyeild { get; set; }
        public Nullable<double> pastefrommills { get; set; }
        public string feed { get; set; }
        public Nullable<double> mills { get; set; }
        public Nullable<double> shifts { get; set; }
        public Nullable<double> pasteperday { get; set; }
        public Nullable<double> basketmaterial { get; set; }
        public Nullable<double> basketmaterialsame { get; set; }
        public Nullable<double> basketmaterialoth { get; set; }
        public Nullable<double> basketmaterialutot { get; set; }
        public Nullable<double> gain2 { get; set; }
        public Nullable<double> noofmills { get; set; }
        public Nullable<double> filtercakewt { get; set; }
        public Nullable<double> numberoffc { get; set; }
        public Nullable<double> weightperfc { get; set; }
        public Nullable<double> percvol2 { get; set; }
        public Nullable<double> hrspermill { get; set; }
        public Nullable<double> poundsmetalpermill { get; set; }
        public Nullable<double> poundsmperhronfc { get; set; }
        public Nullable<double> metalbatchsize { get; set; }
        public Nullable<double> classhrs { get; set; }
        public string plant { get; set; }
    }
}
