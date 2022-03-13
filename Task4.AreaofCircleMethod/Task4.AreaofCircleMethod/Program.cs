using System;

namespace Task4.AreaofCircleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaofcircle = AreaofCircleElements(5);
            Console.WriteLine(areaofcircle);
        }

        static double AreaofCircleElements(double radius)
        {
            return Math.PI * radius * radius;
        }

    }
}
