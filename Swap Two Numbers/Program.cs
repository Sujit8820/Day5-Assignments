// See https://aka.ms/new-console-template for more information
using System;
namespace Swap_Two_Numbers
{
    class program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double b = Convert.ToDouble(Console.ReadLine());
            double d = b;
            double c = a;
            b = c;
            a = d;
            Console.WriteLine($"first no:{a} and Second no:{b}");
        }
    }
    }
