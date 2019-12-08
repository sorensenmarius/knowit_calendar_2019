using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long i = 2; i <= 27644437; i++) {
                long b = i * 7;
                long r = b % 27644437;
                if (r == 1)
                { 
                    long z = 5897 * i;
                    long svar = z % 27644437;
                    Console.WriteLine(svar);
                    break;
                }
            }
        }
    }
}
