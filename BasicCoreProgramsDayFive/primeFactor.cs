using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDayFive
{
    internal class primeFactor
    {
        public static void factorPrime(int Number)         //Creating method
        {
            int Count = 0;      //Initializing value
            for (int i = 2; i < Number; i++)         //For loop to check condition
            {
                if (Number % i == 0)
                {
                    Count = 1;
                    Console.WriteLine($"{i} is factors of {Number}");

                    for (int j = 2; j <= i - 1; j++)          //For loop to check condition
                    {
                        if (i % j == 0)
                        {
                            Count = 0;
                        }
                    }
                    if (Count == 1)
                    {
                        Console.WriteLine("{0} is prime factor", i);
                    }
                }
            }
        }
    }
}
