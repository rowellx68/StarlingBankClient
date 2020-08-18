using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StarlingBankClient.Controllers;
using StarlingBankClient.Exceptions;
using StarlingBankClient.Models;

namespace StarlingBankConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Starting Connection!");
            try
            {
                var client = new StarlingBankClient.Client(StarlingBankClient.Configuration.Environments.SANDBOX, "");

                var accounts = client.Accounts;

                var myAccounts = accounts.GetAccounts();
                foreach (var account in myAccounts.AccountsProp)
                {
                    if (account.AccountUid != null)
                    {
                        var myAccountBalance = accounts.GetAccountBalance((Guid)account.AccountUid);
                        Console.WriteLine("My account balance is " + myAccountBalance.Amount.MinorUnits);
                    }
                }

                var spendingInsights = client.SpendingInsights;
                foreach (var account in myAccounts.AccountsProp)
                {
                    if (account.AccountUid != null)
                    {
                        var spendingInsight = spendingInsights.GetQuerySpendingInsightsBySpendingCategory((Guid) account.AccountUid, 2020.ToString(), MonthEnum.JULY);
                        Console.WriteLine("My spending insight is  " + spendingInsight.Breakdown.Capacity);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
            }

            Console.ReadLine();

        }

    }
}
