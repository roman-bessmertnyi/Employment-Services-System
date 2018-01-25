using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employment_Services_System.Models
{
    public class JobPostDetailsDTO
    {
        public int Id { get; set; }
        public string PostedBy { get; set; }
        public string JobType { get; set; }
        public string Company { get; set; }
        public string IsCompanyNameHidden { get; set; }
        public DateTime CreatedDate { get; set; }
        public string JobDescription { get; set; }
        public string JobLocationStreet { get; set; }
        public string is_active { get; set; }
    }
}