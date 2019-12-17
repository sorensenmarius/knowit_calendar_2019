using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int counter = 0;
            for (long i = 1; i <= 1000000; i++)
            {
                long tri = (i) * (i + 1) / 2;
                foreach (long rot in cal(tri))
                {
                    if (IsSquare(rot))
                    {
                        counter++;
                        break;
                    }
                }
            }
            watch.Stop();
            Console.WriteLine(counter);
            Console.WriteLine(watch.Elapsed);
        }

        static Boolean IsSquare(long i)
        {
            double res = Math.Sqrt(i);
            return res % 1 == 0;
        }

        static long numberOfDigits(long n)
        {
            long cnt = 0;
            while (n > 0)
            {
                cnt++;
                n /= 10;
            }
            return cnt;
        }
        static long[] cal(long num)
        {
            long digits = numberOfDigits(num);
            long powTen = (long)Math.Pow(10, digits - 1);
            long[] rotations = new long[digits];
            rotations[0] = num;
            for (long i = 1; i < digits; i++)
            {

                long firstDigit = num / powTen;
                long left
                    = ((num * 10) + firstDigit)
                    - (firstDigit * powTen * 10);
                rotations[i] = left;
                num = left;
            }
            return rotations;
        }
    }
}
