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
    public class mestaController : ApiController
    {
        private ZadrugaEntities db = new ZadrugaEntities();

        // GET: api/sfMestas
        //public IEnumerable<sfMesta> Getmesta()
        //{
        //    return db.sfMesta.Include(d=>d.Opstina).Include(d=>d.Opstina.Drzava).AsEnumerable();
        //}
        [ResponseType(typeof(ReturnData))]
        public async Task<IHttpActionResult> Getmesta()
        {

            var result = await db.sfMesta.Include(d => d.Opstina).Include(d => d.Opstina.Drzava).ToArrayAsync(); 
            return Json(content: new ReturnData { success = true, message= "Successfully", data=result});
            //return db.sfMesta.Include(d => d.Opstina).Include(d => d.Opstina.Drzava).AsEnumerable();
        }

        // GET: api/sfMestas/5
        [ResponseType(typeof(sfMesta))]
        public async Task<IHttpActionResult> Getmesta(int id)
        {
            sfMesta sfMesta = await db.sfMesta.FindAsync(id);
            if (sfMesta == null)
            {
                return NotFound();
            }

            return Ok(sfMesta);
        }

        // PUT: api/sfMestas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putmesta(int id, sfMesta sfMesta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sfMesta.MestaID)
            {
                return BadRequest();
            }

            db.Entry(sfMesta).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sfMestaExists(id))
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

        // POST: api/sfMestas
        [ResponseType(typeof(sfMesta))]
        public async Task<IHttpActionResult> Postmesta(sfMesta sfMesta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sfMesta.Add(sfMesta);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sfMesta.MestaID }, sfMesta);
        }

        // DELETE: api/sfMestas/5
        [ResponseType(typeof(sfMesta))]
        public async Task<IHttpActionResult> Deletemesta(int id)
        {
            sfMesta sfMesta = await db.sfMesta.FindAsync(id);
            if (sfMesta == null)
            {
                return NotFound();
            }

            db.sfMesta.Remove(sfMesta);
            await db.SaveChangesAsync();

            return Ok(sfMesta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sfMestaExists(int id)
        {
            return db.sfMesta.Count(e => e.MestaID == id) > 0;
        }
    }
}