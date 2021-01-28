using System;

namespace ConsoleUI
{
    class Program
    {
        // Given a range of numbered days [i...j], and a number k,
        // determine the number of days in the range that are beautiful.
        // Beautiful numbers are defined as numbers where |i-reverse(i)|
        // is evenly divisible by k.If a day's value is a beautiful number,
        // it is a beautiful day. Return the number of beautiful days in the range.
        public static int BeautifulDays(int i, int j, int k)
        {
            
            int output = 0;
            for (int a = i; a <= j; a++)
            {
                int number = a;
                int reversedNumber = 0;
                while (number > 0)
                {
                    reversedNumber = reversedNumber * 10 + (number % 10);
                    number /= 10;
                }
            
                double result = (double) (a - reversedNumber) / k;
                if (result % 1 == 0)
                {
                    output++;
                }
            }
            return output;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(BeautifulDays(20,23,6)); // 2
            Console.WriteLine(BeautifulDays(13,45,3)); // 33
            Console.ReadKey();
        }
    }
}
