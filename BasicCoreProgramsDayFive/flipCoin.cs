using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDayFive
{
    internal class flipCoin
    {
        public static void coinFlip(int N)
        {   //variables
            int TailsCount = 0, HeadCount = 0;
            Random random = new Random();
            //loop for flipping coin N (input by user) times 
            for (int i = 0; i < N; i++)
            {
                double FlipCoin = random.NextDouble();
                if (FlipCoin < 0.5)   // if-else statement for checking it's head or tails ... Tails if FlipCoin<0.5  else Head
                {
                    TailsCount = TailsCount + 1;  // counting Tails count
                    Console.WriteLine("It's Tails");
                }
                else
                {
                    HeadCount = HeadCount + 1; // counting head count
                    Console.WriteLine("It's Head");
                }
            }
            double PercentageOfHead = (HeadCount * 100) / N; // calculating percentage of head comming
            double PercentageOfTails = (TailsCount * 100) / N; // calculating percentage of tails comming
            Console.WriteLine("Head came : {0} , Tails came : {1} , Percentage of Head : {2}% & Percentage of Tails : {3}% ", HeadCount, TailsCount, PercentageOfHead, PercentageOfTails);
        }
    }
}
