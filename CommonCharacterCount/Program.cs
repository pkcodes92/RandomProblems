namespace CommonCharacterCount
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aabcc";
            string s2 = "adcaa";

            int commonCharacterCount = FindCommonCount(s1, s2);

            Console.WriteLine("There are {0} common characters between {1} and {2}", commonCharacterCount, s1, s2);

            Console.WriteLine("Program has finished executing, you may now press any key to exit");
            Console.ReadKey(); 
        }

        /// <summary>
        /// Method to see how many characters are the same between
        /// two strings that are provided
        /// </summary>
        /// <param name="s1">The first of two hardcoded strings</param>
        /// <param name="s2">The second of two hardcoded strings</param>
        /// <returns>An integer noting the number of common characters</returns>
        static int FindCommonCount(string s1, string s2)
        {
            int count = 0;
            bool[] temp = new bool[30];

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j] && !temp[j])
                    {
                        temp[j] = true;
                        count++;
                        break;
                    }
                }
            }

            return count; 
        }
    }
}