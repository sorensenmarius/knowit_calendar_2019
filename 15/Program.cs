using System;
using System.IO;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            using (var rd = new StreamReader("model.csv"))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(',');
                    sum += AreaOfTriangle(
                                            new Point(Convert.ToDouble(splits[0]), Convert.ToDouble(splits[1]), Convert.ToDouble(splits[2])),
                                            new Point(Convert.ToDouble(splits[3]), Convert.ToDouble(splits[4]), Convert.ToDouble(splits[5])),
                                            new Point(Convert.ToDouble(splits[6]), Convert.ToDouble(splits[7]), Convert.ToDouble(splits[8]))
                                            );
                }
            }
            Console.WriteLine(sum / 1000 / 1.413);
        }

        static public double AreaOfTriangle(Point p1, Point p2, Point p3)
        {
            double a = p1.DistanceTo(p2);
            double b = p2.DistanceTo(p3);
            double c = p3.DistanceTo(p1);
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
