// See https://aka.ms/new-console-template for more information
using System;
namespace Harmonic_Number
{
    class program
    {

        public static void Main(string[] args)
        {
             Console.WriteLine("Enter a value");
             int value = Convert.ToInt32(Console.ReadLine());
              double ans = 0;
            for (double i = 1; i <= value; i++)
            {
                ans = ans + 1 / i;
                Console.WriteLine("1/"+i);
            }
            Console.WriteLine("\nHarmonic value of "+ value  +" is " +ans);

        }
    }
}
