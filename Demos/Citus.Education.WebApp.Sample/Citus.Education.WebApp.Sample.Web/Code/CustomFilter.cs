using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Citus.Education.WebApp.Sample.Web.Code
{
    public class CustomFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("This Event Fired: OnActionExecuting");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("This Event Fired: OnActionExecuted");
        }
    }

}