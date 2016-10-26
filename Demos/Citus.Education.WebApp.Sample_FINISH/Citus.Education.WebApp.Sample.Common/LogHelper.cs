using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Citus.Education.WebApp.Sample.Common
{
    public static class LogHelper
    {
            /// <summary>
            /// Manually log an exception to Elmah.  This is very useful for the agents that try/catch all the errors.
            /// 
            /// In order for this to work elmah must be setup in the web.config/app.config file
            /// </summary>
            /// <param name="ex"></param>
            public static void LogError(Exception ex)
            {
                if (HttpContext.Current != null)//website is logging the error
                {
                    //iako raise - ovo ne radi pravi raise greške - što je inače skupo
                    var elmahCon = Elmah.ErrorSignal.FromCurrentContext();
                    elmahCon.Raise(ex);
                }
                else//non website, no http context
                {
                    var elmahCon = Elmah.ErrorLog.GetDefault(null);
                    elmahCon.Log(new Elmah.Error(ex));
                }
            }

            public static void LogError(string errorDescription)
            {
                Elmah.ErrorLog.GetDefault(null).Log(new Elmah.Error(new Exception(errorDescription)));
            }
    }
}
