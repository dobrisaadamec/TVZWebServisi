using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MoviesWS.ASMX
{
    /// <summary>
    /// Summary description for Public
    /// </summary>
    [WebService(Namespace = "http://citus.hr/ws/app/ver1")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class Public : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string DajPodatke()
        {
            return "Pero";
        }
    }
}
