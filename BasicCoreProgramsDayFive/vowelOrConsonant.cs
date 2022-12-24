using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDayFive
{
    internal class vowelOrConsonant
    {
        public static void consonantOrVowel(string Input)         //Creating method
        {

            for (int i = 0; i <= Input.Length; i++) //For loop for condition 

            {
                if (Input[i] == 'a' || Input[i] == 'e' || Input[i] == 'i' || Input[i] == 'o' || Input[i] == 'u')
                {
                    Console.WriteLine("{0} is vowel", Input[i]);
                }
                else if (Input[i] == 'A' || Input[i] == 'E' || Input[i] == 'I' || Input[i] == 'O' || Input[i] == 'U')
                {
                    Console.WriteLine("{0} is vowel" , Input[i]);
                }
                else
                {
                    Console.WriteLine("{0} is consonant", Input[i]);
                }

            }
        }
    }
}
