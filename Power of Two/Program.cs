// See https://aka.ms/new-console-template for more information
using System;

namespace Power_of_Two
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter a power value");
            int power = Convert.ToInt32(Console.ReadLine());
            int MAXPOWER = 31;
            double ans = 1;

            if (power < MAXPOWER && power >= 0)
            {

                for (int i = 0; i <= power; i++)
                {
                    ans = Math.Pow(2, i);

                    Console.WriteLine($" 2 ^ {i} = {ans} ");

                }
            }
            else
                Console.WriteLine("Invalid input");



        }
    }

}
