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
using Employment_Services_System.Models;

namespace Employment_Services_System.Controllers
{
    public class user_accountController : ApiController
    {
        private EmploymentDataContext db = new EmploymentDataContext();

        // GET: api/user_account
        public IQueryable<UserAccountDTO> Getuser_account()
        {
            var UserAccounts = from u in db.user_account
                               select new UserAccountDTO()
                               {
                                   Id = u.id,
                                   Email = u.email,
                                   ContactNumber = u.contact_number,
                                   UserType = u.user_type.user_type_name
                               };
            return UserAccounts;
        }

        // GET: api/user_account/5
        [ResponseType(typeof(user_account))]
        public async Task<IHttpActionResult> Getuser_account(int id)
        {
            user_account user_account = await db.user_account.FindAsync(id);
            if (user_account == null)
            {
                return NotFound();
            }

            return Ok(user_account);
        }

        // PUT: api/user_account/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putuser_account(int id, user_account user_account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user_account.id)
            {
                return BadRequest();
            }

            db.Entry(user_account).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!user_accountExists(id))
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

        // POST: api/user_account
        [ResponseType(typeof(user_account))]
        public async Task<IHttpActionResult> Postuser_account(user_account user_account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.user_account.Add(user_account);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (user_accountExists(user_account.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = user_account.id }, user_account);
        }

        // DELETE: api/user_account/5
        [ResponseType(typeof(user_account))]
        public async Task<IHttpActionResult> Deleteuser_account(int id)
        {
            user_account user_account = await db.user_account.FindAsync(id);
            if (user_account == null)
            {
                return NotFound();
            }

            db.user_account.Remove(user_account);
            await db.SaveChangesAsync();

            return Ok(user_account);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool user_accountExists(int id)
        {
            return db.user_account.Count(e => e.id == id) > 0;
        }
    }
}