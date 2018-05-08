using System;

namespace CommonCharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aabcc";
            string s2 = "adcaa";

            int commonCharacterCount = FindCommonCount(s1, s2);

            Console.WriteLine("There are {0} common characters between {1} and {2}", commonCharacterCount, s1, s2);

            Console.ReadKey(); 
        }

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