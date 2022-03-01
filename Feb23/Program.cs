using System;

namespace Feb23
{
    class Program
    {
        static void Main(string[] args)
        {
            string card1 = "bf2cc9aa-9cbc-49b9-8deb-60ed9fbf153e";
            string card2 = "54bd9b65-c1eb-4fa9-92a5-f585b8ae0d5a";
            string card3 = "bf2cc9aa-9cbc-49b9-8deb-60ed9fbf153e";
            if (ATMInput.CardAccCheck(card1) == false)
            {
                Environment.Exit(0);
            }
            ATM.Login(card1);
            MainMeniuc.Meniu(AccountSele.AccountSelector(card1));
        }
    }
}
