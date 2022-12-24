using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDayFive
{
    internal class harmonicNumber
    {
        public static void numberHarmonic(int Number)
        {

            double value = 1;
            for (double n = 1; n <= Number; n++) // For loop 
            { 
                value = value + (1 / value);  
            }
            Console.WriteLine("The harmonic series of number is:" + value);
        }
    }
}
