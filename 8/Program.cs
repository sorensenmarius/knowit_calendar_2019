using System;
using System.Collections.Generic;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {

            
            for (int x = 0; x < 10; x++)
            {
            List<Wheel> wheels = new List<Wheel>()
                {
                    new Wheel(new List<Operation>() { new PLUSS101(), new OPP7(), new MINUS9(), new PLUSS101()}),
                    new Wheel(new List<Operation>() { new TREKK1FRAODDE(), new MINUS1(), new MINUS9(), new PLUSS1TILPAR()}),
                    new Wheel(new List<Operation>() { new PLUSS1TILPAR(), new PLUSS4(), new PLUSS101(), new MINUS9()}),
                    new Wheel(new List<Operation>() { new MINUS9(), new PLUSS101(), new TREKK1FRAODDE(), new MINUS1()}),
                    new Wheel(new List<Operation>() { new ROTERODDE(), new MINUS1(), new PLUSS4(), new ROTERALLE()}),
                    new Wheel(new List<Operation>() { new GANGESMSD(), new PLUSS4(), new MINUS9(), new STOPP()}),
                    new Wheel(new List<Operation>() { new MINUS1(), new PLUSS4(), new MINUS9(), new PLUSS101()}),
                    new Wheel(new List<Operation>() { new PLUSS1TILPAR(), new MINUS9(), new TREKK1FRAODDE(), new DELESMSD()}),
                    new Wheel(new List<Operation>() { new PLUSS101(), new REVERSERSIFFER(), new MINUS1(), new ROTERPAR()}),
                    new Wheel(new List<Operation>() { new PLUSS4(), new GANGESMSD(), new REVERSERSIFFER(), new MINUS9()})
                };
                int i = x;
                int curr = 0;
                while (i != -99999)
                {
                    if(i < 0)
                    {
                        curr = i * -1;
                    } else
                    {
                        curr = i;
                    }
                    i = wheels[curr % 10].Next(i, wheels);
                }
            }

        }
    }
}
