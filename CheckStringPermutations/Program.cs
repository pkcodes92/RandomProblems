namespace CheckStringPermutations
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a value for a string, s: ");
            string s = Console.ReadLine();

            Console.WriteLine("Please provide a value for a string, t: ");
            string t = Console.ReadLine();

            Console.WriteLine("Please select a solution route to take, and use either 1 or 2");

            int choice = int.Parse(Console.ReadLine());

            var isPermutation = false;
            
            if (choice == 1)
            {
                isPermutation = CheckPermutationSln1(s, t);
            }

            if (choice == 2)
            {
                isPermutation = CheckPermutationSln2(s, t);
            }

            Console.WriteLine($"Are the strings {s} and {t} permutations of each other? {isPermutation}");

            Console.ReadKey();
        }

        private static bool CheckPermutationSln1(string s, string t)
        {
            // Looking at the lengths of the strings
            if (s.Length != t.Length)
            {
                return false;
            }

            return Sort(s) == Sort(t);
        }

        private static string Sort(string s)
        {
            char[] content = s.ToCharArray();
            Array.Sort(content);
            return new string(content);
        }

        private static bool CheckPermutationSln2(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            // Having the assumption for the ASCII encoding
            int[] letters = new int[128];

            // Each time we look at the first string, we increment
            for (int i = 0; i < s.Length; i++)
            {
                letters[s[i]]++;
            }

            // Each time we look at the second string, we decrement
            for (int j = 0; j < t.Length; j++)
            {
                letters[t[j]]--;
                if (letters[t[j]] < 0)
                {
                    return false;
                }
            }

            // Letters has no negative values, 
            // and therefore no positive values either
            return true;
        }
    }
}