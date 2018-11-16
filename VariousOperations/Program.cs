using System;

namespace VariousOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The first integer: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(); 

            Console.Write("The second integer: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write($"{x} + {y} = {GetSum(x, y)}" + Environment.NewLine);
            Console.Write($"{x} - {y} = {GetDiff(x, y)}" + Environment.NewLine);
            Console.Write($"{x} * {y} = {GetProduct(x, y)}" + Environment.NewLine);
            Console.Write($"{x} / {y} = {GetQuotient(x, y)}" + Environment.NewLine);
            Console.Write($"{x} mod {y} = {GetRemainder(x, y)}" + Environment.NewLine);

            Console.WriteLine("The program has now completed execution, press any key to quit");
            Console.ReadKey(); 
        }

        private static int GetSum(int x, int y)
        {
            return x + y; 
        }

        private static int GetDiff(int x, int y)
        {
            return x - y; 
        }

        private static int GetProduct(int x, int y)
        {
            return x * y;
        }

        private static int GetQuotient(int x, int y)
        {
            var quot = Convert.ToDouble(x) / y;
            return (int)quot; 
        }

        private static int GetRemainder(int x, int y)
        {
            return x % y; 
        }
    }
}