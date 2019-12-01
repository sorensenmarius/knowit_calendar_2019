using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentSize = 50;
            int currentSheep = 0;
            int faileddays = 0;
            int totaldays = 0;
            string[] sheep = System.IO.File.ReadAllText(@"./sau.txt").Split(", ");
            int[] s = Array.ConvertAll(sheep, e => int.Parse(e));

            foreach(int i in s)
            {
                currentSheep += i;
                if (currentSheep < currentSize)
                {
                    currentSize--;
                    currentSheep = 0;
                    faileddays += 1;
                } else
                {
                    currentSheep -= currentSize;
                    currentSize++;
                    faileddays = 0;
                }

                totaldays += 1;
                if (faileddays == 5)
                {
                    Console.WriteLine("Survived " + totaldays + " days");
                    break;
                }
            }
        }
    }
}
