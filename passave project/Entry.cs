﻿namespace Passave
{
    public class Entry : BaseEntry
    {
        public Entry()
        {

        }

        public Entry(string name, string login, string password, string phone, string url, string notes) : base(name, notes)
        {
            Login = login;
            Password = password;
            Phone = phone;
            URL = url;
        }

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
