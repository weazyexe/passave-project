namespace Passave
{
    public class BankEntry : BaseEntry
    {
        public BankEntry()
        {

        }

        public BankEntry(string name, string cardNumber, string date, string cvc, string phone, string notes) : base(name, notes)
        {
            CardNumber = cardNumber;
            Date = date;
            CVC = cvc;
            Phone = phone;
        }

        public string CardNumber
        {
            get; set;
        }

        public string Date
        {
            get; set;
        }

        public string CVC
        {
            get; set;
        }

        public string Phone
        {
            get; set;
        }
    }
}
