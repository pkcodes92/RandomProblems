namespace CheckSumOfThirty
{
    using System;

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

        /// <summary>
        /// Checks the sum of the numbers to see if it's less than thirty
        /// </summary>
        /// <param name="x">The first integer</param>
        /// <param name="y">The second integer</param>
        /// <returns>A true or false value</returns>
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