using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDayFive
{
    internal class powerOfTwo
    {
        public static void powOfTwo(int Number)
        {
            int Result = 1;
            for (int i = 1; i <= Number; i++)
            {
                Result = Result * 2;
                Console.WriteLine("2^{0} = {1}", i, Result);
            }
        }
    }
}
