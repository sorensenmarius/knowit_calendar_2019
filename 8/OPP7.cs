using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class OPP7 : Operation
    {
        public int DoOperation(int i, List<Wheel> wheels)
        {
            while ((i % 10) < 7)
            {
                i++;
            }
            return i;
        }
    }
}
