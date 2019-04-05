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
    public class DateController : ApiController
    {
        Response response = new Response();
        // GET api/<controller>
        public Response Get()
        {
            var date = HttpContext.Current.Request.QueryString["date"].ToString();
           DateTime dateTime = Convert.ToDateTime(date);
            List<Day> days = new List<Day>();
            days.Add(new Day
            {
                day_of_the_week = dateTime.ToString("dddd")
            });
            response.url = Request.RequestUri.ToString();
            response.response = days;
            response.method = "GET";
            return response;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}