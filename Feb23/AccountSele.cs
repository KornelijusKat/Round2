using System;
using System.Collections.Generic;
using System.Linq;

namespace Feb23
{
    public class AccountSele
    {
        public static BankAcc AccountSelector(string usercard)
        {
            var AccList = new List<BankAcc>();
            var Bank = new FileReader();
            Bank.ReadFile(AccList);
            var bankUser = AccList.SingleOrDefault(X => X.CardDetail == new Guid(usercard));
            return bankUser;
        }
    }
}
