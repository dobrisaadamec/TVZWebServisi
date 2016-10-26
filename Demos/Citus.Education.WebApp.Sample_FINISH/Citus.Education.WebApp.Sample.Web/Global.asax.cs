using Citus.Education.WebApp.Sample.Web.Code;
using Citus.Education.WebApp.Sample.Web.Code.Binders;
using Citus.Education.WebApp.Sample.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Citus.Education.WebApp.Sample.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ModelBinders.Binders.Add(typeof(DataTablesRequestModel), new DataTablesModelBinder());
        }

        protected void Application_BeginRequest()
        {
            try
            {
                // switch na jezik korisnika ako postoji cookie u kojem to piše
                string preferredLang = null;

                string querystringLang = (Request.QueryString["lang"] ?? "").ToLowerInvariant();
                if (querystringLang != "" && "hr-HR,en-US".Contains(querystringLang))
                {
                    // poslan jezik eksplicitno kroz query string
                    // namjerno ne gledamo request.form jer tu može doći do kolizije sa procesima koji spremaju podatke sa POST
                    preferredLang = querystringLang;
                }

                if (preferredLang == null)
                {
                    // možda ima u cookie jezik?
                    HttpCookie langCookie = Request.Cookies[Constants.COOKIE_LANGUAGE];
                    if (langCookie != null)
                    {
                        preferredLang = langCookie.Value.ToLowerInvariant();
                    }
                }
                //set default ako bap nijednog nema
                if (preferredLang == null) {
                    preferredLang = "en-US";
                }

                System.Globalization.CultureInfo userCulture = new System.Globalization.CultureInfo(preferredLang);
                //forsiranje gregorianskog kalendara za sve kulture
                //userCulture.DateTimeFormat.Calendar = new GregorianCalendar();

                System.Threading.Thread.CurrentThread.CurrentUICulture = userCulture;
                System.Threading.Thread.CurrentThread.CurrentCulture = userCulture;

            }
            catch (Exception ex)
            {
                throw (ex.InnerException ?? ex);
            }
        }

    }
}
