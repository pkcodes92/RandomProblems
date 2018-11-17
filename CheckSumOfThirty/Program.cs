using System;

namespace CheckSumOfThirty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckSum(15, 15));
            Console.WriteLine(CheckSum(10, 20));
            Console.WriteLine(CheckSum(0, 30));
            Console.WriteLine(CheckSum(3, 13));

            Console.WriteLine("The program has finished executing, please enter any key to exit");
            Console.ReadKey(); 
        }

        private static bool CheckSum(int x, int y)
        {
            if ((x + y == 30) || x == 30 || y == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}