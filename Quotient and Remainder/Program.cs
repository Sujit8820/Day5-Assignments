// See https://aka.ms/new-console-template for more information
using System;
namespace Quotient_and_Remainder
{
    class program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a divider");
            int divider = Convert.ToInt32(Console.ReadLine());

            int quotient = value / divider;
            int remainder = value % divider;

            Console.WriteLine("\nQuotient: "+quotient +" and remainder: "+ remainder);
        }

    }
}
