using System.Collections.Generic;

namespace Training.BusinessObjects
{
    public class Client : Human
    {
        public Client(string fullName) : base(fullName)
        {
            Accounts = new List<Account>();
            IDCounter += 1;
            ID = IDCounter;
        }

        public int ID { get; set; }
        public static int IDCounter { get; set; }
        public List<Account> Accounts { get; set; }
    }
}