using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the numbers, use space between the numbers.");

            /*
             Никак не могу понять как искать двух-, трехзначное число в string. Подскажите пожалуста.
             Никак не могу понять как искать двух-, трехзначное число в string. Подскажите пожалуста.
             Никак не могу понять как искать двух-, трехзначное число в string. Подскажите пожалуста.
             Никак не могу понять как искать двух-, трехзначное число в string. Подскажите пожалуста.
             Никак не могу понять как искать двух-, трехзначное число в string. Подскажите пожалуста.
             Никак не могу понять как искать двух-, трехзначное число в string. Подскажите пожалуста.
             Никак не могу понять как искать двух-, трехзначное число в string. Подскажите пожалуста.
             Никак не могу понять как искать двух-, трехзначное число в string. Подскажите пожалуста.
             Никак не могу понять как искать двух-, трехзначное число в string. Подскажите пожалуста.
             */

            //There must be a better way. If you show me the solution, it will be much appreciated.

            int sum = extractSum();
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static int extractSum()
        {

            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    double digit = Char.GetNumericValue(input[i]);
                    sum = sum + Convert.ToInt32(digit);
                }
            }
            return sum;
        }
    }
}
