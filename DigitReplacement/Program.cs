/*
 * Problem: digitDegree is all about taking the number of digits required in a number and finding out
 * how many digits are required to turn a multi-digit number into a single digit number. 
 */

namespace DigitReplacement
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            int result = DigitDegree(n);

            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }

        static int DigitDegree(int n)
        {
            if (n < 10)
                return 0;

            var times = 0;
            var sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
            while (sum >= 10 || n >= 10)
            {
                times++;
                n = sum;
                sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
            }

            return times;
        }
    }
}
