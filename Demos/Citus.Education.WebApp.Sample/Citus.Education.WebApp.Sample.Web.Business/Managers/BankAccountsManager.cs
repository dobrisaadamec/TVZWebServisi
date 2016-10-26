using Citus.Education.WebApp.Sample.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Citus.Education.WebApp.Sample.Business.Managers
{
    public class BankAccountsManager
    {
        public static List<BankAccountViewModel> GetAccounts()
        {
            //na WCF
            List<BankAccountViewModel> accounts = new List<BankAccountViewModel>();

            List<string> statusList = new List<string>();
            statusList.Add("Aktivan");
            statusList.Add("Neaktivan");
            statusList.Add("Nepoznat");

            for (int i = 0; i < 15; i++)
            {
                BankAccountModel account = new BankAccountModel { Id = i, Code = "000" + i.ToString(), IBAN = "RBZSGSGS" + i.ToString(), Name = "AccountName" + i.ToString(), Status = "Neaktivan" };

                BankAccountViewModel model = new BankAccountViewModel { Account = account, StatusList = statusList};

                accounts.Add(model);
            }
            return accounts;
        }

        public static BankAccountViewModel GetAccount(int id)
        {
            var accounts = GetAccounts();

            var account = accounts.FirstOrDefault(x => x.Account.Id == id);

            return account;
        }

    }
}