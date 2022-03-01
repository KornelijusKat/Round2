using System;
using System.Collections.Generic;
using System.Linq;


namespace Feb23
{
    class AccountCheck
    {
        public static bool AccCheck(string input)
        {
            var AccList = new List<BankAcc>();
            var Bank = new FileReader();
            Bank.ReadFile(AccList);
            var dor = AccList.SingleOrDefault(X => X.CardDetail == new Guid(input));
            if (dor == null)
                {
                    Console.WriteLine("Account does not exist");
                    return false;
                }
            return true;
        }
    }
}
