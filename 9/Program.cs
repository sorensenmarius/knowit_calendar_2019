using java.lang;
using System;
using System.Collections.Generic;
using Math = System.Math;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int count = 0;
            long sum = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(@".\krampus.txt");
            while ((line = file.ReadLine()) != null)
            {
                count += 1;
                long i = Long.parseLong(line);
                long big = Convert.ToInt64(Math.Pow(i, 2));
                List<long> listOfInts = new List<long>();
                while (big > 0)
                {
                    listOfInts.Add(big % 10);
                    big = big / 10;
                }
                listOfInts.ToArray();
                for (int x = 1; x < listOfInts.Count; x++)
                {
                    long b1 = 0;
                    long b2 = 0;
                    for (int y = 0; y < x; y++)
                    {
                        b1 += listOfInts[y] * Convert.ToInt32(Math.Pow(10, y));
                    }
                    for (int y = 0; y < listOfInts.Count - x; y++)
                    {
                        b2 += listOfInts[y + x] * Convert.ToInt32(Math.Pow(10, y));
                    }
                    if (b1 + b2 == i && b1 != 0 && b2 != 0)
                    {
                        sum += i;
                        Console.WriteLine(sum);
                        break;
                    }
                }
            }
            file.Close();
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
