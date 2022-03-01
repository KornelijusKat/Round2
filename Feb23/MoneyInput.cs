using System;


namespace Feb23
{
    public class MoneyInput
    {
        public static bool EuroLimit(decimal input)
        {      
            if (input > 1000)
            {
                Console.WriteLine("Desired amount is above day limit, returning to menu");
                return false;
            }
            return true;
        }
    }
}
