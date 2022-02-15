// See https://aka.ms/new-console-template for more information
using System;
namespace Harmonic_Number
{
    class program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first no: ");
            double firstNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second no: ");
            double secondNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third no: ");
            double thirdNo = Convert.ToDouble(Console.ReadLine());
            double max = 0;
            double min = 0;

            if (firstNo > secondNo)
            {
                max = firstNo;
            }
            else
                max = secondNo;
            if (thirdNo > max)
            {
                max = thirdNo;
            }
            Console.WriteLine("\nLargest number is "+max);
        }
    }
}

