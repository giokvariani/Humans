using System;
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
            var Test = წამოიღე_ისეთი_კლიენტის_თანხის_ოდენობა_ისეთი_კლიენტებიდან_რომლის_სახელი_ყველაზე_ხშირად_გვხვდება_და_მისი_გვარი_ყველაზე_მოკლეა_მაგ_სიიდან(clients);

            
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
            var bottomName = clients.GroupBy(x => x.FirstName).OrderByDescending(x => x.Count()).Last().Key;
            
            return bottomName;
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
            var clientsWithBottomNames = clients.GroupBy(x => x.FirstName).OrderByDescending(x => x.Count()).Last().Select(x => x).ToList();
            return clientsWithBottomNames;
        }

        [დავალება]
        private static Client წამოიღე_ისეთი_კლიენტი_ვისაც_ყველაზე_მეტი_ფული_აქვს_ისეთი_კლიენტებიდან_რომელთა_სახელიც_ყველაზე_ნაკლებად_გვხვდება_სიაში(List<Client> clients)
        {   
            var bottomNames = წამოიღე_ისეთი_კლიენტები_რომელთა_სახელები_ყველაზე_ნაკლებჯერ_გვხვდება_სიაში(clients);
            var bottomNamesTopMoneyTolist = bottomNames.Select(x => new { SumMoney = x.Accounts.Sum(a => a.Value), client = x });            
            var returnbottomNamesTopMoney = bottomNames.OrderByDescending(x => bottomNamesTopMoneyTolist.OrderByDescending(x => x.SumMoney)).First();
            return returnbottomNamesTopMoney;
        }

        [დავალება]
        private static List<string> წამოიღე_ისეთი_სახელები_რომლებიც_იწყება_ა_ასოზე_კლიენტების_სიიდან(List<Client> clients)
        {
            var firstLetter = clients.Where(x => x.FirstName.StartsWith('ა'));

            List<string> namesList = new List<string>();
           
            foreach (var lists in firstLetter)
            {
                namesList.Add(lists.FirstName);
            }

            List<string> returnNameArray = namesList;           

            return returnNameArray;
        }

        [დავალება]
        private static string წამოიღე_ისეთი_ყველაზე_ხშირი_სახელი_ისეთი_კლიენტებიდან_რომლის_გვარიც_იწყება_ბ_ასოზე_და_მთავრდება_ი_ასოზე(List<Client> clients)
        {
            var firstAndLastLetter = clients.Where(x => (x.LastName.StartsWith('ბ')) && (x.LastName.EndsWith('ი')));

            var returnName = firstAndLastLetter.GroupBy(x => x.FirstName).OrderByDescending(x => x.Count()).First()
                .Select(x => x.FirstName).First();

            return returnName;
        }

        [დავალება]
        private static Currency წამოიღე_ყველაზე_ხშირი_ვალუტა_კლიენტების_სიიდან(List<Client> clients)
        {
            var accounts = clients.Select(x => x.Accounts.GroupBy(x => x.Currency).OrderByDescending(x => x.Count()).First().Select(x => x.Currency).First()).First();            

            return accounts;
        }

        [დავალება]
        private static bool არის_თუ_არა_დოლარიანი_ანგარიშები_ლარიან_ანგარიშზე_მეტი_კლიენტების_სიიდან(List<Client> clients)
        {
            var usdAcounts = clients.Select(x => x.Accounts.Where(x => x.Currency == Currency.USD)).Count();
            var gelAcounts = clients.Select(x => x.Accounts.Where(x => x.Currency == Currency.GEL)).Count();



            return usdAcounts > gelAcounts;
        }

        [დავალება]
        private static bool არის_თუ_არა_კლიენტის_ერთ_ერთ_ანგარიშზე_მაინც_დოლარიანი_ვალუტა_ისეთი_კლიენტებიდან_რომელთა_გვარიც_ყველაზე_ხშირად_გვხვდება(List<Client> clients)
        {
            var topLastName = clients.GroupBy(x => x.LastName).OrderByDescending(x => x.Count()).First().Key;


            var usdAcountFromTopLastName = 
                clients.Where(x => x.LastName == topLastName).ToList()
                .Select(x => x.Accounts.Where(x => x.Currency == Currency.USD))
                .FirstOrDefault().Select(x => x.Currency)
                .FirstOrDefault();
                
            return usdAcountFromTopLastName == Currency.USD;
        }

        [დავალება]
        private static List<string> წამოიღე_ყველაზე_გრეძელი_გვარის_მქონე_გვარი_კლიენტებიდან(List<Client> clients)
        {
            var maxLenght = clients.Select(x => x.LastName.Length).Max();

            var getMaxLenghtClient = clients.Where(x => (x.LastName.Length == maxLenght)). Select(x => x.LastName).Distinct().ToList();

            return getMaxLenghtClient;
        }

        [დავალება]
        private static List<string> წამოიღე_ყველაზე_მოკლე_გვარის_მქონე_გვარი_კლიენტებიდან(List<Client> clients)
        {
            var minLenght = clients.Where(x => x.LastName.Length > 0).Select(x => x.LastName.Length).Min();

            var getMinLenghtClient = clients.Where(x => (x.LastName.Length == minLenght)).Select(x => x.LastName).Distinct().ToList();

            return getMinLenghtClient;
        }


        [დავალება]
        private static decimal წამოიღე_ისეთი_კლიენტის_თანხის_ოდენობა_ისეთი_კლიენტებიდან_რომლის_სახელი_ყველაზე_ხშირად_გვხვდება_და_მისი_გვარი_ყველაზე_მოკლეა_მაგ_სიიდან(List<Client> clients)
        {

            var clientsWithTopName = clients.GroupBy(x => x.FirstName).OrderByDescending(x => x.Count()).First().Select(x => x).ToList();

            var minLenghtLastNsme = clientsWithTopName.Select(x => x.LastName.Length).Min();

            var getMinLenghtClient = clientsWithTopName.Where(x => (x.LastName.Length == minLenghtLastNsme)).Select(x => x).ToList();

            var getSumOfAmount = getMinLenghtClient.Sum(x => x.Accounts.Sum(x => x.Value));

            return getSumOfAmount;
        }
    }

}