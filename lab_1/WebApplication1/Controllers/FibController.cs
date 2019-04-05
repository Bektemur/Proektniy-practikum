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
    public class FibController : ApiController
    {
        // GET: api/Fib
        Response response = new Response();
        // GET: api/Obl
        public Response Get()
        {
            var date = HttpContext.Current.Request.QueryString["fib"].ToString();
            
            int number = Convert.ToInt32(date);


          
            int perv = 1;
            int vtor = 1;
            int sum = 0;
            while (number >= sum)
            {
                sum = perv + vtor;

                perv = vtor;
                vtor = sum;
            }
            List<Fibonachi> days = new List<Fibonachi>();
            days.Add(new Fibonachi
            {
                Fibbonachi = vtor
            });
            response.url = Request.RequestUri.ToString();
            response.response = days;
            response.method = "GET";
            return response;
        }

        // GET: api/Fib/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Fib
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Fib/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Fib/5
        public void Delete(int id)
        {
        }
    }
}
