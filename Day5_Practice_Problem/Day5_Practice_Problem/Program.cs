using System;

namespace Day5_Practice_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Head = 1;
            int Tail = 0;
            int headcount = 0;
            int tailcount = 0;
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {


                Console.WriteLine("Flip Coin");
                
                Random random = new Random();
                int flip = random.Next(0, 2);
                Console.WriteLine(flip);

                if (flip == Head)
                {
                    headcount++;
                }
                else
                {
                    tailcount++;
                }

                
            }
            int Head_Percentage = (headcount * 100) / num;
            int Tail_Percentage = (tailcount * 100) / num;
            Console.WriteLine("Head_Percentage" + Head_Percentage);
            Console.WriteLine("Tail_Percentage" + Tail_Percentage);
            Console.WriteLine("how much time Head came" + headcount);
            Console.WriteLine("how much time Tail came" + tailcount);
        }



    }
}
