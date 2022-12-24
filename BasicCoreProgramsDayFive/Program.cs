using System;

namespace BasicCoreProgramsDayFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Basic CorePrograms"); //Welcome message
            Console.WriteLine("Enter the Number of times you wanted to flip the coin"); //  Taking User Input For number of times wanted to flip coin
            int N = Convert.ToInt32(Console.ReadLine());
            flipCoin.coinFlip(N); 
        }
    }
}
