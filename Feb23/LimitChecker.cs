
using System.Collections.Generic;


namespace Feb23
{
    class LimitChecker
    {
        public static bool LimitCheck(decimal input,List<decimal> operations)
        {
         if(MoneyInput.EuroLimit(input) == false)
            {             
                return false;
            }
         else if(CheckTransAmount.TransCheck(operations) == false)
            {         
                return false;
            }
            return true;
        }
    }
}
