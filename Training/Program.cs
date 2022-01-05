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
            var topClient = ზედა_ორ_მეთოდში_დუბლირებული_კოდის_შემჩნევა_საერთო_ლოგიკის_მეთოდში_გატანა_და_გამოძახება_ზედა_ორ_მეთოდში_ისე_რომ_აზრი_არ_შეიცვალოს(clients);
        }



        [ნიმუში]
        public static decimal წამოიღე_ყველაზე_მეტი_ფული_ვისაც_აქვს_ანგარიშზე_იმის_ოდენობა(List<Client> clients)
        {
            return clients.Select(x => x.Accounts.Sum(a => a.Value)).OrderByDescending(x => x).First();
        }

        [დავალება]
        [Done]
        public static decimal წამოიღე_ყველაზე_ნაკლები_ფული_ვისაც_აქვს_ანგარიშზე_იმის_ოდენობა(List<Client> clients)
        {
            return clients.Select(x => x.Accounts.Sum(a => a.Value)).OrderBy(x => x).First();
            //ან 
            //return clients.Select(x => x.Accounts.Sum(a => a.Value)).OrderByDescending(x => x).Last();
        }

        [ნიმუში]
        [Done]
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
        [Done]
        private static Client წამოიღე_ყველაზე_ნაკლები_ფულის_მქონე_კლიენტი(List<Client> clients)
        {

            var clientsWithTotalMoney = clients.Select(x => new
            {
                TotalMoney = x.Accounts.Sum(a => a.Value),
                Client = x
            });
            var bottomClientWithMoney = clientsWithTotalMoney.OrderByDescending(x => x.TotalMoney).Last();

            return bottomClientWithMoney.Client;
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
        private static List<Client> ზედა_ორ_მეთოდში_დუბლირებული_კოდის_შემჩნევა_საერთო_ლოგიკის_მეთოდში_გატანა_და_გამოძახება_ზედა_ორ_მეთოდში_ისე_რომ_აზრი_არ_შეიცვალოს(List<Client> clients)
        {
            var clientWithUSAndEURAccount = clients.Where(client => client.Accounts.Any(account => account.Currency == Currency.USD || account.Currency == Currency.EUR));


            return clientWithUSAndEURAccount.ToList();
        }

        [ნიმუში]
        private static string წამოიღე_ისეთი_კლიენტის_სახელი_რომელიც_ყველაზე_მეტჯერ_გვხვდება_სიაში(List<Client> clients)
        {
            var topName = clients.GroupBy(x => x.FirstName)
                .OrderByDescending(x => x.Count()).First().Key;
            return topName;
        }

        [დავალება]
        [კითხვა("თუ რამე კითხვა გაქვს ასე გადმომეცი ხოლმე პარამეტრად")]
        private static string წამოიღე_ისეთი_კლიენტის_სახელი_რომელიც_ყველაზე_ნაკლებჯერ_გვხდება_სიაში(List<Client> clients)
        {
            return default;
        }

        [ნიმუში]
        private static List<Client> წამოიღე_ისეთი_კლიენტები_რომელთა_სახელები_ყველაზე_მეტჯერ_გვხვდება(List<Client> clients)
        {
            var clientsWithTopName = clients.GroupBy(x => x.FirstName)
                .OrderByDescending(x => x.Count()).First().Select(x => x).ToList();
            return clientsWithTopName;
        }


        [დავალება]
        private static List<Client> წამოიღე_ისეთი_კლიენტები_რომელთა_სახელები_ყველაზე_ნაკლებჯერ_გვხვდება_სიაში(List<Client> clients)
        {
            return default;
        }

        [დავალება]
        private static რა_ტიპი_უნდა_ვიყო წამოიღე_ისეთი_კლიენტი_ვისაც_ყველაზე_მეტი_ფული_აქვს_ისეთი_კლიენტებიდან_რომელთა_სახელიც_ყველაზე_ნაკლებად_გვხვდება_სიაში()
        {
            return default;
        }

        [დავალება]
        private static რა_ტიპი_უნდა_ვიყო წამოიღე_ისეთი_სახელები_რომლებიც_იწყება_ა_ასოზე_კლიენტების_სიიდან()
        {
            return default;
        }

        [დავალება]
        private static რა_ტიპი_უნდა_ვიყო წამოიღე_ისეთი_ყველაზე_ხშირი_სახელი_ისეთი_კლიენტებიდან_რომლის_გვარიც_იწყება_ბ_ასოზე_და_მთავრდება_ი_ასოზე()
        {
            return default;
        }

        [დავალება]
        private static რა_ტიპი_უნდა_ვიყო წამოიღე_ყველაზე_ხშირი_ვალუტა_კლიენტების_სიიდან()
        {
            return default;
        }

        [დავალება]
        private static რა_ტიპი_უნდა_ვიყო არის_თუ_არა_დოლარიანი_ანგარიშები_ლარიან_ანგარიშზე_მეტი_კლიენტების_სიიდან()
        {
            return default;
        }

        [დავალება]
        private static რა_ტიპი_უნდა_ვიყო არის_თუ_არა_კლიენტის_ერთ_ერთ_ანგარიშზე_მაინც_დოლარიანი_ვალუტა_ისეთი_კლიენტებიდან_რომელთა_გვარიც_ყველაზე_ხშირად_გვხვდება()
        {
            return default;
        }

        [დავალება]
        private static რა_ტიპი_უნდა_ვიყო წამოიღე_ყველაზე_გრეძელი_გვარის_მქონე_გვარი_კლიენტებიდან()
        {
            return default;
        }

        [დავალება]
        private static რა_ტიპი_უნდა_ვიყო წამოიღე_ყველაზე_მოკლე_გვარის_მქონე_გვარი_კლიენტებიდან()
        {
            return default;
        }


        [დავალება]
        private static რა_ტიპი_უნდა_ვიყო წამოიღე_ისეთი_კლიენტის_თანხის_ოდენობა_ისეთი_კლიენტებიდან_რომლის_სახელი_ყველაზე_ხშირად_გვხვდება_და_მისი_გვარი_ყველაზე_მოკლეა_მაგ_სიიდან()
        {
            return default;
        }
    }

}