namespace AvoidingObstacles
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 5, 3, 6, 7, 9 };

            int result = AvoidObstacles(inputArray);

            Console.WriteLine($"Final result: {result}");

            Console.WriteLine("Program execution has completed - you may now press any key to exit");
            Console.ReadKey(); 
        }

        static int AvoidObstacles(int[] inputArray)
        {
            var list = inputArray.ToList();

            for (int i = 1; i < list.Max() + 1; i++)
            {
                if (list.All(n => n % i != 0))
                {
                    return i; 
                }
            }

            return list.Max() + 1; 
        }
    }
}