// <copyright file = "Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace DynamicPartitions
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific command line arguments.</param>
        public static void Main(string[] args)
        {
            var nums = Enumerable.Range(0, 10000).ToArray();
            OrderableListPartitioner<int> partitioner = new OrderableListPartitioner<int>(nums);

            // Use with Parallel.ForEach
            Parallel.ForEach(partitioner, (i) => Console.WriteLine(i));

            // Use with PLINQ
            var query = from num in partitioner.AsParallel()
                        where num % 2 == 0
                        select num;

            foreach (var v in query)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Program execution has terminated, please press any key to exit");
            Console.ReadKey();
        }
    }
}