// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace WordProblemParser
{
    using System;
    using System.Text.RegularExpressions; 
    
    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Write out a basic word problem. (i.e. {0})", "What is 1 plus 1?");
            string inputWordProblem = Console.ReadLine();

            int problemAnswer = Answer(inputWordProblem);
            Console.WriteLine($"{inputWordProblem} {problemAnswer}");
            Console.WriteLine("The program execution is complete - press any key to exit");
            Console.ReadKey(); 
        }

        /// <summary>
        /// Parser to be able to get the necessary answer provided the 
        /// actual word problem
        /// </summary>
        /// <param name="question">The full on question being asked</param>
        /// <returns>An integer that represents the answer</returns>
        public static int Answer(string question)
        {
            var answer = 0; 
            var match = Regex.Match(question, @"[Ww]hat is (-?\d+)\s?(\w*)\s?b?y?\s?(-?\d*)\s?(\w*)\s?b?y?\s?(-?\d*)\??");

            if (match.Length == 0)
            {
                throw new ArgumentException();
            }

            var number1 = int.Parse(match.Groups[1].Value);
            var operator1 = match.Groups[2].Value;

            // Capture boolean result because failure returns an out of 0
            // which can be a valid input
            var intParseSucceeded = int.TryParse(match.Groups[3].Value, out var number2);
            var operator2 = match.Groups[4].Value;
            int.TryParse(match.Groups[5].Value, out var number3);

            // Can't divide by zero
            if (operator1 == "divided" && number2 == 0 ||
                operator2 == "divided" && number3 == 0)
            {
                throw new DivideByZeroException(); 
            }

            // throw for no number at all or an operator with number
            // following it
            if (number1 == 0 ||
                operator1 != "" && !intParseSucceeded)
            {
                throw new ArgumentException();
            }

            if (operator1 == "")
            {
                return number1;
            }

            switch (operator1)
            {
                case "plus":
                    answer = number1 + number2;
                    break;
                case "minus":
                    answer = number1 - number2;
                    break;
                case "multiplied":
                    answer = number1 * number2;
                    break;
                case "divided":
                    answer = number1 / number2;
                    break;
                default:
                    throw new ArgumentException();
            }

            // no second operator so return what we've got so far
            if (operator2 == "")
            {
                return answer;
            }

            switch (operator2)
            {
                case "plus":
                    answer += number3;
                    break;
                case "minus":
                    answer -= number3;
                    break;
                case "multiplied":
                    answer *= number3;
                    break;
                case "divided":
                    answer /= number3;
                    break;
                default:
                    throw new ArgumentException();
            }

            return answer;
        }
    }
}