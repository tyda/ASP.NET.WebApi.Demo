using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ASP.NET.WebApi.Demo.Controllers
{
    public class Demo2Controller : Controller
    {
        // GET: Demo2
        public int Index([FromBody] IEnumerable<Product> data)
        {
            if(data != null)
            {
                ViewData["items"] = data;
                return data.Count();
            }
            else
            {
                return 0;
            }

        }
    }
}