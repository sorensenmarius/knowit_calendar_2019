using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class REVERSERSIFFER : Operation
    {
        public int DoOperation(int i, List<Wheel> wheels)
        {
            Boolean negative = false;
            if (i < 0)
            {
                i *= -1;
                negative = true;
            }
            List<int> listOfInts = new List<int>();
            while (i > 0)
            {
                listOfInts.Add(i % 10);
                i = i / 10;
            }
            listOfInts.ToArray();
            listOfInts.Reverse();
            i = 0;
            for (int x = 0; x < listOfInts.Count; x++)
            {
                i += listOfInts[x] * Convert.ToInt32(Math.Pow(10, x));
            }
            if (negative)
            {
                i *= -1;
            }
            return i;
        }
    }
}
