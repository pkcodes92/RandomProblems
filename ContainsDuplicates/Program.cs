using System;
using System.Collections.Generic;

namespace ContainsDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 1 };

            bool duplicates = ContainDups(a);

            Console.WriteLine(duplicates);

            Console.ReadKey(); 
        }

        static bool ContainDups(int[] a)
        {
            Dictionary<int, int> b = new Dictionary<int, int>();
            foreach (int x in a)
            {
                if (!b.ContainsKey(x))
                {
                    b.Add(x, 1); 
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
