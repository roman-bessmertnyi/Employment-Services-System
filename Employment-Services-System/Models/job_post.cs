using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class job_post
    {
        public job_post()
        {
            this.job_post_activity = new List<job_post_activity>();
            this.job_post_skill_set = new List<job_post_skill_set>();
        }

        public int id { get; set; }
        public int posted_by_id { get; set; }
        public int job_type_id { get; set; }
        public int company_id { get; set; }
        public string is_company_name_hidden { get; set; }
        public System.DateTime created_date { get; set; }
        public string job_description { get; set; }
        public int job_location_id { get; set; }
        public string is_active { get; set; }
        public virtual company company { get; set; }
        public virtual job_location job_location { get; set; }
        public virtual ICollection<job_post_activity> job_post_activity { get; set; }
        public virtual job_type job_type { get; set; }
        public virtual ICollection<job_post_skill_set> job_post_skill_set { get; set; }
        public virtual user_account user_account { get; set; }
    }
}
