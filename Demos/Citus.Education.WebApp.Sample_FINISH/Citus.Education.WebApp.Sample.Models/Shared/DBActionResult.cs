using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citus.Education.WebApp.Sample.Models.Shared
{
    public class DBActionResult
    {
        public DBActionResult()
        {
            ActionSucceed = false;
        }
        public bool ActionSucceed { get; set; }
        public string Message { get; set; }
        public int EntityId { get; set; }
    }
}
