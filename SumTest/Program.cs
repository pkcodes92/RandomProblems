namespace SumTest
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestSum(1, 2));
            Console.WriteLine(TestSum(2, 3));
            Console.WriteLine(TestSum(3, 3));

            Console.WriteLine("Program has completed execution, press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Function that will return the sum of two numbers in the following conditions: 
        /// - The sum is tripled if the two input numbers are equal
        /// - Otherwise return the sum of the two numbers
        /// </summary>
        /// <param name="x">The first number</param>
        /// <param name="y">The second number</param>
        /// <returns>The sum of the two numbers</returns>
        private static int TestSum(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}