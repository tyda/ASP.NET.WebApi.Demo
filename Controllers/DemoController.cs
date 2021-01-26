using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ASP.NET.WebApi.Demo.Controllers
{
    public class DemoController : ApiController
    {
        [HttpPost]
        [Route("aa/bb")]
        public void SendData([FromBody] IEnumerable<Product> data)
        {
            using (StreamWriter tw = new StreamWriter(@"C:\temp\test.txt", true))
            {
                foreach(var product in data)
                {
                    tw.WriteLine(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "," + product.Id + "," + product.ProductName);
                }
            }
        }

        [HttpPost]
        [Route("send/data")]
        public void Send([FromBody] IEnumerable<Product> data)
        {
            Random r = new Random();
            int x = r.Next(-100, 100);
            int y = r.Next(-100, 100);
            int z = r.Next(-100, 100);

            HttpContext.Current.Application["x"] = x;
            HttpContext.Current.Application["y"] = y;
            HttpContext.Current.Application["z"] = z;
        }
        [HttpPost]
        [Route("receive/data")]
        public string Receive([FromBody] IEnumerable<Product> data)
        {
            if(HttpContext.Current.Application["x"] != null)
            {
                var x = HttpContext.Current.Application["x"].ToString();
                var y = HttpContext.Current.Application["y"].ToString();
                var z = HttpContext.Current.Application["z"].ToString();
                return x + "," + y + "," + z;
            }
            else
            {
                return "";
            }
        }
    }
}
