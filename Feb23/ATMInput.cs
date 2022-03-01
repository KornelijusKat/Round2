using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb23
{
    public class ATMInput
    {
        public static bool CardAccCheck(string input)
        {
            if(GuidConfirmer.IsGuid(input) == true)
            {
                if(AccountCheck.AccCheck(input) == true)
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
