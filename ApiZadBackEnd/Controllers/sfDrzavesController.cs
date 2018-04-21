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
using System.Web.Http.Cors;
using System.Web.Http.Description;
using ApiZadBackEnd.Models;

namespace ApiZadBackEnd.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class drzaveController : ApiController
    {
        private ZadrugaEntities db = new ZadrugaEntities();

        // GET: api/drzave
        //public IQueryable<sfDrzave> GetsfDrzave()
        //{
        //    return db.sfDrzave;
        //}

        [ResponseType(typeof(ReturnData))]
        public async Task<IHttpActionResult> Getdrzave()
        {

            var result = await db.sfDrzave.ToArrayAsync();
            return Json(content: new ReturnData { success = true, message = "Successfully", data = result });
            
        }


        // GET: api/drzave/5
        [ResponseType(typeof(sfDrzave))]
        public async Task<IHttpActionResult> Getdrzave(int id)
        {
            sfDrzave sfDrzave = await db.sfDrzave.FindAsync(id);
            if (sfDrzave == null)
            {
                return NotFound();
            }

            return Ok(sfDrzave);
        }

        // PUT: api/drzave/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putdrzave(int id, sfDrzave sfDrzave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sfDrzave.DrzaveID)
            {
                return BadRequest();
            }

            db.Entry(sfDrzave).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sfDrzaveExists(id))
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

        // POST: api/drzave
        [ResponseType(typeof(sfDrzave))]
        public async Task<IHttpActionResult> Postdrzave(sfDrzave sfDrzave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sfDrzave.Add(sfDrzave);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sfDrzave.DrzaveID }, sfDrzave);
        }

        // DELETE: api/drzave/5
        [ResponseType(typeof(sfDrzave))]
        public async Task<IHttpActionResult> Deletedrzave(int id)
        {
            sfDrzave sfDrzave = await db.sfDrzave.FindAsync(id);
            if (sfDrzave == null)
            {
                return NotFound();
            }

            db.sfDrzave.Remove(sfDrzave);
            await db.SaveChangesAsync();

            return Ok(sfDrzave);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sfDrzaveExists(int id)
        {
            return db.sfDrzave.Count(e => e.DrzaveID == id) > 0;
        }
    }
}