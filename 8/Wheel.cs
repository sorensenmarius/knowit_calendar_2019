using System;
using System.Collections.Generic;

namespace _8
{
    class Wheel
    {
        private List<Operation> l;
        public int current { get; set; }
        public Wheel(List<Operation> list)
        {
            l = list;
            current = 0;
        }
        public int Next(int i, List<Wheel> wheels)
        {
            current += 1;
            return l[(current - 1) % l.Count].DoOperation(i, wheels);
        }
            
    }

}