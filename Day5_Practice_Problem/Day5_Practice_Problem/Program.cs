﻿using System;

namespace Day5_Practice_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int chk_year;
            Console.Write("\n\n");
            Console.Write("Check whether a given year is leap year or not:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an year : ");
            chk_year = Convert.ToInt32(Console.ReadLine());

            if ((chk_year % 400) == 0)
            {
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            }
            else if ((chk_year % 100) == 0)
            {
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
            }
            else if ((chk_year % 4) == 0)
            {
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
            }


        }
    }
}
