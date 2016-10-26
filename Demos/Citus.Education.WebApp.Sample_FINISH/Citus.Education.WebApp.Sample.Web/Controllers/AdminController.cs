using Citus.Education.WebApp.Sample.Models;
using Citus.Education.WebApp.Sample.Models.ViewModels;
using Citus.Education.WebApp.Sample.Business.Managers;
using Citus.Education.WebApp.Sample.Common.Exstensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Citus.Education.WebApp.Sample.Web.Models;

namespace Citus.Education.WebApp.Sample.Web.Controllers
{
    //[Authorize(Roles="Admin")]
    public partial class AdminController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult CvCompetenceList()
        {
            var items = CvCompetencesManager.GetCvCompetenceAll();
            return View("CvCompetenceList", items);
        }


        public virtual ActionResult CvCompetenceListAjax()
        {

            return View("CvCompetenceListAjax");
        }

        public virtual JsonResult GetCvCompetenceListAjax(DataTablesRequestModel model)
        {
            int sortColumnId = 0;
            string sortDirection = String.Empty;

            if (model.Order.Count() > 0)
            {
                sortColumnId = model.Order.FirstOrDefault().Column;
                sortDirection = model.Order.FirstOrDefault().Dir;
            }

            var result = CvCompetencesManager.GetCvCompetenceDataTable(model.Length, model.Start, model.Search.Value, sortColumnId, sortDirection);

            return Json(result,
     JsonRequestBehavior.AllowGet);



        }

        [HttpGet]
        public virtual ActionResult CvCompetenceEdit(int? id)
        {
            ViewBag.Message = "Your application description page.";

            var model = CvCompetencesManager.GetCvCompetence(id);
            //person za kojega radimo
            model.PersonId = 1;
            if (id.HasValue)
            {
                model.Message = "Edit";
            }
            else
            {
                model.Message = "Create";
            }

            return View("CvCompetenceEdit", model);
        }

        [HttpPost]
        public virtual ActionResult CvCompetenceEdit(CvCompetenceEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                CvCompetenceModel editModel = model.TranslateTo<CvCompetenceModel>();
                var result = CvCompetencesManager.Save(editModel);

                if (result.ActionSucceed == true)
                {
                    model.Message = "Saved!!!";
                    model.Id = result.EntityId;
                }
                else
                {
                    model.Message = "Not saved!!!";
                }
            }
            //force for Html.HiddenFor...
            ModelState.Clear();

            return View("CvCompetenceEdit", model);
        }

        [HttpGet]
        public virtual ActionResult CvCompetenceView(int? id)
        {
            ViewBag.Message = "Your application description page.";

            var model = CvCompetencesManager.GetCvCompetence(id);
            //person za kojega radimo
            model.PersonId = 1;
            model.Message = "View";

            return View("CvCompetenceView", model);
        }

    }
}