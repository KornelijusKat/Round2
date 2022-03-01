using System;
using System.Collections.Generic;

namespace Feb23
{
    public class MainMeniuc
    {
        public static void Meniu(BankAcc User)
        {
            var Operations = new List<decimal>();
            while (true)
            {
                Selection.Selections();
                try
                {
                    Console.WriteLine("Select option");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        Console.WriteLine($"{User.Money} Euro");
                    }
                    else if (option == 2)
                    {
                        ShowTrans.Transactions(Operations);
                    }
                    else if (option == 3)
                    {
                        decimal input = Convert.ToDecimal(Console.ReadLine().Trim('-'));
                        if (LimitChecker.LimitCheck(input, Operations) == true)
                        {
                            TakeMoney.Withdraw(User, Operations, input);
                            SelectChange.LineChanger(User);
                        }
                    }
                    else if (option == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Option doesnt exist, try again");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Option input format is not valid, returning to Menu selection");
                    continue;
                }
            }
        }
    }
}
    

