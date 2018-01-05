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
    public class seeker_profileController : ApiController
    {
        private EmploymentDataContext db = new EmploymentDataContext();

        // GET: api/seeker_profile
        public IQueryable<seeker_profile> Getseeker_profile()
        {
            return db.seeker_profile;
        }

        // GET: api/seeker_profile/5
        [ResponseType(typeof(seeker_profile))]
        public async Task<IHttpActionResult> Getseeker_profile(int id)
        {
            seeker_profile seeker_profile = await db.seeker_profile.FindAsync(id);
            if (seeker_profile == null)
            {
                return NotFound();
            }

            return Ok(seeker_profile);
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