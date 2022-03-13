using System;

namespace Task4.AreaofTriangleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaoftriangle = AreaofTriangleElements(5, 6, 7, 8);
            Console.WriteLine(areaoftriangle);
        }

        static double AreaofTriangleElements(int a, int b, int c, double r)
        {
            return (a + b + c) / 2 * r;
        }
    }
}
