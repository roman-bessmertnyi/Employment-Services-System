using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class job_location
    {
        public job_location()
        {
            this.job_post = new List<job_post>();
        }

        public int id { get; set; }
        public string street_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        public virtual ICollection<job_post> job_post { get; set; }
    }
}
