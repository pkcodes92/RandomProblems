using System;
using System.Linq;

namespace ReturnLongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Ready, steady, go!";
            string output = LongestWord(text);

            Console.WriteLine($"The longest word is: {output}");
            Console.ReadKey();
        }

        static string LongestWord(string text)
        {
            string[] s = text.Split(new char[]
            {
                ']',
                '[',
                ',',
                '!',
                ' '
            }, StringSplitOptions.RemoveEmptyEntries);

            return s.OrderByDescending(x => x.Length).First();
        }
    }
}