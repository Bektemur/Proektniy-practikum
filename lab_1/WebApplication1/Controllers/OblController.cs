using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OblController : ApiController
    {
        Response response = new Response();
        // GET: api/Obl
        public Response Get()
        {
            var date = HttpContext.Current.Request.QueryString["reg"].ToString();
            string region = "Региона нет в базе"; 
              int reg  = Convert.ToInt32(date);
            if (reg == 72)
                region = "Тюменская область";
            if (reg == 70)
                region = "Томская область";
            if (reg == 71)
                region = "Тульская область";

            List<Region> days = new List<Region>();
            days.Add(new Region
            {
                region=region
            });
            response.url = Request.RequestUri.ToString();
            response.response = days;
            response.method = "GET";
            return response;
        }

        // GET: api/Obl/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Obl
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Obl/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Obl/5
        public void Delete(int id)
        {
        }
    }
}
