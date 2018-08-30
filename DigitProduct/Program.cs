using System;
using System.Collections.Generic;

namespace DigitProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = 12;

            int digProd = DigitsProduct(product);
            Console.WriteLine($"For {product} = {digProd}");
            Console.ReadKey();
        }

        static int DigitsProduct(int product)
        {
            List<int> intList = new List<int>();
            int ans = 0;

            if (product == 0) return 10;
            if (product == 1) return 1; 

            for (int d = 9; d > 1; d--)
            {
                while (product % d == 0)
                {
                    product /= d;
                    intList.Add(d);
                }
            }

            if (product > 1) return -1; 
            for (int i = intList.Count - 1; i >= 0; i--)
            {
                ans = 10 * ans + intList[i]; 
            }

            return ans;
        }
    }
}