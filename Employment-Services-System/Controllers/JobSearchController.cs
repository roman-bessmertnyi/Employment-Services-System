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
    public class JobSearchController : ApiController
    {
        private EmploymentDataContext db = new EmploymentDataContext();

        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.HttpGet]
        [Route("api/JobSearch/Simple")]
        public IQueryable<JobPostDTO> JobSearchSimple(
            string keyword="",
            string location="")
        {
            var JobPosts = from j in db.job_post
                           .Where(job_post =>
                               (
                                   job_post.job_type.job_type1.Contains(keyword) ||
                                   job_post.company.company_name.Contains(keyword) ||
                                   job_post.job_description.Contains(keyword)
                               )
                               &&
                               (
                                   job_post.job_location.street_address.Contains(location) ||
                                   job_post.job_location.state.Contains(location) ||
                                   job_post.job_location.city.Contains(location)
                               )
                           )
                           select new JobPostDTO()
                           {
                               Id = j.id,
                               JobType = j.job_type.job_type1,
                               Company = j.company.company_name,
                               JobDescription = j.job_description,
                               JobLocationStreet = j.job_location.street_address,
                           };
            return JobPosts;
        }

        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.HttpGet]
        [Route("api/JobSearch/Advanced")]
        public IQueryable<JobPostDTO> JobSearchAdvanced(
            string keyword = "",
            string location = "",
            string category = "",
            int freshnessDays = 0,
            string industry = "",
            int freshnessPriority = 0,
            int expPriority = 0)
        {
            DateTime MinCreationDate = DateTime.Now.AddDays(-freshnessDays);
            bool freshnessFirst = (freshnessPriority > expPriority);
            var JobPosts = from j in db.job_post
                           .Where(job_post =>
                               (
                                   job_post.job_type.job_type1.Contains(keyword) ||
                                   job_post.company.company_name.Contains(keyword) ||
                                   job_post.job_description.Contains(keyword)
                               )
                               &&
                               (
                                   job_post.job_location.street_address.Contains(location) ||
                                   job_post.job_location.state.Contains(location) ||
                                   job_post.job_location.city.Contains(location)
                               )
                               &&
                               (
                                    category != "" ? job_post.job_type.job_type1 == category : true
                               )
                               &&
                               (
                                    freshnessDays != 0 ? job_post.created_date < MinCreationDate : true
                               )
                               &&
                               (
                                    industry != "" ? job_post.company.business_stream.business_stream_name == industry : true

                               )
                           )
                           .OrderBy(job_post =>
                               (freshnessPriority > expPriority)
                               ?
                               job_post.created_date
                               :
                               DateTime.MinValue
                           )
                           .OrderBy(job_post =>
                               (freshnessPriority <= expPriority)
                               ?
                               0
                               :
                               db.job_post_skill_set.FirstOrDefault(skill => skill.job_post_id == job_post.id).skill_level
                           )
                           select new JobPostDTO()
                           {
                               Id = j.id,
                               JobType = j.job_type.job_type1,
                               Company = j.company.company_name,
                               JobDescription = j.job_description,
                               JobLocationStreet = j.job_location.street_address,
                           };
            return JobPosts;
        }
    }
}
