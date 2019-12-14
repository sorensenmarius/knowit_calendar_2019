using System;
using System.Collections.Generic;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] alf = new int[] { 2, 3, 5, 7, 11 };
            List<int> seq = new List<int>();
            int i = 0;
            int sum = 0;
            while (seq.Count < 217532235)
            {
                if(seq.Count == 0)
                {
                    seq.Add(2);
                    seq.Add(2);
                } else
                {
                    for(int x = 0; x < seq[i]; x++)
                    {
                        seq.Add(alf[i % 5]);
                        if(alf[i % 5] == 7)
                        {
                            sum += 7;
                        }
                    }
                }
                i++;
            }
            Console.WriteLine(sum);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
