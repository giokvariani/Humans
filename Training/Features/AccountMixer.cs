using System;
using System.Collections.Generic;
using System.Linq;
using Training.BusinessObjects;

namespace Training.Features
{
    public static class AccountMixer
    {
        public static List<Client> Mix()
        {
            var clients = Database.Clients;
            var accounts = Database.Accounts.OrderBy(x => x.ID).ToList();
            foreach (var client in clients)
            {
                var numberOfAccounts = GetRandomQuantityOfAccount();
                for (int i = 0; i < numberOfAccounts; i++)
                {
                    var accountsForClient = accounts.Take(numberOfAccounts).ToList();
                    foreach (var accountForClient in accountsForClient)
                    {
                        PutMoneyOnAccount(accountForClient);
                    }
                    client.Accounts.AddRange(accountsForClient);
                    accounts = accounts.Skip(numberOfAccounts).ToList();
                }
            }

            return clients;
        }

        public static void PutMoneyOnAccount(Account account)
        {
            var random = new Random();
            var value = random.Next(5000);
            account.Value = value;
            account.Currency = GetCurrency();
        }

        public static Currency GetCurrency()
        {
            var currencies = Database.Currencies;
            var random = new Random();
            var randomNumber = random.Next(currencies.Count);
            return currencies[randomNumber];
        }
        
        
        private static int GetRandomQuantityOfAccount()
        {
            var random = new Random();
            return random.Next(3);
        }
    }
}