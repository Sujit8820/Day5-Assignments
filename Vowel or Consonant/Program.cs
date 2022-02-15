// See https://aka.ms/new-console-template for more information
using System;
namespace Vowel_or_Consonant
{
    class program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a alphabet");
            char alphabet = Convert.ToChar(Console.ReadLine());
           
            switch(alphabet)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("\nVowel");
                    break;
                default:
                    Console.WriteLine("\nConsonant");
                    break;

            }
        }
    }
}