using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class ClientController : ApiController
    {
        Response response =new Response();
        lab_2Entities2 lab_2 = new lab_2Entities2();
        // GET api/values
        [HttpGet]
        public Response Get()
        {

            response.url = Request.RequestUri.ToString();
            response.response = lab_2.Client.ToList();
            response.method = "GET";
            return response;
            
        }



        // GET api/values/5
        public Client Get(int id)
        {
            return lab_2.Client.FirstOrDefault(e => e.ID_Clienta == id);
        }

        // POST api/values
        [HttpPost]
        public Client Post([FromBody]Client value)
        {
            lab_2.Client.Add(value);
            lab_2.SaveChanges();
            return value;
        }
        [HttpPut]
        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]Client value)
        {
            var entity = lab_2.Client.FirstOrDefault(e => e.ID_Clienta == id);
            if (entity == null)
            {
                return Ok(value);
            }
            else
            {
                entity.FIO = value.FIO;
                lab_2.SaveChanges();
                return Ok(value);
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

            Client client = lab_2.Client.Find(id);
            if (client != null)
            {
                lab_2.Client.Remove(client);
                lab_2.SaveChanges();
            }
        }
    }
}
