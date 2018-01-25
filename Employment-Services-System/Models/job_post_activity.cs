using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class job_post_activity
    {
        public int user_account_id { get; set; }
        public int job_post_id { get; set; }
        public System.DateTime apply_date { get; set; }
        public virtual job_post job_post { get; set; }
        public virtual user_account user_account { get; set; }
    }
}
