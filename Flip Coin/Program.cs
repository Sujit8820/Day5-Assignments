// See https://aka.ms/new-console-template for more information
using System;
namespace Flip_Coin
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter no of times flip the coin");
            int number = Convert.ToInt32(Console.ReadLine());
            double tail = 0;
            double head = 0;

            for (int i = 0; i < number; i++)
            {
                Random random = new Random();
                double flip = Convert.ToDouble(random.Next(0, 1000))/1000;

                if (flip < 0.5)
                {
                    //Console.WriteLine("Tail");
                    tail++;
                }
                else
                {
                   // Console.WriteLine("Head");
                    head++;
                }

            }

            double headPercentage = (head / number) * 100;
            double tailPercentage = (tail / number) * 100;

            Console.WriteLine($"Head {head} & Tail {tail}");
            Console.WriteLine($"Head {headPercentage}% & Tail {tailPercentage}%");

        }



    }
}

