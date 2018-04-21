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
    public class opstineController : ApiController
    {
        private ZadrugaEntities db = new ZadrugaEntities();

        // GET: api/opstines
        //public IQueryable<sfOpstine> Getopstine()
        //{
        //    return db.sfOpstine.Include(d=>d.Drzava).AsQueryable();
        //}
        [ResponseType(typeof(ReturnData))]
        public async Task<IHttpActionResult> Getopstine()
        {

            var result = await db.sfOpstine.Include(d => d.Drzava).ToArrayAsync();
            return Json(content: new ReturnData { success = true, message = "Successfully", data = result });
            //return db.sfMesta.Include(d => d.Opstina).Include(d => d.Opstina.Drzava).AsEnumerable();
        }

        // GET: api/opstine/5
        [ResponseType(typeof(sfOpstine))]
        public async Task<IHttpActionResult> Getopstine(int id)
        {
            sfOpstine sfOpstine = await db.sfOpstine.FindAsync(id);
            if (sfOpstine == null)
            {
                return NotFound();
            }

            return Ok(sfOpstine);
        }

        // PUT: api/opstine/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putopstine(int id, sfOpstine sfOpstine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sfOpstine.OpstineID)
            {
                return BadRequest();
            }

            db.Entry(sfOpstine).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sfOpstineExists(id))
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

        // POST: api/opstine
        [ResponseType(typeof(sfOpstine))]
        public async Task<IHttpActionResult> Postopstine(sfOpstine sfOpstine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sfOpstine.Add(sfOpstine);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sfOpstine.OpstineID }, sfOpstine);
        }

        // DELETE: api/opstine/5
        [ResponseType(typeof(sfOpstine))]
        public async Task<IHttpActionResult> Deleteopstine(int id)
        {
            sfOpstine sfOpstine = await db.sfOpstine.FindAsync(id);
            if (sfOpstine == null)
            {
                return NotFound();
            }

            db.sfOpstine.Remove(sfOpstine);
            await db.SaveChangesAsync();

            return Ok(sfOpstine);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sfOpstineExists(int id)
        {
            return db.sfOpstine.Count(e => e.OpstineID == id) > 0;
        }
    }
}