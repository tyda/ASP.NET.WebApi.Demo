using System.Web;
using System.Web.Mvc;

namespace ASP.NET.WebApi.Demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
