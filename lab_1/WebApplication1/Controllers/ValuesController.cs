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
    public class ValuesController : ApiController
    {
        Response response = new Response();
        // GET api/values
        
        
       
        public Response Get( )
        {

            var a = HttpContext.Current.Request.QueryString["a"].ToString();
            var b = HttpContext.Current.Request.QueryString["b"].ToString();
            var c = HttpContext.Current.Request.QueryString["c"].ToString();
            double aa = Convert.ToDouble(a);
            double bb = Convert.ToDouble(b);
            double cc = Convert.ToDouble(c);
            double D = Math.Pow(bb, 2) - 4 * aa * cc;
            double x1 = (-bb + Math.Sqrt(D)) / (2 * aa);
            double x2 = (-bb - Math.Sqrt(D)) / (2 * aa);
            List<X1X2> data = new List<X1X2>();
            data.Add(new X1X2
            {
                x1 = x1,
                x2 = x2
            });
            response.url = Request.RequestUri.ToString();
            response.response = data;
            response.method = "GET";
            return response;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
