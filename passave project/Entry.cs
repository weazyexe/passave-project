using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passave
{
    public class Entry : BaseEntry
    {
        public string Login
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        public string Phone
        {
            get; set;
        }

        public string URL
        {
            get; set;
        }
    }
}
