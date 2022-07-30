using System;

namespace Day5_Practice_Problem
{
    class Program
    {
       
        static void Main(string[] args)
        {


            int i;
            Console.WriteLine("Enter a Number");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an even number");
                Console.Read();

            }
            else
            {
                Console.Write("Entered Nuumber is an odd number");
                Console.Read();
            }
        }

    }
}
