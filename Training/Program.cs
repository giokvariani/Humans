using System.Collections.Generic;
using System.Linq;
using Training.Attributes;
using Training.BusinessObjects;
using Training.Features;

namespace Training
{
    internal static class Program
    {
        private static void GeneralExpressions(List<Client> clients)
        {
            var sumValue = clients.Select(x => x.Accounts).ToList();
            var sumBynames = clients.Where(x => x.LastName.Contains("კა")).Select(x => x.Accounts.Sum(x => x.Value));
            var groupBy = clients.GroupBy(x => x.FirstName);
            var specificNatia = clients.Where(x => x.FirstName.Contains("გიორგი")).Select(x => new
            {
                jami = x.Accounts.Sum(x => x.Value),
                vinaoba = x.FullName
            }).Where(x => x.jami > 4000);
        }

        static void Main(string[] args)
        {
            var clients = AccountMixer.Mix();
            var topClient = წამოიღე_ყველაზე_მეტი_ფულის_მქონე_კლიენტი(clients);
        }

        [ნიმუში]
        public static decimal წამოიღე_ყველაზე_მეტი_ფული_ვისაც_აქვს_ანგარიშზე_იმის_ოდენობა(List<Client> clients)
        {
            return clients.Select(x => x.Accounts.Sum(a => a.Value)).OrderByDescending(x => x).First();
        }

        [დავალება]
        public static decimal წამოიღე_ყველაზე_ნაკლები_ფული_ვისაც_აქვს_ანგარიშზე_იმის_ოდენობა()
        {
            return default;
        }

        [ნიმუში]
        private static Client წამოიღე_ყველაზე_მეტი_ფულის_მქონე_კლიენტი(List<Client> clients)
        {
            var clientsWithTotalMoney = clients.Select(x => new
            {
                TotalMoney = x.Accounts.Sum(a => a.Value),
                Client = x
            });
            var topClientWithMoney = clientsWithTotalMoney
                .OrderByDescending(x => x.TotalMoney).First();
            return topClientWithMoney.Client;
        }

        [დავალება]
        private static Client წამოიღე_ყველაზე_ნაკლები_ფულის_მქონე_კლიენტი(List<Client> clients)
        {
            return default;
        }

        [ნიმუში]
        private static List<Client> წამოიღე_ისეთი_კლიენტები_რომელსაც_აქვს_ერთი_მაინც_დოლარიანი_ანგარიში(List<Client> clients)
        {
            var clientWhereContainsUSDAccount =
                clients.Where(client => client.Accounts.Any(account => account.Currency == Currency.USD));
            return clientWhereContainsUSDAccount.ToList();
        }
        
        [ნიმუში]
        private static List<Client> წამოიღე_ისეთი_კლიენტები_რომელსაც_აქვს_ერთი_მაინც_ევროანი_ანგარიში(List<Client> clients)
        {
            var clientWhereContainsUSDAccount =
                clients.Where(client => client.Accounts.Any(account => account.Currency == Currency.EUR));
            return clientWhereContainsUSDAccount.ToList();
        }

        [დავალება]
        private static List<Client> ზედა_ორ_მეთოდში_დუბლირებული_კოდის_შემჩნევა_საერთო_ლოგიკის_მეთოდში_გატანა_და_გამოძახება_ზედა_ორ_მეთოდში_ისე_რომ_აზრი_არ_შეიცვალოს()
        {
            return default;
        }

    }
}