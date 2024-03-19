using System;
using System.IO;
using FactorialApp;

namespace FactorialCalculator
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                long factorial = Methods.CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.ReadLine(); 
        }
    }
}
