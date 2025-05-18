using System;
using PrimeFactorLib;

namespace PrimeFactorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer (2–1000): ");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                try
                {
                    Console.WriteLine("Prime factors: " + PrimeCalculator.PrimeFactors(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
