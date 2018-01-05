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
using Employment_Services_System;

namespace Employment_Services_System.Controllers
{
    public class job_postController : ApiController
    {
        private EmploymentDataContext db = new EmploymentDataContext();

        // GET: api/job_post
        public IQueryable<job_post> Getjob_post()
        {
            return db.job_post;
        }

        // GET: api/job_post/5
        [ResponseType(typeof(job_post))]
        public async Task<IHttpActionResult> Getjob_post(int id)
        {
            job_post job_post = await db.job_post.FindAsync(id);
            if (job_post == null)
            {
                return NotFound();
            }

            return Ok(job_post);
        }

        // PUT: api/job_post/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putjob_post(int id, job_post job_post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != job_post.id)
            {
                return BadRequest();
            }

            db.Entry(job_post).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!job_postExists(id))
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

        // POST: api/job_post
        [ResponseType(typeof(job_post))]
        public async Task<IHttpActionResult> Postjob_post(job_post job_post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.job_post.Add(job_post);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (job_postExists(job_post.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = job_post.id }, job_post);
        }

        // DELETE: api/job_post/5
        [ResponseType(typeof(job_post))]
        public async Task<IHttpActionResult> Deletejob_post(int id)
        {
            job_post job_post = await db.job_post.FindAsync(id);
            if (job_post == null)
            {
                return NotFound();
            }

            db.job_post.Remove(job_post);
            await db.SaveChangesAsync();

            return Ok(job_post);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool job_postExists(int id)
        {
            return db.job_post.Count(e => e.id == id) > 0;
        }
    }
}