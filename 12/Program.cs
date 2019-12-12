using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int[] b;
            int result = 0;
            for (int i = 1000; i < 10000; i++)
            {
                if(i % 1111 != 0)
                {
                    int x = i;
                    int counter = 0;
                    while (x != 6174)
                    {
                        counter += 1;
                        a = new int[4];
                        b = new int[4];
                        for (int j = 0; j < 4; j++)
                        {
                            a[j] = x % 10;
                            b[j] = x % 10;
                            x /= 10;
                        }
                        Array.Sort(a);
                        Array.Sort(b);
                        Array.Reverse(b);
                        int n = 0;
                        int m = 0;
                        for (int j = 0; j < 4; j++)
                        {
                            n += a[j] * (int)Math.Pow(10, j);
                            m += b[j] * (int)Math.Pow(10, j);
                        }
                        //Console.WriteLine($"N: {n}, M: {m}");
                        x = n - m;
                    }
                    if (counter > 6)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
