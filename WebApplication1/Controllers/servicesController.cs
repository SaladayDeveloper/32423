using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using WebApplication1.Models;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class servicesController : ApiController
    {
        private labEntities db = new labEntities();

        // GET: api/services
        [ResponseType(typeof(List<Services>))]
        public IHttpActionResult Getservice()
        {
            return Ok(db.service.ToList().ConvertAll(p => new Services(p)));
        }

        // GET: api/services/5
        [ResponseType(typeof(service))]
        public IHttpActionResult Getservice(int id)
        {
            service service = db.service.Find(id);
            if (service == null)
            {
                return NotFound();
            }

            return Ok(service);
        }

        // PUT: api/services/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putservice(int id, service service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != service.id)
            {
                return BadRequest();
            }

            db.Entry(service).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!serviceExists(id))
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

        // POST: api/services
        [ResponseType(typeof(service))]
        public IHttpActionResult Postservice(service service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.service.Add(service);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (serviceExists(service.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = service.id }, service);
        }

        // DELETE: api/services/5
        [ResponseType(typeof(service))]
        public IHttpActionResult Deleteservice(int id)
        {
            service service = db.service.Find(id);
            if (service == null)
            {
                return NotFound();
            }

            db.service.Remove(service);
            db.SaveChanges();

            return Ok(service);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool serviceExists(int id)
        {
            return db.service.Count(e => e.id == id) > 0;
        }
    }
}