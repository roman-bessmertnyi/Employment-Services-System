using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class education_detail
    {
        public int user_account_id { get; set; }
        public string certificate_degree_name { get; set; }
        public string major { get; set; }
        public string institute_university_name { get; set; }
        public System.DateTime starting_date { get; set; }
        public Nullable<System.DateTime> completion_date { get; set; }
        public Nullable<int> percentage { get; set; }
        public Nullable<int> cgpa { get; set; }
        public virtual seeker_profile seeker_profile { get; set; }
    }
}
