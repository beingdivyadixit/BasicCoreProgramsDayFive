using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDayFive
{
    internal class largestAmongThreeNumbers
    {
        public static void largestBetweenThreeNumbers(int Number1, int Number2, int Number3)          //Creating method
        {
            if (Number1 > Number2 && Number1 > Number3)         //If statement for checking condition
                Console.WriteLine("The number {0} is largest", Number1);
            else if (Number2 > Number3)
                Console.WriteLine("The number {0} is largest", Number2);
            else
                Console.WriteLine("The number {0} is largest", Number3);
        }
    }
}
