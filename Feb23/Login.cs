using System;


namespace Feb23
{
    class ATM
    {
        public static void Login(string card)
        {
            int count = 0;
            bool PassCheck = false;
            while (PassCheck == false)
            {
                Console.WriteLine("Please enter password");
                if (Console.ReadLine() == AccountSele.AccountSelector(card).Password)
                {
                    Console.WriteLine("Log in successful");
                    Console.WriteLine($"{AccountSele.AccountSelector(card).Money} Euro");
                    PassCheck = true;
                }
                else
                {
                    Console.WriteLine("try again");
                    PassCheck = false;
                    count++;
                    if (count == 3)
                    {
                        Console.WriteLine("Incorrect password limit reached, turning off ATM");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
   
}
