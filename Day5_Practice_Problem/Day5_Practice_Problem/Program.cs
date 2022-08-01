using System;

namespace Day5_Practice_Problem
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Alphabet: ");
            char c;
            c = Console.ReadKey().KeyChar;

            if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
            {
                Console.WriteLine("Entered Char is Vowel");
            }
            else
            {
                Console.WriteLine("Entered Char is a Consonant");
            }
        }

    }
}
