using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Response
    {
        public string url { get; set; }
        public object response { get; set; }
        public string method { get; set; }
    }
}