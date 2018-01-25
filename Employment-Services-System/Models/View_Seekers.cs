using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class View_Seekers
    {
        public int id { get; set; }
        public string is_company_name_hidden { get; set; }
        public System.DateTime created_date { get; set; }
        public string job_description { get; set; }
        public string is_active { get; set; }
        public int skill_level { get; set; }
        public string job_type { get; set; }
        public string email { get; set; }
        public byte[] user_image { get; set; }
        public System.DateTime registration_date { get; set; }
        public string company_name { get; set; }
        public string street_address { get; set; }
    }
}
