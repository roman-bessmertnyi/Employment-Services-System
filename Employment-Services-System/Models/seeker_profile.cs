using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class seeker_profile
    {
        public seeker_profile()
        {
            this.education_detail = new List<education_detail>();
            this.experience_detail = new List<experience_detail>();
            this.seeker_skill_set = new List<seeker_skill_set>();
        }

        public int user_account_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<int> current_salary { get; set; }
        public string is_annually_monthly { get; set; }
        public string currency { get; set; }
        public virtual ICollection<education_detail> education_detail { get; set; }
        public virtual ICollection<experience_detail> experience_detail { get; set; }
        public virtual user_account user_account { get; set; }
        public virtual ICollection<seeker_skill_set> seeker_skill_set { get; set; }
    }
}
