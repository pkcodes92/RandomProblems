namespace SortedSearch
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountNumbers(new int[] { 1, 3, 5, 6, 7 }, 4));
            Console.WriteLine("The program has finished execution - you can press any key to exit");
            Console.ReadKey();
        }

        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            var validCnt = 0;

            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (sortedArray[i] < lessThan)
                {
                    validCnt++;
                }
            }

            return validCnt;
        }
    }
}