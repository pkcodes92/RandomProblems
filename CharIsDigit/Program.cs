using System;

namespace CharIsDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an input to find out if it is a number: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            bool finalResult = IsDigit(symbol);

            Console.WriteLine($"Is {symbol} a digit? {finalResult}");

            Console.ReadKey();
        }

        static bool IsDigit(char symbol)
        {
            bool valid = true;
            if (char.IsNumber(symbol))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
        }
    }
}