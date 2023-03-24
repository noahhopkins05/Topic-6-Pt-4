using System;

namespace Topic_6_Pt_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNum, maxNum, randomNum;
            int i = 0;
            Random generator = new Random();

            while (true)
            {
                Console.WriteLine("Enter the minimum number:");
                minNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the maximum number");
                maxNum = Int32.Parse(Console.ReadLine());

                if (minNum > maxNum)
                {
                    Console.WriteLine("Please try again.");
                }

                else
                {
                    while (i < 25)
                    {
                        randomNum = generator.Next(minNum, maxNum + 1);
                        Console.Write(randomNum + " ");
                        i++;

                    }
                    break;
                }
            }
            

            
        }
    }
}