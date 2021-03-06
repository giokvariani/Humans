namespace Training.BusinessObjects
{
    public class Account
    {
        public Account(string accountNumber)
        {
            IDCounter += 1;
            ID = IDCounter;
            AccountNumber = accountNumber;
        }
        public Account(string accountNumber, Currency currency)
        {
            IDCounter += 1;
            ID = IDCounter;
            AccountNumber = accountNumber;
            Currency = currency;
        }

        public int ID { get; set; }
        public static int IDCounter { get; set; }
        public string AccountNumber { get; set; }
        public Currency Currency { get; set; }
        public decimal Value { get; set; }

    }
}