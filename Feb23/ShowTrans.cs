using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb23
{
    public class ShowTrans
    {
        public static void Transactions(List<decimal> operations)
        {
            operations.Reverse();
            List<decimal> kerp = operations.Take(5).ToList();      
            foreach(var item in kerp)
            {
                Console.WriteLine($"{item} Euro, {DateTime.Now}");
            }
        }
    }
}
