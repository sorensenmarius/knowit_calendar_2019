using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class GANGESMSD : Operation
    {
        public int DoOperation(int i, List<Wheel> wheels)
        {
            Boolean negative = false;
            if(i < 0)
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

            i2 *= listOfInts[listOfInts.Count - 1];
            if(negative)
            {
                i2 *= -1;
            }
            return i2;
        }
    }
}
