using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace lab_4.Controllers
{
    public class Default1Controller : ApiController
    {
        // GET: api/Default1
        public Data Get()
        {
            var webClient = new System.Net.WebClient();
            var json = webClient.DownloadString("http://www.mocky.io/v2/5c7db5e13100005a00375fda");//беру строку api
            var JSONObj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(json);// конвенртирую строко в json 
            // var value = ["response"];
            Data data = new Data(); // объявляю класс Data
            data.result = JSONObj["result"];// вытаскиваю значение result
           string s =Convert.ToString(data.result);// преобразоваю в строку
            s= s.Replace(" ", "_");
            data.result = s;
            return data;
        }

        public class Data
        {
            public string result { get; set; }
        }
        
        // GET: api/Default1/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default1
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default1/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default1/5
        public void Delete(int id)
        {
        }
    }
}
