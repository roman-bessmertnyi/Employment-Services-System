using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class experience_detail
    {
        public int user_account_id { get; set; }
        public string is_current_job { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime end_date { get; set; }
        public string job_title { get; set; }
        public string company_name { get; set; }
        public string job_location_city { get; set; }
        public string job_location_state { get; set; }
        public string job_location_country { get; set; }
        public string description { get; set; }
        public virtual seeker_profile seeker_profile { get; set; }
    }
}
