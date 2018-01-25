using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class seeker_skill_set
    {
        public int user_account_id { get; set; }
        public int skill_set_id { get; set; }
        public int skill_level { get; set; }
        public virtual seeker_profile seeker_profile { get; set; }
        public virtual skill_set skill_set { get; set; }
    }
}
