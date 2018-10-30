using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of queries, q: ");
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                int n = int.Parse(tokens[2]);

                DetermineSeriesNTerms(a, b, n);
                Console.WriteLine(); 
            }

            Console.ReadKey(); 
        }

        /// <summary>
        /// Determines the full series for n-terms
        /// </summary>
        /// <param name="a">Input for the initial term</param>
        /// <param name="b">Input for a multiplier</param>
        /// <param name="n">Input to represent the number of terms to limit</param>
        private static void DetermineSeriesNTerms(int a, int b, int n)
        {
            int startTerm = 0;
            int currentTerm = 0;

            for (int i = 0; i < n; i++)
            {          
                if (i == 0)
                {
                    currentTerm = a + (int)Math.Pow(2, 0) * b;
                    startTerm = currentTerm; 
                }
                else
                {
                    currentTerm = startTerm + ((int)Math.Pow(2, i) * b); 
                }

                Console.Write(currentTerm + " "); 
            }
        }
    }
}