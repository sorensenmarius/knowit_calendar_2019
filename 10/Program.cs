using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            String line;
            int counter = 0;
            List<Dag> dager = new List<Dag>();

            System.IO.StreamReader file = new System.IO.StreamReader(@".\logg.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (counter % 4 == 0)
                {
                    dager.Add(new Dag());
                }
                else if (line.EndsWith("tannkrem"))
                {
                    dager[counter / 4].tannkrem = Convert.ToInt32(line.Split(" ")[1]);
                }
                else if (line.EndsWith("sjampo"))
                {
                    dager[counter / 4].sjampo = Convert.ToInt32(line.Split(" ")[1]);
                }
                else if (line.EndsWith("toalettpapir"))
                {
                    dager[counter / 4].toalettpapir = Convert.ToInt32(line.Split(" ")[1]);
                }
                counter += 1;
            }
            int tannkrem = 0;
            int sjampo = 0;
            int toalettpapir = 0;
            int sondag = 0;
            int onsdag = 0;
            for(int i = 0; i < dager.Count; i++)
            {
                tannkrem += dager[i].tannkrem;
                sjampo += dager[i].sjampo;
                toalettpapir += dager[i].toalettpapir;
                if(i % 7 == 2)
                {
                    onsdag += dager[i].toalettpapir;
                } else if(i % 7 == 6)
                {
                    sondag += dager[i].sjampo;
                }
            }
            tannkrem = tannkrem / 125;
            sjampo = sjampo / 300;
            toalettpapir = toalettpapir / 25;
            Console.WriteLine(Convert.ToInt64(tannkrem) * Convert.ToInt64(sjampo) * Convert.ToInt64(toalettpapir) * Convert.ToInt64(onsdag) * Convert.ToInt64(sondag));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
