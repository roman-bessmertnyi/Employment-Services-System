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
using Employment_Services_System.Models;

namespace Employment_Services_System.Controllers
{
    public class seeker_profileController : ApiController
    {
        private EmploymentDataContext db = new EmploymentDataContext();

        // GET: api/seeker_profile
        public IQueryable<SeekerDTO> Getseeker_profile()
        {
            var Seekers = from s in db.seeker_profile
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

        // GET: api/seeker_profile/5
        [ResponseType(typeof(SeekerDetailsDTO))]
        public async Task<IHttpActionResult> Getseeker_profile(int id)
        {
            SeekerDetailsDTO Seeker = await db.seeker_profile.Select(s =>
                new SeekerDetailsDTO()
                {
                    Id = s.user_account_id,
                    _PersonalInfo = new SeekerDetailsDTO.PersonalInfo
                    {
                        FirstName = s.first_name,
                        LastName = s.last_name
                    },
                    _ExperienceDetail = new SeekerDetailsDTO.ExperienceDetail
                    {
                        CurrentSalary = s.current_salary,
                        Currency = s.currency,
                        SkillSetName = s.seeker_skill_set.FirstOrDefault
                            (skill => skill.user_account_id == s.user_account_id)
                            .skill_set.skill_set_name,
                        SkillLevel = s.seeker_skill_set.FirstOrDefault
                            (skill => skill.user_account_id == s.user_account_id)
                            .skill_level,
                        JobTitle = s.experience_detail.FirstOrDefault
                            (exp => exp.user_account_id == s.user_account_id)
                            .job_title,
                        CompanyName = s.experience_detail.FirstOrDefault
                            (exp => exp.user_account_id == s.user_account_id)
                            .company_name,
                        JobLocationCity = s.experience_detail.FirstOrDefault
                            (exp => exp.user_account_id == s.user_account_id)
                            .job_location_city,
                        JobLocationState = s.experience_detail.FirstOrDefault
                            (exp => exp.user_account_id == s.user_account_id)
                            .job_location_state,
                        JobLocationCountry = s.experience_detail.FirstOrDefault
                            (exp => exp.user_account_id == s.user_account_id)
                            .job_location_country,
                        Description = s.experience_detail.FirstOrDefault
                            (exp => exp.user_account_id == s.user_account_id)
                            .description,
                        IsCurrentJob = s.experience_detail.FirstOrDefault
                            (exp => exp.user_account_id == s.user_account_id)
                            .is_current_job == "1" ? true : false,
                        StartDate = s.experience_detail.FirstOrDefault
                            (exp => exp.user_account_id == s.user_account_id)
                            .start_date,
                        EndDate = s.experience_detail.FirstOrDefault
                            (exp => exp.user_account_id == s.user_account_id)
                            .end_date,
                    },
                    _EducationDetail = new SeekerDetailsDTO.EducationDetail
                    {
                        CertificateDegreeName = s.education_detail.FirstOrDefault
                            (edu => edu.user_account_id == s.user_account_id)
                            .certificate_degree_name,
                        Major = s.education_detail.FirstOrDefault
                            (edu => edu.user_account_id == s.user_account_id)
                            .certificate_degree_name,
                        InstituteUniversityName = s.education_detail.FirstOrDefault
                            (edu => edu.user_account_id == s.user_account_id)
                            .Institute_university_name,
                        StartingDate = s.education_detail.FirstOrDefault
                            (edu => edu.user_account_id == s.user_account_id)
                            .starting_date,
                        CompletionDate = s.education_detail.FirstOrDefault
                            (edu => edu.user_account_id == s.user_account_id)
                            .completion_date,
                        Percentage = s.education_detail.FirstOrDefault
                            (edu => edu.user_account_id == s.user_account_id)
                            .percentage,
                        Cgpa = s.education_detail.FirstOrDefault
                            (edu => edu.user_account_id == s.user_account_id)
                            .cgpa,
                    }
                }).SingleOrDefaultAsync(s => s.Id == id);
            if (Seeker == null)
            {
                return NotFound();
            }

            return Ok(Seeker);
        }

        // PUT: api/seeker_profile/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putseeker_profile(int id, seeker_profile seeker_profile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != seeker_profile.user_account_id)
            {
                return BadRequest();
            }

            db.Entry(seeker_profile).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!seeker_profileExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/seeker_profile
        [ResponseType(typeof(seeker_profile))]
        public async Task<IHttpActionResult> Postseeker_profile(seeker_profile seeker_profile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.seeker_profile.Add(seeker_profile);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (seeker_profileExists(seeker_profile.user_account_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = seeker_profile.user_account_id }, seeker_profile);
        }

        // DELETE: api/seeker_profile/5
        [ResponseType(typeof(seeker_profile))]
        public async Task<IHttpActionResult> Deleteseeker_profile(int id)
        {
            seeker_profile seeker_profile = await db.seeker_profile.FindAsync(id);
            if (seeker_profile == null)
            {
                return NotFound();
            }

            db.seeker_profile.Remove(seeker_profile);
            await db.SaveChangesAsync();

            return Ok(seeker_profile);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool seeker_profileExists(int id)
        {
            return db.seeker_profile.Count(e => e.user_account_id == id) > 0;
        }
    }
}