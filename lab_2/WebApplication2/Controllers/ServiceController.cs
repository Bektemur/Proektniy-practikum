using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ServiceController : ApiController
    {
        lab_2Entities2 db = new lab_2Entities2();
        Response response = new Response();
        [HttpGet]
        public Response Get()
        {

            response.url = Request.RequestUri.ToString();
            response.response = db.Service.ToList();
            response.method = "GET";
            return response;
        }
         // GET api/values
      
        // GET api/values/5
        public Service Get(int id)
        {
            Service service = db.Service.Find(id);
            return db.Service.Find(id);
        }

        // POST api/values
        [HttpPost]
        public Service Post([FromBody] Service value)
        {
            
           
            db.Service.Add(value);
            response.url = Request.RequestUri.ToString();
            response.response ="Запись добавлено";
            response.method = "POST";
            db.SaveChanges();
            return value;
        }
        [HttpPut]
        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]Service value)
        {
            var entity = db.Service.FirstOrDefault(e => e.Id_service == id);
            if (entity == null)
            {
                return Ok(value);
            }
            else
            {
                entity.Name_service = value.Name_service;
               db.SaveChanges();
                return Ok(value);
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

            Service service = db.Service.Find(id);
            if (service != null)
            {
               db.Service.Remove(service);
                db.SaveChanges();
            }
        }
    }
}
