using System;

namespace Day5_Practice_Problem
{
    class Program
    {
        static bool isPowerOfTwo(int n)
        {
            if (n == 0)
                return false;

            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;

                n = n / 2;
            }
            return true;
        }
        static void Main(string[] args)
        {
           

            // Driver program
            
                Console.WriteLine(isPowerOfTwo(31) ? "Yes" : "No");
                Console.WriteLine(isPowerOfTwo(64) ? "Yes" : "No");
            
        }

    }
}
