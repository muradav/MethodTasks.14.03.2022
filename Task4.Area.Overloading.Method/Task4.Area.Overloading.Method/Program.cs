using System;

namespace Task4.Area.Overloading.Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreaMethod(5));
        }

        static double AreaMethod(int radius)
        {
            return Math.PI * radius * radius;
        }

        static int AreaMethod(int a, int b)
        {
            return a * b;
        }

        static double AreaMethod(int a, int b, int c, double r)
        {
            return (a + b + c) / 2 * r;
        }


    }
}
