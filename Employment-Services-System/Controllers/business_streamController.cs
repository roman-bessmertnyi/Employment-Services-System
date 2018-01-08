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
    public class business_streamController : ApiController
    {
        private EmploymentDataContext db = new EmploymentDataContext();

        // GET: api/business_stream
        public IQueryable<business_stream> Getbusiness_stream()
        {
            return db.business_stream;
        }

        // GET: api/business_stream/5
        [ResponseType(typeof(business_stream))]
        public async Task<IHttpActionResult> Getbusiness_stream(int id)
        {
            business_stream business_stream = await db.business_stream.FindAsync(id);
            if (business_stream == null)
            {
                return NotFound();
            }

            return Ok(business_stream);
        }

        // PUT: api/business_stream/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putbusiness_stream(int id, business_stream business_stream)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != business_stream.id)
            {
                return BadRequest();
            }

            db.Entry(business_stream).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!business_streamExists(id))
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

        // POST: api/business_stream
        [ResponseType(typeof(business_stream))]
        public async Task<IHttpActionResult> Postbusiness_stream(business_stream business_stream)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.business_stream.Add(business_stream);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (business_streamExists(business_stream.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = business_stream.id }, business_stream);
        }

        // DELETE: api/business_stream/5
        [ResponseType(typeof(business_stream))]
        public async Task<IHttpActionResult> Deletebusiness_stream(int id)
        {
            business_stream business_stream = await db.business_stream.FindAsync(id);
            if (business_stream == null)
            {
                return NotFound();
            }

            db.business_stream.Remove(business_stream);
            await db.SaveChangesAsync();

            return Ok(business_stream);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool business_streamExists(int id)
        {
            return db.business_stream.Count(e => e.id == id) > 0;
        }
    }
}