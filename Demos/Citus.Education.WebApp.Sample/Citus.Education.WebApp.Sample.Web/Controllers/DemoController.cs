using Citus.Education.WebApp.Sample.Business.Managers;
using Citus.Education.WebApp.Sample.Web.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Citus.Education.WebApp.Sample.Web.Controllers
{

    public partial class DemoController : Controller
    {
        [CustomFilter]
        //[Authorize(Roles = "Admin")]
        [OutputCache(Duration = 30, VaryByParam = "id")]
        public virtual ActionResult Index(int? id, string code, string name)
        {


            ViewBag.Ime = name;
            ViewBag.Vrijeme = DateTime.Now.ToShortTimeString();
            return View("Index");
        }

        [HttpGet]
        public virtual ActionResult Details(int? id)
        {
            Thread.Sleep(1000);
            var model = CvCompetencesManager.GetCvCompetence(id);
            return PartialView("Details", model);
        }



        public virtual ActionResult Pero(int id)
        {
            var model = CvCompetencesManager.GetCvCompetence(id);

            model.Name = "<h1>naziv neki</h1>";

            return View("Pero", model);
        }

        [ChildActionOnly]
        public virtual ActionResult _Comments()
        {

            return PartialView();
        }


        public virtual ActionResult IndexJQuery()
        {
            return View();
        }
    }
}