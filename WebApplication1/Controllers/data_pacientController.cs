using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using WebApplication1.Models; 
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1; 

namespace WebApplication1.Controllers
{
    public class data_pacientController : ApiController
    {
        private labEntities db = new labEntities();

        // GET: api/data_pacient
        [ResponseType(typeof(List<Pacient>))]

        public IHttpActionResult Getdata_pacient()
        {
            return Ok(db.data_pacient.ToList().ConvertAll(p => new Pacient(p)));
        }

        // GET: api/data_pacient/5
        [ResponseType(typeof(data_pacient))]
        public IHttpActionResult Getdata_pacient(int id)
        {
            data_pacient data_pacient = db.data_pacient.Find(id);
            if (data_pacient == null)
            {
                return NotFound();
            }

            return Ok(data_pacient);
        }

        // PUT: api/data_pacient/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putdata_pacient(int id, data_pacient data_pacient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != data_pacient.id)
            {
                return BadRequest();
            }

            db.Entry(data_pacient).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!data_pacientExists(id))
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

        // POST: api/data_pacient
        [ResponseType(typeof(data_pacient))]
        public IHttpActionResult Postdata_pacient(data_pacient data_pacient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.data_pacient.Add(data_pacient);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = data_pacient.id }, data_pacient);
        }

        // DELETE: api/data_pacient/5
        [ResponseType(typeof(data_pacient))]
        public IHttpActionResult Deletedata_pacient(int id)
        {
            data_pacient data_pacient = db.data_pacient.Find(id);
            if (data_pacient == null)
            {
                return NotFound();
            }

            db.data_pacient.Remove(data_pacient);
            db.SaveChanges();

            return Ok(data_pacient);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool data_pacientExists(int id)
        {
            return db.data_pacient.Count(e => e.id == id) > 0;
        }
    }
}