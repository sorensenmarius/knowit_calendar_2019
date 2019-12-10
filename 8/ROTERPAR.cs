﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class ROTERPAR : Operation
    {
        public int DoOperation(int i, List<Wheel> wheels)
        {
            for (int x = 0; x < wheels.Count; x++)
            {
                if (x % 2 == 0)
                {
                    wheels[x].current += 1;
                }
            }
            return i;
        }
    }
}
