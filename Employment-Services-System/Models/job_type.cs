using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class job_type
    {
        public job_type()
        {
            this.job_post = new List<job_post>();
        }

        public int id { get; set; }
        public string job_type_name { get; set; }
        public virtual ICollection<job_post> job_post { get; set; }
    }
}
