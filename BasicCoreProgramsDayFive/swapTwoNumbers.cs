using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDayFive
{
    internal class swapTwoNumbers
    {
        public static void swap2Numbers(int Number1, int Number2)        //Creating method
        {
            int temp = Number1;
            Console.WriteLine("Numbers before swaping is {0} and {1}", Number1, Number2);
            Number1 = Number2;
            Number2 = temp;
            //Number swapped
            Console.WriteLine("Numbers after swaping is {0} and {1}", Number1, Number2);
        }
    }
}
