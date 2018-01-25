using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class job_post_skill_set
    {
        public int skill_set_id { get; set; }
        public int job_post_id { get; set; }
        public int skill_level { get; set; }
        public virtual job_post job_post { get; set; }
        public virtual skill_set skill_set { get; set; }
    }
}
