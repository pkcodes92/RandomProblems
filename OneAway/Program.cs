using System;

namespace OneAway
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an input for the first string, first: ");
            string first = Console.ReadLine();

            Console.WriteLine("Enter an input for the second string, second: ");
            string second = Console.ReadLine();

            Console.WriteLine("Enter a path of execution, either 1 or 2.");
            int choice = int.Parse(Console.ReadLine());

            // Having the isOneEditAway variable set to false
            var isOneEditAway = false;

            if (choice == 1)
            {
                isOneEditAway = OneEditAwaySln1(first, second); 
            }

            if (choice == 2)
            {
                isOneEditAway = OneEditAwaySln2(first, second);
            }

            Console.WriteLine($"Are {first} and {second} one edit away? {isOneEditAway}");

            Console.ReadKey();
        }

        private static bool OneEditAwaySln1(string first, string second)
        {
            if (first.Length == second.Length)
            {
                return OneEditReplace(first, second); 
            }
            else if (first.Length + 1 == second.Length)
            {
                return OneEditInsert(first, second);
            }
            else if (first.Length - 1 == second.Length)
            {
                return OneEditInsert(first, second);
            }

            return false;
        }

        private static bool OneEditReplace(string s1, string s2)
        {
            var foundDifference = false;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (foundDifference)
                    {
                        return false;
                    }

                    foundDifference = true;
                }
            }

            return true;

        }

        private static bool OneEditInsert(string s1, string s2)
        {
            int index1 = 0, index2 = 0;
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }

            return true;
        }

        private static bool OneEditAwaySln2(string first, string second)
        {
            if (Math.Abs(first.Length - second.Length) > 1)
            {
                return false;
            }

            string s1 = first.Length < second.Length ? first : second;
            string s2 = first.Length < second.Length ? second : first;

            int index1 = 0, index2 = 0;
            bool foundDifference = false;

            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (foundDifference) return false;
                    foundDifference = true;

                    if (s1.Length == s2.Length)
                    {
                        index1++;
                    }
                }
                else
                {
                    index1++;
                }

                index2++;
            }

            return true;
        }
    }
}