using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class STOPP : Operation
    {
        public int DoOperation(int i, List<Wheel> wheels)
        {
            Console.WriteLine($"Stoppet med verdi {i}");
            return -99999;
        }
    }
}
