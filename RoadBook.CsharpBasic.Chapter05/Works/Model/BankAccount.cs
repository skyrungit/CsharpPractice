using System;

namespace RoadBook.CsharpBasic.Chapter05.Works.Model
{
    public class BankAccount
    {

        public BankAccount(string name, string account, int wallet)
        {
            Name = name;
            Account = account;
            Wallet = wallet;
        }

        public string Name { get; set; }
        public string Account { get; set; }
        public int Wallet { get; set; }


    }
}
