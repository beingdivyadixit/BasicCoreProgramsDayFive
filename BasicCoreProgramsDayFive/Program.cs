using System;

namespace BasicCoreProgramsDayFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Basic CorePrograms"); //Welcome message
            Console.WriteLine(" Press 1 for Flip Coin and print percentage of Heads and Tails Program \n Press 2 for Leap Year Program");
            int option = Convert.ToInt32(Console.ReadLine()); //storing  input given by user to choose program
            switch (option)
            {
                case 1: // Flip Coin and print percentage of Heads and Tails Program
                    Console.WriteLine("Enter the Number of times you wanted to flip the coin");
                    int N = Convert.ToInt32(Console.ReadLine());
                    flipCoin.coinFlip(N);
                    break;
                case 2: //LEAP YEAR PROGRAM
                    Console.WriteLine("Enter the year to check it's leap year or not");
                    int Year = Convert.ToInt32(Console.ReadLine());
                    if (Year.ToString().Length == 4) // Checking valid year (4 digit)
                        leapYear.yearLeap(Year);
                    else
                        Console.WriteLine("Invalid Input");
                    break;
                default:
                    Console.WriteLine("Please Select Correct input");
                    break;
            }
        }
    }
}
