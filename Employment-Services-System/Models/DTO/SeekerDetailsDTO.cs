using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employment_Services_System.Models
{
    public class SeekerDetailsDTO
    {
        public int Id { get; set; }
        public class PersonalInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        public class ExperienceDetail
        {
            public Nullable<int> CurrentSalary { get; set; }
            public string Currency { get; set; }
            public string SkillSetName { get; set; }
            public int SkillLevel { get; set; }
            public string JobTitle { get; set; }
            public string CompanyName { get; set; }
            public string JobLocationCity { get; set; }
            public string JobLocationState { get; set; }
            public string JobLocationCountry { get; set; }
            public string Description { get; set; }
            public bool IsCurrentJob { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }
        public class EducationDetail
        {
            public string CertificateDegreeName { get; set; }
            public string Major { get; set; }
            public string InstituteUniversityName { get; set; }
            public DateTime StartingDate { get; set; }
            public Nullable<DateTime> CompletionDate { get; set; }
            public Nullable<int> Percentage { get; set; }
            public Nullable<int> Cgpa { get; set; }
        }
        public PersonalInfo _PersonalInfo { get; set; }
        public ExperienceDetail _ExperienceDetail { get; set; }
        public EducationDetail _EducationDetail { get; set; }
    }
}