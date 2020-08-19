using System;
using System.Linq;
using StarlingBank;
using StarlingBank.Models;

namespace StarlingBankTestConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            var client = new Client(Configuration.Environments.SANDBOX, "YOUR_TOKEN_HERE");
            var accounts = client.Accounts;
            var myAccounts = accounts.GetAccounts();
            foreach (var myAccountBalance in from account in myAccounts.AccountsProp where account.AccountUid != null select accounts.GetAccountBalance((Guid) account.AccountUid))
            {
                Console.WriteLine("My account balance is " + myAccountBalance.Amount.MinorUnits);
            }
            var spendingInsights = client.SpendingInsights;
            foreach (var spendingInsight in from account in myAccounts.AccountsProp where account.AccountUid != null select spendingInsights.GetQuerySpendingInsightsBySpendingCategory((Guid) account.AccountUid, 2020.ToString(), MonthEnum.JULY))
            {
                Console.WriteLine("My spending insight is  " + spendingInsight.Breakdown.Capacity);
            }
        }

    }
}
