using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Citus.Education.WebApp.Sample.Models.ViewModels
{
    public class BankAccountViewModel
    {
        public BankAccountModel Account { get; set; }

        public List<string> StatusList { get; set; }

        public string Message { get; set; }
    }
}