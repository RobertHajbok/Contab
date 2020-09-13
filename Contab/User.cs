using System;
using System.Windows.Forms;

namespace Contab
{
    public class User
    {
        public User()
        {
        }

        public User(string username, string password, string startingMoney, string currency, DateTime startingDate)
        {
            Username = username;
            Password = password;
            StartingMoney = startingMoney;
            StartingDate = startingDate;
            Currency = currency;
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string StartingMoney { get; set; }

        public DateTime StartingDate { get; set; }

        public string Currency { get; set; }
    }
}
