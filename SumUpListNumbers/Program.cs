namespace SumUpListNumbers
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "2 apples, 12 bananas";

            int totalCount = SumUpNumbers(inputString);
            Console.WriteLine($"{inputString} = {totalCount}");

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
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