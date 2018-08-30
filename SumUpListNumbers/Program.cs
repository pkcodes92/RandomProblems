using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SumUpListNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "2 apples, 12 bananas";

            int totalCount = SumUpNumbers(inputString);
            Console.WriteLine($"{inputString} = {totalCount}");
            Console.ReadKey();
        }

        static int SumUpNumbers(string inputString)
        {
            int s = 0; 
            foreach(Match match in Regex.Matches(inputString, "[0-9]+"))
            {
                s += Convert.ToInt32(match.Value); 
            }

            return s; 
        }
    }
}