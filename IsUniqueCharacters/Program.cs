using System;

namespace IsUniqueCharacters
{
    /// <summary>
    /// Problem - Implement an algorithm to determine if a string has all unique
    /// characters. What if you cannot use additional data structures?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a string to analyze: ");

            string inputString = Console.ReadLine();

            var isUnique = ContainsUniqueChars(inputString);

            Console.WriteLine($"Does the provided string => {inputString} contain unique characters? {isUnique}");

            Console.ReadKey();
        }

        /// <summary>
        /// Looks at the characters in the provided string to see if the entire string
        /// contains unique characters
        /// </summary>
        /// <param name="inputString">The string that was provided by the user</param>
        /// <returns>A boolean value to determine if the string contains unique characters or not</returns>
        private static bool ContainsUniqueChars(string inputString)
        {
            if (inputString.Length > 128)
            {
                return false;
            }

            // Having the charSet array to be 128 for ASCII encoding
            bool[] charSet = new bool[128];

            for (int i = 0; i < inputString.Length; i++)
            {
                int val = inputString[i];
                if (charSet[val])
                {
                    return false;
                }

                charSet[val] = true;
            }

            return true;
        }
    }
}