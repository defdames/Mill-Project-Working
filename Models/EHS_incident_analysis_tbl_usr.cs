using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class EHS_incident_analysis_tbl_usr
    {
        public int Incident_no { get; set; }
        public string Company { get; set; }
        public System.DateTime Incident_date { get; set; }
        public System.DateTime Incident_time { get; set; }
        public System.DateTime Reported_date { get; set; }
        public Nullable<System.DateTime> Completed_date { get; set; }
        public string Supervisor { get; set; }
        public string Location { get; set; }
        public string Emp_last { get; set; }
        public string Emp_mi { get; set; }
        public string Emp_first { get; set; }
        public string Incident_classification { get; set; }
        public Nullable<System.DateTime> Injury_time { get; set; }
        public Nullable<decimal> Years_service { get; set; }
        public Nullable<System.DateTime> Shift_start_time { get; set; }
        public string Job_title { get; set; }
        public Nullable<decimal> Age { get; set; }
        public string Department { get; set; }
        public string Injury_description { get; set; }
        public string Short_incident_desc { get; set; }
        public string Injury_type { get; set; }
        public string Body_part { get; set; }
        public string Cause_code { get; set; }
        public string Treatment_description { get; set; }
        public string Chemicals_released { get; set; }
        public string Amount_released { get; set; }
        public string Media_affected { get; set; }
        public Nullable<int> Migrate_offsite { get; set; }
        public string Spill_location { get; set; }
        public string Cleanup_methods { get; set; }
        public string Environmental_impact { get; set; }
        public string Incident_description { get; set; }
        public string Witnesses { get; set; }
        public string Root_cause { get; set; }
        public string Contributing_cause { get; set; }
        public string OutsideMedAtt { get; set; }
        public string Recordable { get; set; }
        public string LTA { get; set; }
        public string Restricted_duty { get; set; }
        public Nullable<int> NumberOfDays { get; set; }
        public string equipment_class { get; set; }
    }
}
