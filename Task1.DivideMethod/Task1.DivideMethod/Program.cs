using System;

namespace Task1.DivideMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Divide(18, 6);
            Console.WriteLine(result);
        }

        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
