namespace DynamicPartitions
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
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