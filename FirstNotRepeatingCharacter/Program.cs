using System;

namespace FirstNotRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of characters: ");
            string s = Console.ReadLine();

            char result = firstNonRepeatingCharacter(s);

            Console.WriteLine($"Result: {result}");

            Console.ReadKey(); 
        }

        static char firstNonRepeatingCharacter(string s)
        {
            char[] inputs = s.ToCharArray();

            char result = '_';

            for (int i = 0; i < inputs.Length; i++)
            {
                if (s.LastIndexOf(s[i]) == s.IndexOf(s[i]))
                {
                    result = s[i];
                    break;
                }
            }

            return result;
        }
    }
}