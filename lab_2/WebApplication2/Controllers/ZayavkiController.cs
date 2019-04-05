using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ZayavkiController : ApiController
    {

        // GET: api/Zayavki
        lab_2Entities2 lab_2 = new lab_2Entities2();
        Response response = new Response();
        // GET api/values
        public Response Get()
        {

            response.url = Request.RequestUri.ToString();
            response.response = lab_2.Zayavki.ToList();
            response.method = "GET";
            return response;
            
        }



        // GET api/values/5
        public Zayavki Get(int id)
        {
            return lab_2.Zayavki.FirstOrDefault(e => e.Id_zakazi == id);
        }

        // POST api/values
        [HttpPost]
        public Zayavki Post([FromBody]Zayavki value)
        {
            lab_2.Zayavki.Add(value);
            lab_2.SaveChanges();
            return value;
        }
        [HttpPut]
        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]Zayavki value)
        {
            var entity = lab_2.Zayavki.FirstOrDefault(e => e.Id_zakazi== id);
            if (entity == null)
            {
                return Ok(value);
            }
            else
            {
                entity.Id_service = value.Id_service;
                entity.Id_clienta = value.Id_clienta;
                lab_2.SaveChanges();
                return Ok(value);
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

            Zayavki zayavki = lab_2.Zayavki.Find(id);
            if (zayavki != null)
            {
                lab_2.Zayavki.Remove(zayavki);
                lab_2.SaveChanges();
            }
        }
    }
}
