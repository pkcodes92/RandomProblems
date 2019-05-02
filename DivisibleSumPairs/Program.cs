namespace DivisibleSumPairs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = int.Parse(nk[0]);

            int k = int.Parse(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = FindDivisiblePairs(n, k, ar);

            Console.WriteLine($"There are {result} pairs for the provided array");
            Console.WriteLine("Program execution has completed - you may press any key to exit");
            Console.ReadKey(); 
        }

        static int FindDivisiblePairs(int n, int k, int[] ar)
        {
            var divisiblePairCnt = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i+1; j < ar.Length; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        divisiblePairCnt++;
                    }
                }
            }

            return divisiblePairCnt; 
        }
    }
}