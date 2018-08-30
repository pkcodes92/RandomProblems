using System;

namespace DigitRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 152;
            int maxValue = DeleteDigit(n);

            Console.WriteLine($"Input value is: {n}");
            Console.WriteLine($"Value is {maxValue}");
            Console.ReadKey();
        }

        static int DeleteDigit(int n)
        {
            string s = n.ToString();
            int i; 
            for (i = 0; i < s.Length - 1; i++)
            {
                if (s[i] < s[i + 1])
                    break;
            }

            return Convert.ToInt32(s.Remove(i, 1));
        }
    }
}