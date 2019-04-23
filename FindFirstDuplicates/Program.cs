namespace FindFirstDuplicates
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 2, 1, 3, 5, 3, 2 };

            var result = FirstDuplicates(inputArray);

            Console.WriteLine($"The first duplicates in the input array is found at {result}");

            Console.WriteLine("The program has finished executing, now you may press any key to exit");

            Console.ReadKey();
        }

        private static int FirstDuplicates(int[] a)
        {
            Dictionary<int, int> x = new Dictionary<int, int>();
            foreach (int item in a)
            {
                if (x.ContainsKey(item))
                {
                    return item;
                }
                else
                {
                    x.Add(item, 1); 
                }
            }

            return -1;
        }
    }
}