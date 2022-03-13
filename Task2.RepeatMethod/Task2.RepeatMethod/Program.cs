using System;

namespace Task2.RepeatMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repeat deyə bir method olsun və iki parametr qəbul etsin
            //biri "word" digəri "count" 
            //yəni bu şəkildə "Repeat(string word, int count)" 
            //bu method göndərilən word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın.
            //Məsələn:
            //Repeat("Ha!") //Ha!
            //Repeat("Ha!", 2) //Ha!Ha!
            //Repeat("Ha!", 3) //Ha!Ha!Ha!

            string repeat = Repeat("Ha!", 3);
            Console.WriteLine(repeat);
        }

        static string Repeat(string word, int count)
        {
            var result = word;

            for (int i = 0; i < count-1; i++)
            {
                result += word;
            }

            return result;
        }
    }
}
