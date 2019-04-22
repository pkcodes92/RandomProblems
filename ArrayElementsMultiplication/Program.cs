namespace ArrayElementsMultiplication
{
    /*
     * Author   : Pranav S. Krishnamurthy
     * 
     * Date     : 31st March 2018
     * 
     * Purpose  : To create a C# console application that will multiply elements
     *            of two arrays and print them out
     */

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] first_array = { 1, 3, -5, 4 };
            int[] second_array = { 1, 4, -5, -2 };

            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

            Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

            for (int i = 0; i < first_array.Length; i++)
            {
                Console.Write(first_array[i] * second_array[i] + " ");
            }

            Console.WriteLine(Environment.NewLine);

            Console.ReadKey();
        }
    }
}