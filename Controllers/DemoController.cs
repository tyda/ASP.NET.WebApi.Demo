using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    }
}
