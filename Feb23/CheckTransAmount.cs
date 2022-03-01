using System;
using System.Collections.Generic;


namespace Feb23
{
    class CheckTransAmount
    {
        public static bool TransCheck(List<decimal> operations)
        {
            if(operations.Count > 10)
            {
                Console.WriteLine("Transaction limit reached");
                return false;
            }
            return true;
        }
    }
}
