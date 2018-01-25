using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class skill_set
    {
        public skill_set()
        {
            this.job_post_skill_set = new List<job_post_skill_set>();
            this.seeker_skill_set = new List<seeker_skill_set>();
        }

        public int id { get; set; }
        public string skill_set_name { get; set; }
        public virtual ICollection<job_post_skill_set> job_post_skill_set { get; set; }
        public virtual ICollection<seeker_skill_set> seeker_skill_set { get; set; }
    }
}
