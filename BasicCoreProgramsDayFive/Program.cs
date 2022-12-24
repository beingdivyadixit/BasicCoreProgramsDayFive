using System;

namespace BasicCoreProgramsDayFive
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(" Press 1 for Flip Coin and print percentage of Heads and Tails Program \n Press 2 for Leap Year Program \n Press 3 for Power of 2 \n Press 4 for Harmonic number program \n Press 5 for Prime Factor Program \n Press 6 for Quotient Remainder \n Press 7 for swap two numbers program");
            int option = Convert.ToInt32(Console.ReadLine()); //storing  input given by user to choose program
            switch (option) // switch case for diffrent programs
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
                case 3:
                    {
                        Console.WriteLine("Enter the number till you want power of two");
                        int Number = Convert.ToInt32(Console.ReadLine());
                        powerOfTwo.powOfTwo(Number);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Enter the number till want harmonic number");
                        int Number = Convert.ToInt32(Console.ReadLine());
                        harmonicNumber.numberHarmonic(Number);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Enter the number to find prime factor");
                        int Number = Convert.ToInt32(Console.ReadLine());
                        primeFactor.factorPrime(Number);
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Please enter value for Dividend"); //Taking user input for dividand
                        int Number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter value for Divisor");   //Taking user input for divisor
                        int Number2 = Convert.ToInt32(Console.ReadLine());
                        quotientAndRemainder.remainderAndQuotient(Number1, Number2);
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Enter first number");
                        int Number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        int Number2 = Convert.ToInt32(Console.ReadLine());
                        swapTwoNumbers.swap2Numbers(Number1, Number2);
                    }
                    break;
                default:
                    Console.WriteLine("Please Select Correct input");
                    break;
            }
        }
    }
}
