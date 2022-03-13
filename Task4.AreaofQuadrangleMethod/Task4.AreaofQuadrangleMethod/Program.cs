using System;

namespace Task4.AreaofQuadrangleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaofquadrangle = AreaofQuadrangleElements(5,6);
            Console.WriteLine(areaofquadrangle);
        }

        static int AreaofQuadrangleElements (int a, int b)
        {
            return a * b;
            
        }
    }
}
