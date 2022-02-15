// See https://aka.ms/new-console-template for more information
using System;

namespace Leap_year
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 4 digit year");
            int year = Convert.ToInt32(Console.ReadLine());

            int remainder = year % 100;
            int leap_remainder = year % 4;

            if (remainder == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year");
                }
            }
            else if (remainder != 0)
            {
                if (leap_remainder == 0)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year");
                }
            }
        }
    }
}