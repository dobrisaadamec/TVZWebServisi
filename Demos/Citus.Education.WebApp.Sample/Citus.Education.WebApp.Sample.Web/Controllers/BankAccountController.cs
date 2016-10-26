using Citus.Education.WebApp.Sample.Business.Managers;
using Citus.Education.WebApp.Sample.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Citus.Education.WebApp.Sample.Web.Controllers
{
    public partial class BankAccountController : Controller
    {
        // GET: Account
        public virtual ActionResult Index()
        {
            List<BankAccountViewModel> model = BankAccountsManager.GetAccounts();

            return View("Index", model);
        }
        [HttpGet]
        public virtual ActionResult Edit(int? id)
        {
            BankAccountViewModel model = new BankAccountViewModel();
            if (id.HasValue)
            {
                //napuni model po id-u
                model = BankAccountsManager.GetAccount(id.Value);
            }
            else
            {
                //može biti za New, svo props će biti prazni

            }
            return View("Edit", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(BankAccountViewModel model)
        {

            //TODO Manager Save metoda
            if (ModelState.IsValid)
            {

            }

            model.Message = "Spašeno";

            return View("Edit", model);
        }
    }
}