using System;
using System.Collections.Generic;

namespace Feb23
{
    public class TakeMoney
    {
        public static void Withdraw(BankAcc User,List<decimal> Operations,decimal input)
        {
            if (User.Money >= input)
            {
                User.Money -= input;
                Operations.Add(input);
            }
            else
            {
                Console.WriteLine("Not enough balance in account");
            }
        }
    }
}
