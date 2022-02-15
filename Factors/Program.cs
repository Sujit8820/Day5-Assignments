// See https://aka.ms/new-console-template for more information
using System;
namespace Factors
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find prime factors");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nFactors");

            for(int i = 1; i <= value; i++)
            {
                int remainder = value % i;

                if (remainder == 0)
                {
                    value = value / i;
                    Console.WriteLine(i);

                    i = 1;
                }
            }


        }
    }
}
