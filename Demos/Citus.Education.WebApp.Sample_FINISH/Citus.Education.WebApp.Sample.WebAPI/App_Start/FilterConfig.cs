using System.Web;
using System.Web.Mvc;

namespace Citus.Education.WebApp.Sample.WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
