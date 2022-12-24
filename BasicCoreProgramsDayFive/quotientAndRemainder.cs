using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDayFive
{
    internal class quotientAndRemainder
    {
        public static void remainderAndQuotient(int Number1, int Number2)          //Creating method
        {
            int quotient = Math.DivRem(Number1, Number2, out int remainder); // using inbuilt method
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
