// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace FirstNotRepeatingCharacter
{
    using System;

    /// <summary>
    /// This main class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The driver method/main point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of characters: ");
            string s = Console.ReadLine();

            char result = FirstNonRepeatingCharacter(s);

            Console.WriteLine($"Result: {result}");

            Console.ReadKey(); 
        }

        private static char FirstNonRepeatingCharacter(string s)
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