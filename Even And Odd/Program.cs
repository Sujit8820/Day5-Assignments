// See https://aka.ms/new-console-template for more information
using System;
namespace Even_And_Odd
{
    class program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int value = Convert.ToInt32(Console.ReadLine());

            int remainder = value % 2;

            if (remainder == 0)
            {
                Console.WriteLine($"{value} is even number");
            }
            else
                Console.WriteLine($"{value} is odd number");

        }
    }
}