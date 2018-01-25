using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employment_Services_System.Models
{
    public class JobPostDTO
    {
        public int Id { get; set; }
        public string JobType { get; set; }
        public string Company { get; set; }
        public string JobDescription { get; set; }
        public string JobLocationStreet { get; set; }
    }
}