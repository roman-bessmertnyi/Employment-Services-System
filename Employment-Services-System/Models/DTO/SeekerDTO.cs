using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employment_Services_System.Models
{
    public class SeekerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SkillSetName { get; set; }
        public int SkillLevel { get; set; }
        public string Degree { get; set; }
    }
}