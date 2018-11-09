using System;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to compress: ");
            string inputString = Console.ReadLine();

            string outputString = Compress(inputString);

            Console.WriteLine($"{inputString} compressed is: {outputString}");

            Console.ReadKey();
        }

        static string Compress(string inputString)
        {
            string compressedString = "";
            int countConsecutive = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                countConsecutive++;

                /* If the next character is different than current, append this char to result. */
                if (i + 1 >= inputString.Length || inputString[i] != inputString[i + 1])
                {
                    compressedString += "" + inputString[i] + countConsecutive;
                    countConsecutive = 0;
                }
            }

            return compressedString.Length < inputString.Length ? inputString : compressedString;
        }
    }
}