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
//System.Web.Http.Results

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
            try {

                var result = await db.sfOpstine.Include(d => d.Drzava).ToArrayAsync();
               // throw new Exception("Lokalna greska");
                // return Json(content: new ReturnData { success = true, message = "Successfully", data = result });
                return Ok(content: new ReturnData { success = true, message = "Successfully", data = result });

            } catch (Exception ex)
            {
              //  return BadRequest(new ReturnData { success = true, message = ex.Message, data = { } } );
                return  Content(HttpStatusCode.BadRequest, new ReturnData { success = false, message = ex.Message, data = null });
            }
        }

        // GET: api/opstine/5
        [ResponseType(typeof(ReturnData))]
        public async Task<IHttpActionResult> Getopstine(int id)
        {
            try { 
               sfOpstine sfOpstine = await db.sfOpstine.FindAsync(id);
            if (sfOpstine == null)
                {
                    // return NotFound();
                    return Content(HttpStatusCode.NotFound, new ReturnData { success = false, message = "Opština Not Found", data = { } });
                }

                // return Ok(sfOpstine);
                return Ok(content: new ReturnData { success = true, message = "Successfully", data = sfOpstine });
            } catch (Exception ex)
            {

                //  return BadRequest(new ReturnData { success = true, message = ex.Message, data = { } } );
                return  Content(HttpStatusCode.BadRequest, new ReturnData { success = false, message = ex.Message, data = null });
            }

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
        [ResponseType(typeof(ReturnData))]
        public async Task<IHttpActionResult> Postopstine(sfOpstine sfOpstine)
        {
            try { 
                string Error = "";
                if (!ModelState.IsValid)
                {
                    //return BadRequest(ModelState);
                    // Error = "Model is invalid ";

                    foreach (string item in ModelState.Values.SelectMany(e => e.Errors.Select(er => er.ErrorMessage))){
                        Error += item;
                    }
                        return Content(HttpStatusCode.BadRequest, new ReturnData { success = false, message = "Model is invalid. " + Error, data = { } });
                }
                if (!sfDrzaveExists(sfOpstine.DrzaveID))
                {
                    Error = "Države Not Found !!!";
                    return Content(HttpStatusCode.BadRequest, new ReturnData { success = false, message = "The request is invalid. " + Error, data = { } });
                }
                db.sfOpstine.Add(sfOpstine);
                await db.SaveChangesAsync();
                sfOpstine uspeh = await db.sfOpstine.Include(d => d.Drzava).SingleOrDefaultAsync(d=>d.OpstineID==sfOpstine.OpstineID);
                return CreatedAtRoute("DefaultApi", new { id = sfOpstine.OpstineID }, new ReturnData { success = true, message = "Successfully", data = uspeh });
        } catch (Exception ex)
            {

                //  return BadRequest(new ReturnData { success = true, message = ex.Message, data = { } } );
                return  Content(HttpStatusCode.BadRequest, new ReturnData { success = false, message = ex.Message, data = null });
            }

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

        private bool sfDrzaveExists(int id)
        {
            return db.sfDrzave.Count(e => e.DrzaveID == id) > 0;
        }
    }
}


//ApiController Method              Description
//BadRequest()                      Creates a BadRequestResult object with status code 400.
//Conflict()                        Creates a ConflictResult object with status code 409.
//Content()                         Creates a NegotiatedContentResult with the specified status code and data.
//Created()                         Creates a CreatedNegotiatedContentResult with status code 201 Created.
//CreatedAtRoute()                  Creates a CreatedAtRouteNegotiatedContentResult with status code 201 created.
//InternalServerError()             Creates an InternalServerErrorResult with status code 500 Internal server error.
//NotFound()                        Creates a NotFoundResult with status code404.
//Ok()                              Creates an OkResult with status code 200.
//Redirect()                        Creates a RedirectResult with status code 302.
//RedirectToRoute()                 Creates a RedirectToRouteResult with status code 302.
//ResponseMessage()                 Creates a ResponseMessageResult with the specified HttpResponseMessage.
//StatusCode()                      Creates a StatusCodeResult with the specified http status code.
//Unauthorized()                    Creates an UnauthorizedResult with status code 401.