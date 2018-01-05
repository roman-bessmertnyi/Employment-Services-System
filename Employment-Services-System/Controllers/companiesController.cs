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
    public class companiesController : ApiController
    {
        private EmploymentDataContext db = new EmploymentDataContext();

        // GET: api/companies
        public IQueryable<company> Getcompany()
        {
            return db.company;
        }

        // GET: api/companies/5
        [ResponseType(typeof(company))]
        public async Task<IHttpActionResult> Getcompany(int id)
        {
            company company = await db.company.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        // PUT: api/companies/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putcompany(int id, company company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != company.id)
            {
                return BadRequest();
            }

            db.Entry(company).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!companyExists(id))
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

        // POST: api/companies
        [ResponseType(typeof(company))]
        public async Task<IHttpActionResult> Postcompany(company company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.company.Add(company);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (companyExists(company.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = company.id }, company);
        }

        // DELETE: api/companies/5
        [ResponseType(typeof(company))]
        public async Task<IHttpActionResult> Deletecompany(int id)
        {
            company company = await db.company.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            db.company.Remove(company);
            await db.SaveChangesAsync();

            return Ok(company);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool companyExists(int id)
        {
            return db.company.Count(e => e.id == id) > 0;
        }
    }
}