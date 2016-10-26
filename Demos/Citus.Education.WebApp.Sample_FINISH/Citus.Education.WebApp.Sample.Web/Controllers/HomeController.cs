using Citus.Education.WebApp.Sample.Web.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Citus.Education.WebApp.Sample.Web.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult About()
        {
            CitusEducationWebAppSampleWebAPI c = new CitusEducationWebAppSampleWebAPI();

            var result = c.CV.Get();

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Promjena jezika korisnika - postavka se sprema u cookie i kod slijedećeg requesta uzima u obzir
        /// </summary>
        /// <param name="lang"></param>
        /// <returns></returns>
        public virtual RedirectResult ChangeLanguage(string lang)
        {
            HttpCookie langCookie = new HttpCookie(Constants.COOKIE_LANGUAGE);
            langCookie.Value = lang;
            langCookie.Expires = DateTime.Now.AddYears(5);
            // langCookie.Domain = Request.Url.Host;
            langCookie.Path = "/";

            Response.AppendCookie(langCookie);

            // redirectamo na stranicu s koje je došao
            string redirectUrl = "";
            if (Request.UrlReferrer != null)
            {
                redirectUrl = Request.UrlReferrer.ToString();
            }
            else
            {
                redirectUrl = Url.Content("~/");
            }


            return Redirect(redirectUrl);
        }
    }
}