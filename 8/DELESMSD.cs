using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class DELESMSD : Operation
    {
        public int DoOperation(int i, List<Wheel> wheels)
        {
            Boolean negative = false;
            if (i < 0)
            {
                negative = true;
                i *= -1;
            }
            int i2 = i;
            List<int> listOfInts = new List<int>();
            while (i > 0)
            {
                listOfInts.Add(i % 10);
                i = i / 10;
            }
            listOfInts.ToArray();
            if (negative)
            {
                i2 = (i2 + listOfInts[listOfInts.Count - 1] - 1) / listOfInts[listOfInts.Count - 1];
                i2 *= -1;
            }else
            {
                i2 /= listOfInts[listOfInts.Count - 1];
            }
            return i2;
        }
    }
}
