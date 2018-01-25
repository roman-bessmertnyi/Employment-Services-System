using Employment_Services_System.Models;
using Employment_Services_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.SqlClient;

namespace Employment_Services_System.Controllers
{
    public class SeekerSearchController : ApiController
    {
        private EmploymentServicesDatabaseContext db = new EmploymentServicesDatabaseContext();

        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.HttpGet]
        [Route("api/SeekerSearch/Simple")]
        public IQueryable<SeekerDTO> SeekerSearchSimple(
            string keyword = "",
            string location = "")
        {
            var Seekers = from s in db.seeker_profile
                          where (
                            (
                                db.seeker_skill_set.Any(skill =>
                                    (skill.user_account_id == s.user_account_id)
                                    &&
                                    (skill.skill_set.skill_set_name.Contains(keyword)))
                                ||
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.job_title.Contains(keyword)))
                                ||
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.company_name.Contains(keyword)))
                                ||
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.description.Contains(keyword)))
                                ||
                                db.education_detail.Any(edu =>
                                    (edu.user_account_id == s.user_account_id)
                                    &&
                                    (edu.certificate_degree_name.Contains(keyword)))
                                ||
                                db.education_detail.Any(edu =>
                                    (edu.user_account_id == s.user_account_id)
                                    &&
                                    (edu.major.Contains(keyword)))
                                ||
                                db.education_detail.Any(edu =>
                                    (edu.user_account_id == s.user_account_id)
                                    &&
                                    (edu.institute_university_name.Contains(keyword)))
                            )
                            &&
                            (
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.job_location_city.Contains(location)))
                                ||
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.job_location_country.Contains(location)))
                                ||
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.job_location_state.Contains(location)))
                            )
                          )
                          select new SeekerDTO()
                          {
                              Id = s.user_account_id,
                              FirstName = s.first_name,
                              LastName = s.last_name,
                              SkillSetName = db.seeker_skill_set.FirstOrDefault(skill =>
                                    skill.user_account_id == s.user_account_id)
                                    .skill_set.skill_set_name,
                              SkillLevel = db.seeker_skill_set.FirstOrDefault(skill =>
                                    skill.user_account_id == s.user_account_id)
                                    .skill_level,
                              Degree = db.education_detail.FirstOrDefault(edu =>
                                    edu.user_account_id == s.user_account_id)
                                    .certificate_degree_name
                          };

            return Seekers;
        }


        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.HttpGet]
        [Route("api/SeekerSearch/Advanced")]
        public IQueryable<SeekerDTO> SeekerSearchAdvanced(
            string keyword = "",
            string location = "",
            string skillSet = "",
            int xpYears = 0,
            string eduQualification = "",
            int YearOfPassingMin = 0,
            int YearOfPassingMax = 0
            )
        {
            var Seekers = from s in db.seeker_profile
                          where (
                            (
                                db.seeker_skill_set.Any(skill =>
                                    (skill.user_account_id == s.user_account_id)
                                    &&
                                    (skill.skill_set.skill_set_name.Contains(keyword)))
                                ||
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.job_title.Contains(keyword)))
                                ||
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.company_name.Contains(keyword)))
                                ||
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.description.Contains(keyword)))
                                ||
                                db.education_detail.Any(edu =>
                                    (edu.user_account_id == s.user_account_id)
                                    &&
                                    (edu.certificate_degree_name.Contains(keyword)))
                                ||
                                db.education_detail.Any(edu =>
                                    (edu.user_account_id == s.user_account_id)
                                    &&
                                    (edu.major.Contains(keyword)))
                                ||
                                db.education_detail.Any(edu =>
                                    (edu.user_account_id == s.user_account_id)
                                    &&
                                    (edu.institute_university_name.Contains(keyword)))
                            )
                            &&
                            (
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.job_location_city.Contains(location)))
                                ||
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.job_location_country.Contains(location)))
                                ||
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (exp.job_location_state.Contains(location)))
                            )
                            &&
                            (
                                db.seeker_skill_set.Any(skill =>
                                    (skill.user_account_id == s.user_account_id)
                                    &&
                                    (skill.skill_set.skill_set_name == skillSet))
                                || skillSet == ""
                            )
                            &&
                            (
                                db.experience_detail.Any(exp =>
                                    (exp.user_account_id == s.user_account_id)
                                    &&
                                    (DbFunctions.DiffYears(exp.end_date, exp.start_date)  > xpYears))
                                || xpYears == 0
                            )
                            &&
                            (
                                db.education_detail.Any(edu =>
                                    (edu.user_account_id == s.user_account_id)
                                    &&
                                    (edu.certificate_degree_name.Contains(eduQualification)))
                                ||
                                db.education_detail.Any(edu =>
                                    (edu.user_account_id == s.user_account_id)
                                    &&
                                    (edu.major.Contains(eduQualification)))
                                || eduQualification == ""
                            )
                            &&
                            (
                                db.education_detail.Any(edu =>
                                    (edu.user_account_id == s.user_account_id)
                                    &&
                                    (edu.completion_date.Value.Year < YearOfPassingMax))
                                || YearOfPassingMax == 0
                            )
                            &&
                            (
                                db.education_detail.Any(edu =>
                                    (edu.user_account_id == s.user_account_id)
                                    &&
                                    (edu.completion_date.Value.Year > YearOfPassingMin))
                                || YearOfPassingMin == 0
                            )
                          )
                          select new SeekerDTO()
                          {
                              Id = s.user_account_id,
                              FirstName = s.first_name,
                              LastName = s.last_name,
                              SkillSetName = db.seeker_skill_set.FirstOrDefault(skill =>
                                    skill.user_account_id == s.user_account_id)
                                    .skill_set.skill_set_name,
                              SkillLevel = db.seeker_skill_set.FirstOrDefault(skill =>
                                    skill.user_account_id == s.user_account_id)
                                    .skill_level,
                              Degree = db.education_detail.FirstOrDefault(edu =>
                                    edu.user_account_id == s.user_account_id)
                                    .certificate_degree_name
                          };

            return Seekers;
        }
    }
}
