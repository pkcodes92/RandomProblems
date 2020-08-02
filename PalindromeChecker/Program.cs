// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace PalindromeChecker
{
    using System;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            string inputString = GetInputString();
            bool isPalindrome = CheckIfPalindrome(inputString);
            Console.WriteLine($"Is {inputString} a palindrome? {isPalindrome}");
            Console.WriteLine("Execution is complete, press any key to exit!");
            Console.ReadKey();
        }

        private static string GetInputString()
        {
            return Console.ReadLine();
        }

        private static bool CheckIfPalindrome(string incomingString)
        {
            string first = incomingString.Substring(0, incomingString.Length / 2);
            char[] arr = incomingString.ToCharArray();
            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}