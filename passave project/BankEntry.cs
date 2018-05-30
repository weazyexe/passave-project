using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passave
{
    public class BankEntry : BaseEntry
    {
        public BankEntry(string name, string cardNumber, string date, string cvc, string phone, string notes) : base(name, notes)
        {

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
