namespace TupleSorting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This is the main driver class
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            var originalTupleList = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(100, "JFK"),
                new Tuple<int, string>(20, "SEA"),
                new Tuple<int, string>(2, "YVR"),
                new Tuple<int, string>(47, "EWR"),
            };

            List<Tuple<int, string>> sortedDescendingViaLinq = SortThroughLinq(originalTupleList);

            PrintOutput(sortedDescendingViaLinq);

            Console.WriteLine("Program execution has ended, please press any key to terminate");
            Console.ReadKey();
        }

        private static void PrintOutput(List<Tuple<int, string>> sortedDescendingViaLinq)
        {
            foreach (var item in sortedDescendingViaLinq)
            {
                Console.WriteLine($"{item.Item2} - {item.Item1}");
            }
        }

        /// <summary>
        /// This method will be leveraging the System.Linq namespace to be able to sort the list of tuples.
        /// </summary>
        /// <param name="originalTupleList">The original list of tuples.</param>
        /// <returns>A list of tuples gets returned.</returns>
        private static List<Tuple<int, string>> SortThroughLinq(List<Tuple<int, string>> originalTupleList)
        {
            return originalTupleList.OrderByDescending(x => x.Item1).ToList();
        }
    }
}