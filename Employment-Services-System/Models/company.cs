using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class company
    {
        public company()
        {
            this.company_image = new List<company_image>();
            this.job_post = new List<job_post>();
        }

        public int id { get; set; }
        public string company_name { get; set; }
        public string profile_description { get; set; }
        public int business_stream_id { get; set; }
        public System.DateTime establishment_date { get; set; }
        public string company_website_url { get; set; }
        public virtual business_stream business_stream { get; set; }
        public virtual ICollection<company_image> company_image { get; set; }
        public virtual ICollection<job_post> job_post { get; set; }
    }
}
