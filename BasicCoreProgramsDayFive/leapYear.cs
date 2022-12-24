using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDayFive
{
    internal class leapYear
    {
        public static void yearLeap(int Year)
        {  //if & else if statement for checking year is leap or not
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                Console.WriteLine("The {0} is leap year", Year);
            else
                Console.WriteLine("The {0} is not leap year", Year);
        }
    }
}
