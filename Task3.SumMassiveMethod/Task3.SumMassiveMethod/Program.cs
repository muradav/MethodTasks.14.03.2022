using System;

namespace Task3.SumMassiveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = SumMassive(1,2,3,4,5,6,7,8);
            Console.WriteLine(result);

        }

        static int SumMassive(params int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
