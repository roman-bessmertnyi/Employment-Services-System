using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class View_1
    {
        public int id { get; set; }
        public string job_type { get; set; }
        public string company_name { get; set; }
        public string job_description { get; set; }
        public string street_address { get; set; }
        public Nullable<int> skill_level { get; set; }
        public string skill_set_name { get; set; }
    }
}
