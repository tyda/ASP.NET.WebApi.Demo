using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ASP.NET.WebApi.Demo.Controllers
{
    public class Demo3Controller : Controller
    {
        // GET: Demo3
        public ActionResult Index()
        {
            return View();
        }
    }
}