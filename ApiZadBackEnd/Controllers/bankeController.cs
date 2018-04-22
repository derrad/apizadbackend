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
using ApiZadBackEnd.Models;

namespace ApiZadBackEnd.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class bankeController : ApiController
    {
        private ZadrugaEntities db = new ZadrugaEntities();

        // GET: api/banke
        [ResponseType(typeof(ReturnData))]
        public async Task<IHttpActionResult> Getbanke()
        {
            var result = await db.sfBanke.ToArrayAsync();
            return Json(content: new ReturnData { success = true, message = "Successfully", data = result });
           // return db.sfBanke;
        }

        // GET: api/banke/5
        [ResponseType(typeof(sfBanke))]
        public async Task<IHttpActionResult> Getbanke(int id)
        {
            sfBanke sfBanke = await db.sfBanke.FindAsync(id);
            if (sfBanke == null)
            {
                return NotFound();
            }

            return Ok(sfBanke);
        }

        // PUT: api/banke/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putbanke(int id, sfBanke sfBanke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sfBanke.BankeID)
            {
                return BadRequest();
            }

            db.Entry(sfBanke).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sfBankeExists(id))
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

        // POST: api/banke
        [ResponseType(typeof(sfBanke))]
        public async Task<IHttpActionResult> Postbanke(sfBanke sfBanke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sfBanke.Add(sfBanke);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sfBanke.BankeID }, sfBanke);
        }

        // DELETE: api/banke/5
        [ResponseType(typeof(sfBanke))]
        public async Task<IHttpActionResult> Deletebanke(int id)
        {
            sfBanke sfBanke = await db.sfBanke.FindAsync(id);
            if (sfBanke == null)
            {
                return NotFound();
            }

            db.sfBanke.Remove(sfBanke);
            await db.SaveChangesAsync();

            return Ok(sfBanke);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sfBankeExists(int id)
        {
            return db.sfBanke.Count(e => e.BankeID == id) > 0;
        }
    }
}